using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SparkFun;
using System.IO;

namespace SF_Phant
{
    public partial class phantWindow : Form
    {
        private phant myDataStream = new phant("", "", "", "");
        public phantWindow()
        {
            InitializeComponent();
            SetupDataFields();
        }

        #region Textbox editing
        private void txtProperty_Leave(object sender, EventArgs e)
        {
            myDataStream.PublicKey = txtPublicKey.Text;
            myDataStream.PrivateKey = txtPrivateKey.Text;
            myDataStream.DeleteKey = txtDeleteKey.Text;
            myDataStream.Fields_CommaSeparated = txtFieldsCSV.Text;

            SetupDataFields();

        }

        private void txtProperties_KeyUp(object sender, KeyEventArgs e)
        {
            //Only go through what you typed if user hits enter
            if (e.KeyCode == Keys.Enter)
            {
                SetupDataFields();
                e.Handled = true;
            }
        }
        #endregion

        #region Fields auto generating input
        private Label[] lblFieldNames;
        private TextBox[] txtFieldValues;
        private string oldFieldsVal;
        private void SetupDataFields()
        {
            //Only run when the fields have changed
            if (txtFieldsCSV.Text == oldFieldsVal) return;
            oldFieldsVal = txtFieldsCSV.Text;

            //Clear out our table
            tableFields.Controls.Clear();

            //Set up our new fields
            string[] FieldNames = txtFieldsCSV.Text.Split(new char[]{','}, StringSplitOptions.None);

            //Setup Table labels and textboxes with all of our fields
            tableFields.ColumnCount = FieldNames.Length;
            tableFields.ColumnStyles.Clear();
            lblFieldNames = new Label[FieldNames.Length];
            txtFieldValues = new TextBox[FieldNames.Length];

            //Set up the labels and text boxes
            for(int i = 0; i<FieldNames.Length; i++)
            {
                //Label setup
                lblFieldNames[i] = new Label();
                lblFieldNames[i].Text = FieldNames[i];
                lblFieldNames[i].Dock = DockStyle.Fill;
                lblFieldNames[i].TextAlign = ContentAlignment.MiddleCenter;
                tableFields.Controls.Add(lblFieldNames[i], i, 0);

                //TextBox setup
                txtFieldValues[i] = new TextBox();
                txtFieldValues[i].Dock = DockStyle.Fill;
                txtFieldValues[i].Text = FieldNames[i];
                txtFieldValues[i].TextAlign = HorizontalAlignment.Center;
                txtFieldValues[i].GotFocus += SelectOnFocus;
                tableFields.Controls.Add(txtFieldValues[i], i, 1);

                //Col setup to make them evenly distributed
                tableFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1f));

            }
        }
        private void SelectOnFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();  //Select all the text in the box when we get focus
        }
        #endregion

        #region Button Actions
        private void btnAddData_Click(object sender, EventArgs e)
        {
            //Change all of our text box data into regular text
            string[] data = new string[txtFieldValues.Length];
            for(int i = 0; i<data.Length; i++) data[i] = txtFieldValues[i].Text;

            //Add our data or error if there is a problem
            if (!myDataStream.AddData(data)) MessageBox.Show("Unable to add data", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); 

            //Can also add data this way, just can't do this dynamically how I did it
            //myDataStream.AddData(Data1val,Data2val);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all data or error when there is a problem
            if (!myDataStream.ClearData()) MessageBox.Show("Unable to clear data", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Message the user when we successfully delete the account
            if (myDataStream.DeleteAccount()) MessageBox.Show("Account Deleted Sucessfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.None);

            // If you don't want to deal with user needing to double click you can also call it 2 times in a row
            //myDataStream.DeleteAccount();
            //myDataStream.DeleteAccount();
        }

        private void btnSaveCSV_Click(object sender, EventArgs e)
        {

            //Open a dialog to save the CSV file
            SaveFileDialog fd = new SaveFileDialog();

            fd.Title = "Save CSV File As...";
            fd.ValidateNames = true;
            fd.OverwritePrompt = true;
            fd.AddExtension = true;
            fd.DefaultExt = "csv";
            fd.Filter = "Comma Seperated Values | *.csv";
            if(fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(fd.FileName, myDataStream.GetCSV());
            }

        }
        #endregion

    }
}
