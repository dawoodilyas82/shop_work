using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventory_Management_System.Utilities
{
    static class DatabaseUtil
    {
        static string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gac.accdb");
        
        //private static string connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= {0}", dbPath);
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=gac;";

        public static DataTable fetchDataQuery(string query)
        {
            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                DataTable adapter_DataTable = new DataTable();
                MySqlDataAdapter adpater = new MySqlDataAdapter(commandDatabase);
                adpater.Fill(adapter_DataTable);
                databaseConnection.Close();
                return adapter_DataTable;
            }
            catch (Exception ex1)
            {
                return null;
            }
        }
        public static bool CommandExecutionQuery(string query)
        {
            try{
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
                return true;
            }
            catch (Exception ex1)
            {
                return false;
            }
        }
        public static bool doesRecordExistAgainstQuery(string query)
        {
            try{
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.HasRows){
                    databaseConnection.Close();
                    return true;
                }
                databaseConnection.Close();
                return false;
            }catch (Exception ex1){
                MessageBox.Show(ex1.ToString());
                return false;
            }
        }
    }
}
