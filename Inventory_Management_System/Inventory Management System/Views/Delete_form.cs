using System;
using System.Windows.Forms;
using Inventory_Management_System.Utilities;

namespace Inventory_Management_System
{
    public partial class Delete_form : Form
    {
        public Delete_form()
        {
            InitializeComponent();
            mainDisplay.DataSource = InventoryModel.getAllData();
        }

        private void deleteCancelClick(object sender, EventArgs e)
        {
            GeneralUtils.showDashboardForm(this);
        }

        private void filterCodeTextChanged(object sender, EventArgs e)
        {
            mainDisplay.DataSource = InventoryModel.getDataByCode(new_code.Text.ToString());
        }
        private void deleteButtonClick(object sender, EventArgs e)
        {
            bool hasDeletedData = InventoryModel.deleteData(new_code.Text.ToString());
            if (!hasDeletedData)
            {
                MessageBox.Show("Item Not Deleted!");
            }
            else
            {
                MessageBox.Show("Item Deleted.");
                GeneralUtils.showDashboardForm(this);
            }
        }
    }
}
