using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Utilities
{
    class DatabaseUtil
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\gac.accdb";

        public DataTable fetchDataQuery(string query)
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
        public bool CommandExecutionQuery(string query)
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
    }
}
