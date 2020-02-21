using Inventory_Management_System.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public class InventoryDataModel
    {
        DatabaseUtil databaseInstance;
        public InventoryDataModel()
        {
            databaseInstance = new DatabaseUtil();
        }
        public DataTable getDataByCode(string code){
            return databaseInstance.fetchDataQuery("SELECT code as Filter_Code, description as Description, qty as Quantity, rate_p_p as Rate_per_piece, rate_p_c as Rate_per_Box,category as Category FROM items where code like '" + code + "%'");
        }
        public DataTable getAllData(){
            return databaseInstance.fetchDataQuery("SELECT code as Filter_Code, description as Description, qty as Quantity, rate_p_p as Rate_per_piece, rate_p_c as Rate_per_Box,category as Category FROM items");
        }
        public bool insertData(string code, string des, string rate_pp, string rate_pc, string quan, string category)
        {
            return databaseInstance.CommandExecutionQuery("insert into items(code,description,rate_p_p,rate_p_c,category,qty) values('" + code + "','" + des + "','" + rate_pp + "','" + rate_pc + "','" + category + "','" + quan + "')");
        }
        public bool deleteData(string code){
            return databaseInstance.CommandExecutionQuery("Delete * FROM items where code='" + code + "'");
        }
        public bool updateData(string code, string des, string rate_pp, string rate_pc, string quan, string category)
        {
            if(deleteData(code) == true)
            {
                return insertData(code, des, rate_pp, rate_pc, quan, category);
            }
            return false;
        }
    }
}
