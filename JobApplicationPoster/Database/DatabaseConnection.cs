using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobApplicationPoster.Database;

namespace JobApplicationPoster
{
    public class DatabaseConnection : IDatabaseConnection
    {
        private SqlConnection sqlconn;
        public string _Password { private get;  set; } // This will have SQL db password.
        private string _ConnectionString { get;  set; }
        public string TableName { get; set; }

        /**
         * Open a sql connection to execute commands.
         */
        public void OpenConnection(LoginType type, string username = null)
        {
            switch (type)
            {
                case LoginType.UsernameAndPassword:
                    _ConnectionString = $@"Server=tcp:jobapplicationposter.database.windows.net,1433;Initial Catalog=JobApplicationPoster;Persist Security Info=False;User ID=jobappadmin;Password={this._Password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                    sqlconn = new SqlConnection(_ConnectionString);
                    sqlconn.Open();
                    break;
                case LoginType.ActiveDirectory:
                    //TODO This needs to be updated. Still researching Azure Active Directory service. I was able to log in through SSMS using Azure AD authentication, but not the connection string below.
                    _ConnectionString = $"Server = tcp:jobapplicationposter.database.windows.net,1433; Initial Catalog = JobApplicationPoster; Persist Security Info = False; User ID = {username}; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Authentication = \"Active Directory Integrated\";";
                    sqlconn = new SqlConnection(_ConnectionString);
                    sqlconn.Open();
                    break;
            }
        }

        public void CloseConnection()
        {
            sqlconn.Close();
        }

        /**
         * Add New entry to table in DB. columnAndValues dictionary keys are column names and the values are values in the table.
         */
        public void CreateNewEntry(Dictionary<string, string> columnAndValues)
        {
            string columms = String.Join(",", columnAndValues.Keys.ToArray());
            string values = String.Join("' ,'", columnAndValues.Values.ToArray());
            values = "'" + values + "'";
            string queryString = $@"INSERT INTO {TableName} ({columms}) VALUES ({values})";
            SqlCommand command = new SqlCommand(queryString, sqlconn);
            command.ExecuteNonQuery();
        }

        /**
         * Upadte jobID to table in DB. columnAndValues dictionary keys are column names and the values are values in the table.
         */
        public void UpdateEntry(int jobID, Dictionary<string, string> columnAndValues)
        {
            string[] elements = new string[columnAndValues.Count];
            int index = 0;
            foreach (var key in columnAndValues.Keys)
            {
                elements[index++] = key + " = '" + columnAndValues[key] + "'";
            }
            string setStatement = String.Join(',', elements);
            string queryString = $@"UPDATE {TableName} SET {setStatement} WHERE jobID = {jobID}";
            SqlCommand command = new SqlCommand(queryString, sqlconn);
            command.ExecuteNonQuery();
        }

        /**
         * Delete entry where jobID is matched.
         */
        public void DeleteEntry(int jobID)
        {
            string queryString = $@"DELETE FROM {TableName} WHERE jobID = {jobID}";
            SqlCommand command = new SqlCommand(queryString, sqlconn);
            command.ExecuteNonQuery();
        }

        /**
         * Test method to test the methods.
         */
        public void Test()
        {
            TableName = "JobData";
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("Name", "Michael Jackson");
            test.Add("CompanyName", "Microsoft");
            test.Add("JobTitle", "Software Engineer");
            test.Add("Location", "Redmond");

            Dictionary<string, string> test2 = new Dictionary<string, string>();
            test2.Add("Name", "John Doe");
            test2.Add("CompanyName", "Redhat");
            test2.Add("JobTitle", "Architect");
            test2.Add("Location", "LA");

            Dictionary<string, string> test3 = new Dictionary<string, string>();
            test3.Add("Name", "Robert Kim");
            test3.Add("CompanyName", "AMD");
            test3.Add("JobTitle", "System Engineer");
            test3.Add("Location", "New York");

            //OpenConnection(LoginType.ActiveDirectory, "eliash0913@gmail.com");
            _Password = "MSSA@&poster";
            OpenConnection(LoginType.UsernameAndPassword);
            CreateNewEntry(test);
            CreateNewEntry(test2);
            UpdateEntry(9, test3);
            DeleteEntry(10);
            CloseConnection();
        }


    }
}
