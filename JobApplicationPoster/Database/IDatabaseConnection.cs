using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApplicationPoster.Database;

namespace JobApplicationPoster.Database
{
    public enum LoginType { ActiveDirectory, UsernameAndPassword };

    interface IDatabaseConnection
    {
        public string TableName { get; set; }
        public void OpenConnection(LoginType type, string username = null);
        //public void CreateNewEntry(Dictionary<string, string> columnAndValues);
        public void CreateNewEntry(string name, string companyName, string jobTitle, string location, string sticker);
        //public void UpdateEntry(int jobID, Dictionary<string, string> columnAndValues);
        public void UpdateEntry(int jobID, string name, string companyName, string jobTitle, string location, string sticker);
        public void DeleteEntry(int jobID);
        public void CloseConnection();

    }
}
