using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DAL_inventory
{
    public class Inventory
    {
        OleDbCommand cmd;
        OleDbConnection Conn;
        public Inventory()
        {
            Conn = null;
        }
        public bool isPresent(string usr,string pass)
        {
            bool isUserPresent = false;
            string lStr_ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\dawoo\\Desktop\\Inventory_Management_System\\DAL_inventory\\bin\\Debug\\data.accdb";
            try
            {
                if (Conn == null)
                {
                    Conn = new OleDbConnection(lStr_ConnString);
                    Conn.Open();
                    OleDbDataReader lObj_DtaReader;
                    try
                    {
                        cmd = new OleDbCommand();
                        cmd.Connection = Conn;
                        //cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM Teams where user_name='"+usr+"' AND ' user_pass='"+pass+"'";

                        lObj_DtaReader = cmd.ExecuteReader();

                        if (lObj_DtaReader.HasRows)
                        {
                            isUserPresent = true;
                        }
                    }
                    catch (Exception ex1)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
            }
            return isUserPresent;
        }
    }
}
