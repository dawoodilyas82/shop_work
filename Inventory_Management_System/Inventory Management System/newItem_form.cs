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
    public partial class newItem_form : Form
    {
        public newItem_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory3 new_item_insert = new Inventory3();
            //int flag = new_item_insert.insertItem(filterCode.Text.ToString(), quan.Text.ToString(), price_pc.Value.ToString(), quan.Value.ToString());
            //if (flag==0)
            //{
            //    MessageBox.Show("Item Already exists in inventory.");
            //}
            //else if (flag == -1)
            //{
            //    MessageBox.Show("Database is down.");
            //}
            //else
            //{
            //    MessageBox.Show("Item inserted successfully.");
            //    this.Hide();
            //    controller_form temp = new controller_form();
            //    temp.ShowDialog();
            //    this.Close();
            //}
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller_form temp2 = new controller_form();
            temp2.ShowDialog();
            this.Close();
        }
    }

    public class Inventory3
    {
        OleDbCommand cmd;
        OleDbConnection Conn;
        public Inventory3()
        {
            Conn = null;
        }
        public int insertItem(string code,string des,string rate_pp,string rate_pc, string quan, string category)
        {
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
                        cmd.CommandText = "SELECT * FROM items where code='"+code+"'";

                        OleDbDataReader obj = cmd.ExecuteReader();
                        if(obj.HasRows)
                        {
                            Conn.Close();
                            return 0;
                        }
                        else
                        {
                            Conn.Close();
                            Conn = new OleDbConnection(lStr_ConnString);
                            Conn.Open();
                            cmd.Connection = Conn;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into items(code,description,rate_p_p,rate_p_c,category,qty) values('" + code + "','"+ des +"','" + rate_pp + "','" + rate_pc + "','" + category +"','"+quan+"')";
                            cmd.ExecuteNonQuery();
                            return 1;
                        }

                    }
                    catch (Exception ex1)
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
            return -1;
        }
    }
}
