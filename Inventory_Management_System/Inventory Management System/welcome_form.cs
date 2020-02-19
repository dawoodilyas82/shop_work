using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Inventory_Management_System
{
    public partial class welcome_form : Form
    {
        public welcome_form()
        {
            InitializeComponent();
        }

        private void wel_sign_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            bool present=inv.isPresent(wel_usr.Text, wel_pass.Text);
            if (!present)
            {
                MessageBox.Show("User Name or Password is Incorrect.");
            }
            else
            {
                this.Hide();
                controller_form form2 = new controller_form();
                form2.ShowDialog();
                this.Close();
            }
            
        }
    }
}
public class Inventory
{
    OleDbConnection Conn;
    OleDbCommand cmd;
    public Inventory(){
        Conn = null;
        cmd = null;
    }
    public bool isPresent(string usr, string pass)
    {
        string lStr_ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\gac.accdb";
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
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM user_info where name='" + usr + "' AND password='" + pass + "'";

                    lObj_DtaReader = cmd.ExecuteReader();

                    if (lObj_DtaReader.HasRows)
                    {
                        return true;
                    }
                }
                catch (Exception ex1)
                {
                    return false;
                }
            }
        }
        catch (Exception ex)
        {
            return false;
        }
        return false;
    }
}
