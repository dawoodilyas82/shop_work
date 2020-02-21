using System;
using System.Windows.Forms;
using Inventory_Management_System.Utilities;

namespace Inventory_Management_System
{
    public partial class New_item_form : Form
    {
        public New_item_form()
        {
            InitializeComponent();
            category.Items.AddRange(new object[] { "Allied", "GAC" });
        }

        private void insertButtonClick(object sender, EventArgs e)
        {
            bool hasInsertedData = InventoryModel.insertData(filterCode.Text.ToString(), des.Text.ToString(), price_pp.Value.ToString(), price_pc.Value.ToString(), quan.Text.ToString(), category.Text.ToString());
            if (!hasInsertedData)
            {
                MessageBox.Show("Item Already exists in inventory or\n Database is down.");
            }
            else
            {
                MessageBox.Show("Item inserted successfully.");
                GeneralUtils.showDashboardForm(this);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            GeneralUtils.showDashboardForm(this);
        }
    }
}