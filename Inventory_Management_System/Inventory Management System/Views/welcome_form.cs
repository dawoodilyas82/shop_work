using System;
using System.Windows.Forms;
using Inventory_Management_System.Utilities;

namespace Inventory_Management_System
{
    public partial class welcome_form : Form
    {
        public welcome_form()
        {
            InitializeComponent();
        }

        private void loginButtonClick(object sender, EventArgs e)
        {
            if (!InventoryModel.isLoggedIn(wel_usr.Text, wel_pass.Text))
            {
                MessageBox.Show("User Name or Password is Incorrect.");
            }
            else
            {
                GeneralUtils.showDashboardForm(this);
            }
            
        }
    }
}