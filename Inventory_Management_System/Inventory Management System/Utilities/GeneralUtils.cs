using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Utilities
{
    static class GeneralUtils
    {
        public static void showDashboardForm(Form form)
        {
            form.Hide();
            Dashboard_form dashboard = new Dashboard_form();
            dashboard.ShowDialog();
            form.Close();
        }
        public static void showNewItemForm(Form form)
        {
            form.Hide();
            New_item_form newItemForm = new New_item_form();
            newItemForm.ShowDialog();
            form.Close();
        }
        public static void showUpdateItemForm(Form form)
        {
            form.Hide();
            update_item updateItemForm = new update_item();
            updateItemForm.ShowDialog();
            form.Close();
        }
        public static void showDeleteItemForm(Form form)
        {
            form.Hide();
            Delete_form deleteItemForm = new Delete_form();
            deleteItemForm.ShowDialog();
            form.Close();
        }
        public static void showWelcomeForm(Form form)
        {
            form.Hide();
            welcome_form welcomeForm = new welcome_form();
            welcomeForm.ShowDialog();
            form.Close();
        }
    }
}
