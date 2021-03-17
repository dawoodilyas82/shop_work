using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Utilities
{
    public static class DBConstants
    {
        // Coloum names
        public static string QUANTITY = "qty";
        public static string CODE = "code";
        public static string DESCRIPTION = "description";
        public static string RATE_PER_PIECE = "rate_p_pc";
        public static string ITEMS_PER_BOX = "items_p_c";
        public static string Company = "company";

        // Tables names
        public static string ITEMS_TABLE = "items";
    }
}
