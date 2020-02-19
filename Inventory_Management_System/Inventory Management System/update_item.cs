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
    
    public partial class update_item : Form
    {
        public Inventory4 temp3;
        public update_item()
        {
            InitializeComponent();
            temp3 = new Inventory4();
        }

        private void new_code_TextChanged(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource= temp3.getData(new_code.Text.ToString());
        }

        private void update_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller_form temp5 = new controller_form();
            temp5.ShowDialog();
            this.Close();
        }

        private void update_b1_Click(object sender, EventArgs e)
        {
            bool flag = temp3.updateData(new_code.Text.ToString(), new_name.Text.ToString(), new_price.Value.ToString(), new_quan.Value.ToString());
            if(!flag)
            {
                MessageBox.Show("Item Not updated.!");
            }
            else
            {
                MessageBox.Show("Item Updated.!!");
                this.Hide();
                controller_form temp6 = new controller_form();
                temp6.ShowDialog();
                this.Close();
            }
        }
    }
}

public class Inventory4
{
    public Inventory4()
    {
        
    }
    public DataTable getData(string code)
    {
        OleDbCommand cmd;
        OleDbConnection Conn;
        Conn = null;
        string lStr_ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\data.accdb";
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
                    cmd.CommandText = "SELECT * FROM items where item_code like '"+ code+"%'";

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
    public bool updateData(string code,string name,string price,string quan)
    {
        OleDbCommand cmd;
        OleDbConnection Conn;
        Conn = null;
        string lStr_ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\data.accdb";
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
                    cmd.CommandText = "Delete * FROM items where item_code='" + code+"'";
                    cmd.ExecuteNonQuery();
                    Conn.Close();

                    Conn = new OleDbConnection(lStr_ConnString);
                    Conn.Open();
                    cmd = new OleDbCommand();
                    cmd.Connection = Conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = cmd.CommandText = "insert into items(item_code,item_name,unit_price,quantity) values('" + code + "','" + name + "','" + price + "','" + quan + "')";
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    return true;

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
        return false;
    }
}
