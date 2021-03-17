using System;
using System.Windows.Forms;
using Inventory_Management_System.Utilities;

namespace Inventory_Management_System
{
    public partial class Dashboard_form : Form
    {
        public Dashboard_form()
        {
            InitializeComponent();
            mainDataGridView.DataSource = InventoryModel.getAllData();
        }

        private void logoutButtonClick(object sender, EventArgs e)
        {
            GeneralUtils.showWelcomeForm(this);
        }

        private void dash_insert_Click(object sender, EventArgs e)
        {
            GeneralUtils.showNewItemForm(this);
        }

        private void dash_update_Click(object sender, EventArgs e)
        {
            GeneralUtils.showUpdateItemForm(this);
        }

        private void dash_delete_Click(object sender, EventArgs e)
        {
            GeneralUtils.showDeleteItemForm(this);
        }

        private void filterCodeTextChanged(object sender, EventArgs e)
        {
            descBox.Text = "";
            companyBox.Text = "";
            mainDataGridView.DataSource = InventoryModel.getDataByCode(codeBox.Text.ToString());
        }

        private void descriptionBoxTextChanged(object sender, EventArgs e)
        {
            codeBox.Text = "";
            companyBox.Text = "";
            mainDataGridView.DataSource = InventoryModel.getDataByDesc(descBox.Text.ToString());
        }

        private void categoryBoxTextChanged(object sender, EventArgs e)
        {
            descBox.Text = "";
            codeBox.Text = "";
            mainDataGridView.DataSource = InventoryModel.getDataByCompany(companyBox.Text.ToString());
        }
    }
}
