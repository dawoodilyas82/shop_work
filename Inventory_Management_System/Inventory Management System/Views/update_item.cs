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
            string currentQuantity = current_quan.Text.ToString();
            decimal addedQuantity = quantityToAdd.Value;
            decimal deletedQuantity = quantityToSub.Value;

            bool hasUpdatedData = false;
            decimal output;
            if (decimal.TryParse(currentQuantity, out output))
            {
                decimal newQuantity = output + addedQuantity - deletedQuantity;
                hasUpdatedData = InventoryModel.updateData(filterCode.Text.ToString(), des.Text.ToString(), price_pp.Value.ToString(), price_pc.Value.ToString(), newQuantity.ToString(), category.Text.ToString());
            }
            
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

                string quantity = dataRow[LabelConstants.QUANTITY].ToString();
                string rate_pp = dataRow[LabelConstants.RATE_PER_PIECE].ToString();
                string items_per_box = dataRow[LabelConstants.ITEMS_PER_BOX].ToString();

                decimal output;
                if (decimal.TryParse(items_per_box, out output))
                {
                    price_pc.Value = output;
                }
                if (decimal.TryParse(rate_pp, out output))
                {
                    price_pp.Value = output;
                }

                current_quan.Text = dataRow[LabelConstants.QUANTITY].ToString();
                des.Text = (string) dataRow[LabelConstants.DESCRIPTION];
                category.Text = (string)dataRow[LabelConstants.Company];
            } 
        }
    }
}