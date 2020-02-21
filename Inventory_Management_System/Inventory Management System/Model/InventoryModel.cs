using Inventory_Management_System.Utilities;
using System.Data;

namespace Inventory_Management_System
{
    public static class InventoryModel
    {
        private static string genericDataFetchQuery = "SELECT code as Filter_Code, description as Description, qty as Quantity, rate_p_p as Rate_per_piece, rate_p_c as Rate_per_Box,category as Category FROM items";
        public static DataTable getDataByCode(string code){
            return DatabaseUtil.fetchDataQuery(genericDataFetchQuery + " where code like '" + code + "%'");
        }
        public static DataTable getDataByDesc(string desc)
        {
            return DatabaseUtil.fetchDataQuery(genericDataFetchQuery + " where description like '%" + desc + "%'");
        }
        public static DataTable getDataByCategory(string category)
        {
            return DatabaseUtil.fetchDataQuery(genericDataFetchQuery + " where category like '" + category + "%'");
        }
        public static DataTable getAllData(){
            return DatabaseUtil.fetchDataQuery(genericDataFetchQuery);
        }
        public static bool insertData(string code, string des, string rate_pp, string rate_pc, string quan, string category)
        {
            if (!doesRecordExist(code))
            {
                return DatabaseUtil.CommandExecutionQuery("insert into items(code,description,rate_p_p,rate_p_c,category,qty) values('" + code + "','" + des + "','" + rate_pp + "','" + rate_pc + "','" + category + "','" + quan + "')");
            }
            return false;
        }
        public static bool deleteData(string code){
            return DatabaseUtil.CommandExecutionQuery("Delete * FROM items where code='" + code + "'");
        }
        public static bool doesRecordExist(string code)
        {
            return DatabaseUtil.doesRecordExistAgainstQuery("SELECT * FROM items where code='" + code + "'");
        }
        public static bool isLoggedIn(string username, string password)
        {
            return DatabaseUtil.doesRecordExistAgainstQuery("SELECT * FROM user_info where name='" + username + "' AND password='" + password + "'");
        }
        public static bool updateData(string code, string des, string rate_pp, string rate_pc, string quan, string category)
        {
            if(deleteData(code) == true)
            {
                return insertData(code, des, rate_pp, rate_pc, quan, category);
            }
            return false;
        }
    }
}
