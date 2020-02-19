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
        public UpdateInventory updateInventory;
        public update_item()
        {
            InitializeComponent();
            updateInventory = new UpdateInventory();
            dataGridView1.DataSource = updateInventory.getAllData();
            category.Items.AddRange(new object[] { "Allied", "GAC" });
        }

        private void filterCodeTextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = updateInventory.getDataByCode(filterCode.Text.ToString());
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
            bool flag = updateInventory.updateData(filterCode.Text.ToString(), des.Text.ToString(), price_pp.Value.ToString(), price_pc.Value.ToString(), quan.Text.ToString(), category.Text.ToString());
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

public class UpdateInventory
{
    public UpdateInventory()
    {
        
    }
    public DataTable getDataByCode(string code)
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
    public DataTable getAllData()
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
    public bool updateData(string code,string des,string rate_pp,string rate_pc, string quan, string category)
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
                    cmd.CommandText = "Delete * FROM items where code='" + code+"'";
                    cmd.ExecuteNonQuery();
                    Conn.Close();

                    Conn = new OleDbConnection(lStr_ConnString);
                    Conn.Open();
                    cmd = new OleDbCommand();
                    cmd.Connection = Conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into items(code,description,rate_p_p,rate_p_c,category,qty) values('" + code + "','" + des + "','" + rate_pp + "','" + rate_pc + "','" + category + "','" + quan + "')";
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
