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
 
namespace Inventory_Management_System
{
    public partial class controller_form : Form
    {
        Inventory2 inven;
        public controller_form()
        {
            InitializeComponent();
            inven = new Inventory2();
            dataGridView1.DataSource = inven.getData();
        }

        private void dash_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome_form form1 = new welcome_form();
            form1.ShowDialog();
            this.Close();
        }

        private void dash_insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            newItem_form new_form = new newItem_form();
            new_form.ShowDialog();
            this.Close();
        }

        private void dash_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_item update_form = new update_item();
            update_form.ShowDialog();
            this.Close();
        }

        private void dash_delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_form temp = new delete_form();
            temp.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = inven.getData2(textBox1.Text.ToString());
        }
    }
    public class Inventory2
    {
        OleDbCommand cmd;
        OleDbConnection Conn;
        public Inventory2()
        {
            Conn = null;
        }
        public DataTable getData()
        {
            string lStr_ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\gac.accdb";
            try
            {
                if (Conn == null)
                {
                    Conn = new OleDbConnection(lStr_ConnString);
                    Conn.Open();
                    OleDbDataAdapter lObj;
                    try
                    {
                        cmd = new OleDbCommand();
                        cmd.Connection = Conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT code as Filter_Code, description as Description, qty as Quantity, rate_p_p as Rate_per_piece, rate_p_c as Rate_per_Box,category as Category FROM items";

                        DataTable lObj_DtaTbl = new DataTable();

                        lObj = new OleDbDataAdapter(cmd);
                        lObj.Fill(lObj_DtaTbl);
                        Conn.Close();
                        return lObj_DtaTbl;

                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show(ex1.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }
        public DataTable getData2(string code)
        {
            OleDbCommand cmd;
            OleDbConnection Conn;
            Conn = null;
            string lStr_ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\gac.accdb";
            try
            {
                if (Conn == null)
                {
                    Conn = new OleDbConnection(lStr_ConnString);
                    Conn.Open();
                    OleDbDataAdapter lObj;
                    try
                    {
                        cmd = new OleDbCommand();
                        cmd.Connection = Conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT code as Filter_Code, description as Description, qty as Quantity, rate_p_p as Rate_per_piece, rate_p_c as Rate_per_Box,category as Category FROM items where code like '" + code + "%'";

                        DataTable lObj_DtaTbl = new DataTable();

                        lObj = new OleDbDataAdapter(cmd);
                        lObj.Fill(lObj_DtaTbl);
                        Conn.Close();
                        return lObj_DtaTbl;

                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show(ex1.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }

    }
}
