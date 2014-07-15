namespace SF_Phant
{
    partial class phantWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtDeleteKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFieldsCSV = new System.Windows.Forms.TextBox();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableFields = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveCSV = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPublicKey, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPrivateKey, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDeleteKey, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFieldsCSV, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAddData, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableFields, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveCSV, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 278);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Private Key";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delete Key";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublicKey.Location = new System.Drawing.Point(136, 3);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(579, 20);
            this.txtPublicKey.TabIndex = 3;
            this.txtPublicKey.Leave += new System.EventHandler(this.txtProperty_Leave);
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrivateKey.Location = new System.Drawing.Point(136, 29);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(579, 20);
            this.txtPrivateKey.TabIndex = 4;
            this.txtPrivateKey.Leave += new System.EventHandler(this.txtProperty_Leave);
            // 
            // txtDeleteKey
            // 
            this.txtDeleteKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDeleteKey.Location = new System.Drawing.Point(136, 55);
            this.txtDeleteKey.Name = "txtDeleteKey";
            this.txtDeleteKey.Size = new System.Drawing.Size(579, 20);
            this.txtDeleteKey.TabIndex = 5;
            this.txtDeleteKey.Leave += new System.EventHandler(this.txtProperty_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fields (comma seperated)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFieldsCSV
            // 
            this.txtFieldsCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFieldsCSV.Location = new System.Drawing.Point(136, 81);
            this.txtFieldsCSV.Name = "txtFieldsCSV";
            this.txtFieldsCSV.Size = new System.Drawing.Size(579, 20);
            this.txtFieldsCSV.TabIndex = 7;
            this.txtFieldsCSV.Text = "Data1,Data2";
            this.txtFieldsCSV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProperties_KeyUp);
            this.txtFieldsCSV.Leave += new System.EventHandler(this.txtProperty_Leave);
            // 
            // btnAddData
            // 
            this.btnAddData.AutoSize = true;
            this.btnAddData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnAddData, 2);
            this.btnAddData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddData.Location = new System.Drawing.Point(3, 113);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(712, 23);
            this.btnAddData.TabIndex = 9;
            this.btnAddData.Text = "Add Data";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnClear, 2);
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(3, 142);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(712, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear All Data (Not reversable!!!)";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnDelete, 2);
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(3, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(712, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Account (NOT REVERSABLE AND MUST CLICK 2 TIMES WITHIN 1/2 SECOND FOR IT TO" +
    " WORK)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tableFields
            // 
            this.tableFields.AutoSize = true;
            this.tableFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableFields.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableFields, 2);
            this.tableFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableFields.Location = new System.Drawing.Point(3, 107);
            this.tableFields.Name = "tableFields";
            this.tableFields.RowCount = 2;
            this.tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableFields.Size = new System.Drawing.Size(712, 0);
            this.tableFields.TabIndex = 12;
            // 
            // btnSaveCSV
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnSaveCSV, 2);
            this.btnSaveCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveCSV.Location = new System.Drawing.Point(3, 200);
            this.btnSaveCSV.Name = "btnSaveCSV";
            this.btnSaveCSV.Size = new System.Drawing.Size(712, 23);
            this.btnSaveCSV.TabIndex = 13;
            this.btnSaveCSV.Text = "Save CSV File";
            this.btnSaveCSV.UseVisualStyleBackColor = true;
            this.btnSaveCSV.Click += new System.EventHandler(this.btnSaveCSV_Click);
            // 
            // phantWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 278);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(734, 317);
            this.Name = "phantWindow";
            this.Text = "SparkFun\'s PHANT window";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtDeleteKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFieldsCSV;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tableFields;
        private System.Windows.Forms.Button btnSaveCSV;
    }
}

