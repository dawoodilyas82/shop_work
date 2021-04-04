using Inventory_Management_System.Utilities;
using System.Data;

namespace Inventory_Management_System
{
    public static class InventoryModel
    {
        private static string genericDataFetchQuery = $@"SELECT 
                                                        {DBConstants.CODE} as {LabelConstants.FILTER_CODE}, 
                                                        {DBConstants.DESCRIPTION} as {LabelConstants.DESCRIPTION},
                                                        {DBConstants.QUANTITY} as {LabelConstants.QUANTITY},
                                                        {DBConstants.RATE_PER_PIECE} as {LabelConstants.RATE_PER_PIECE},
                                                        {DBConstants.ITEMS_PER_BOX} as {LabelConstants.ITEMS_PER_BOX},
                                                        {DBConstants.Company} as {LabelConstants.Company} 
                                                        FROM {DBConstants.ITEMS_TABLE}";

        public static DataTable getDataForCode(string code)
        {
            return DatabaseUtil.fetchDataQuery($@"{genericDataFetchQuery} where {DBConstants.CODE} = '{code}'");
        }
        public static DataTable getDataByCode(string code)
        {
            return DatabaseUtil.fetchDataQuery($@"{genericDataFetchQuery} where {DBConstants.CODE} like '{code}%'");
        }
        public static DataTable getDataByDesc(string desc)
        {
            return DatabaseUtil.fetchDataQuery($@"{genericDataFetchQuery} where {DBConstants.DESCRIPTION} like '%{desc}%'");
        }
        public static DataTable getDataByCompany(string company)
        {
            return DatabaseUtil.fetchDataQuery($@"{genericDataFetchQuery} where {DBConstants.Company} like '{company}%'");
        }

        public static DataTable getAllData()
        {
            return DatabaseUtil.fetchDataQuery(genericDataFetchQuery);
        }
        public static bool insertData(string code, string des, string rate_pp, string items_per_box, string quan, string company)
        {
            if (!doesRecordExist(code)){
                return DatabaseUtil.CommandExecutionQuery($@"INSERT into {DBConstants.ITEMS_TABLE}({DBConstants.CODE},{DBConstants.DESCRIPTION},{DBConstants.RATE_PER_PIECE},{DBConstants.ITEMS_PER_BOX},{DBConstants.Company},{DBConstants.QUANTITY}) values('{code}','{des}','{rate_pp}','{items_per_box}','{company}','{quan}')");
            }
            return false;
        }
        public static bool deleteData(string code)
        {
            return DatabaseUtil.CommandExecutionQuery($@"DELETE FROM {DBConstants.ITEMS_TABLE} WHERE {DBConstants.CODE} = '{code}'");
        }
        public static bool doesRecordExist(string code)
        {
            return DatabaseUtil.doesRecordExistAgainstQuery($@"SELECT * FROM {DBConstants.ITEMS_TABLE} WHERE {DBConstants.CODE}='{code}'");
        }
        public static bool isLoggedIn(string username, string password)
        {
            return DatabaseUtil.doesRecordExistAgainstQuery("SELECT * FROM user_info where name='" + username + "' AND password='" + password + "'");
        }
        public static bool updateData(string code, string des, string rate_pp, string items_per_box, string quan, string company)
        {
            if (deleteData(code) == true)
            {
                return insertData(code, des, rate_pp, items_per_box, quan, company);
            }
            return false;
        }
    }
}
