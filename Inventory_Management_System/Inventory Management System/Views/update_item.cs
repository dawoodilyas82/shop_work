using System;
using System.Windows.Forms;
using Inventory_Management_System.Utilities;
using System.Data;

namespace Inventory_Management_System
{
    
    public partial class update_item : Form
    {
        public update_item()
        {
            InitializeComponent();
            mainDataGridView.DataSource = InventoryModel.getAllData();
            category.Items.AddRange(new object[] { "Allied", "GAC" });
        }

        private void filterCodeTextChanged(object sender, EventArgs e)
        {
            mainDataGridView.DataSource = InventoryModel.getDataByCode(filterCode.Text.ToString());
        }

        private void update_cancel_Click(object sender, EventArgs e)
        {
            GeneralUtils.showDashboardForm(this);
        }

        private void updateButtonClick(object sender, EventArgs e)
        {
            bool hasUpdatedData = InventoryModel.updateData(filterCode.Text.ToString(), des.Text.ToString(), price_pp.Value.ToString(), price_pc.Value.ToString(), quan.Text.ToString(), category.Text.ToString());
            if(!hasUpdatedData)
            {
                MessageBox.Show("Something went wrong. Item Not updated");
            }
            else
            {
                MessageBox.Show("Item Updated.");
                GeneralUtils.showDashboardForm(this);
            }
        }

        private void LoadDataButtonClick(object sender, EventArgs e)
        {
            if (InventoryModel.doesRecordExist(filterCode.Text.ToString()))
            {
                DataTable dataTable = InventoryModel.getDataByCode(filterCode.Text.ToString());
                DataRow dataRow = dataTable.Rows[0];

                string quantity = (string)dataRow[Constants.QUANTITY];
                string rate_pp = (string)dataRow[Constants.RATE_PER_PIECE];
                string rate_pc = (string)dataRow[Constants.RATE_PER_BOX];

                decimal output;
                if (decimal.TryParse(quantity, out output))
                {
                    quan.Value = output;
                }
                if (decimal.TryParse(rate_pc, out output))
                {
                    price_pc.Value = output;
                }
                if (decimal.TryParse(rate_pp, out output))
                {
                    price_pp.Value = output;
                }


                des.Text = (String) dataRow[Constants.DESCRIPTION];
                category.Text = (string)dataRow[Constants.CATEGORY];
            } 
        }
    }
}