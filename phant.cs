/***************************************************************************************
 * []D   []-[]   //-\\   []\[]   ""[]""  in C#
 * 
 * Created by:      <--REDACTED--> (TC)
 * Date:            7/11/14
 * Version:         1.0
 * 
 * Updates
 * 1.0  -   Initial release
 * 
 * 
****************************************************************************************/

using System;
using System.Text;      //Needed for String Builder
using System.Net;       //Needed for the Web Requests
using System.IO;        //Needed for Streams

namespace SparkFun
{
    class phant
    {

        #region Public properties
        /// <summary>
        /// The public key given when you created a phant data stream
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// The private key given when you created a phant data stream
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// The Delete key given when you created a phant data stream
        /// </summary>
        public string DeleteKey { get; set; }

        /// <summary>
        /// This is what you entered exactly in the fields window when you created a phant data stream
        /// </summary>
        public string Fields_CommaSeparated
        {
            set { FieldNames = value.Split(','); }
            get { return string.Join(",", FieldNames); }
        }

        /// <summary>
        /// This is the base server location for the phant server.  Default is http://data.sparkfun.com (note no last slash)
        /// </summary>
        public string ServerLocation { get { return BaseHost_URL; } set { BaseHost_URL = value; } }
        #endregion


        #region URL setup & private variables
        private string BaseHost_URL = "http://data.sparkfun.com";    // Default to using SparkFun's site
        private string ViewData_URL { get { return BaseHost_URL + "/streams/" + PublicKey; } }
        private string AddData_BaseURL { get { return BaseHost_URL + "/input/" + PublicKey + "?private_key=" + PrivateKey; } }
        private string ClearData_URL { get { return BaseHost_URL + "/input/" + PublicKey + "/clear?private_key=" + PrivateKey; } }
        private string DeleteAccount_URL { get { return BaseHost_URL + "/streams/" + PublicKey + "/delete/" + DeleteKey; } }
        private string GetFiledata_URL { get { return BaseHost_URL + "/output/" + PublicKey + "."; } }

        /// <summary>
        /// The fields separated into their individual components
        /// </summary>
        private string[] FieldNames;

        /// <summary>
        /// Time stamp of last try to delete the account
        /// </summary>
        private DateTime LastDeleteRun;
        #endregion


        #region Constructor & public methods
        /// <summary>
        /// The phant class is the full implementation of the interface to store data on a phant engine
        /// </summary>
        /// <param name="PublicKey">The Public Key given during the creation of your data stream</param>
        /// <param name="PrivateKey">The Private Key given during the creation of your data stream</param>
        /// <param name="DeleteKey">The Delete Key given during the creation of your data stream</param>
        /// <param name="Fields_CommaSeparated">The Fields should be exactly how you provided them in the creation of the data stream, commas and all</param>
        public phant(string PublicKey, string PrivateKey, string DeleteKey, string Fields_CommaSeparated)
        {
            this.PublicKey = PublicKey;
            this.PrivateKey = PrivateKey;
            this.DeleteKey = DeleteKey;
            this.Fields_CommaSeparated = Fields_CommaSeparated;
            this.LastDeleteRun = DateTime.Now - TimeSpan.FromSeconds(15);
        }

        /// <summary>
        /// Adds data to our Data Stream in the sky!  Remember the order of the fields you selected and place them here in the same order.
        /// </summary>
        /// <param name="Values">The list of items to store.  Can be any type, just make sure that the conversion to string is what you want</param>
        /// <returns>True if all goes good, False if there was a problem</returns>
        public bool AddData(params object[] Values)
        {
            // Make sure we have enough parameters for each of our fields
            if (Values.Length != FieldNames.Length) return false;

            // Build up our URL to store the data
            StringBuilder sb = new StringBuilder(AddData_BaseURL);
            for (int i = 0; i < FieldNames.Length; i++)
            {
                sb.Append("&" + FieldNames[i] + "=" + Values[i]);
            }

            // Run our URL
            return RunURL(sb.ToString()).Contains("1 success");
        }

        /// <summary>
        /// Clears ALL data in the list.  Data is not recoverable!!
        /// </summary>
        /// <returns>TTrue if all goes good, False if there was a problem</returns>
        public bool ClearData()
        {
            return RunURL(ClearData_URL).Contains("1 success");
        }

        /// <summary>
        /// Delete account must be called 2 times in short 1 succession (within 1/2 sec) in order to delete the account!!!  
        /// No Recovery!!! All will be lost!!!  You will need a new account to do anything else!!!  AAaahhhh!!!
        /// </summary>
        /// <returns>True if all goes good, False if there was a problem or on the first time</returns>
        public bool DeleteAccount()
        {
            // Only run if this is the second time called in 1/2 a second
            if((DateTime.Now - LastDeleteRun).TotalMilliseconds < 500)
                return RunURL(DeleteAccount_URL).ToLower().Contains("html"); // the response after a delete returns the home page

            LastDeleteRun = DateTime.Now;
            return false;
        }

        /// <summary>
        /// Gets all data from the server.
        /// </summary>
        /// <returns>Data in CSV format</returns>
        public string GetCSV()
        {
            return RunURL(GetFiledata_URL + "csv");
        }
        #endregion


        #region Private methods
        /// <summary>
        /// Reads the provided URL and returns the string response
        /// </summary>
        /// <param name="URL">URL string like "http://data.sparkfun.com"</param>
        /// <returns>The page requested</returns>
        private string RunURL(string URL)
        {
            string RetVal = string.Empty;

            try //Catch all errors from the server if stuff is malformed
            {
                // Set up our web request for our URL
                WebRequest request = WebRequest.Create(URL);

                // Get the response
                WebResponse response = request.GetResponse();

                // Set up the return stream to see what we get
                StreamReader reader = new StreamReader(response.GetResponseStream());

                // Check that we have a 1 success
                RetVal = reader.ReadToEnd();

                // Clean up
                reader.Close();
                response.Close();

            }
            catch {  }
            return RetVal;
        }
        #endregion
    }
}
