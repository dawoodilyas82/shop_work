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
    public partial class delete_form : Form
    {
        Inventory5 temp8;
        public delete_form()
        {
            InitializeComponent();
            temp8 = new Inventory5();
        }

        private void update_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller_form temp7 = new controller_form();
            temp7.ShowDialog();
            this.Close();
        }

        private void new_code_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = temp8.getData(new_code.Text.ToString());
        }
        private void update_b1_Click(object sender, EventArgs e)
        {
            bool flag = temp8.DeleteItem(new_code.Text.ToString());
            if (!flag)
            {
                MessageBox.Show("Item Not Deleted.!");
            }
            else
            {
                MessageBox.Show("Item Deleted.!!");
                this.Hide();
                controller_form temp6 = new controller_form();
                temp6.ShowDialog();
                this.Close();
            }
        }
    }
}
public class Inventory5
{
    public Inventory5()
    {

    }
    public DataTable getData(string code)
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
    public bool DeleteItem(string code)
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
                try
                {
                    cmd = new OleDbCommand();
                    cmd.Connection = Conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete * FROM items where code='" + code + "'";
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    return true;

                }
                catch (Exception ex1)
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Something Went Wrong");
        }
        return false;
    }
}
