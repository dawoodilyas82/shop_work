using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Inventory_Management_System.Utilities
{
    static class DatabaseUtil
    {
        static string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gac.accdb");
        
        private static string connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= {0}", dbPath);

        public static DataTable fetchDataQuery(string query)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();
                OleDbDataAdapter adpater;
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                DataTable adapter_DataTable = new DataTable();

                adpater = new OleDbDataAdapter(command);
                adpater.Fill(adapter_DataTable);
                connection.Close();
                return adapter_DataTable;

            }
            catch (Exception ex1)
            {
                return null;
            }
        }
        public static bool CommandExecutionQuery(string query)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
                return true;

            }
            catch (Exception ex1)
            {
                return false;
            }
        }
        public static bool doesRecordExistAgainstQuery(string query)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;

                OleDbDataReader obj = command.ExecuteReader();
                if (obj.HasRows)
                {
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;

            }
            catch (Exception ex1)
            {
                return false;
            }
        }
    }
}
