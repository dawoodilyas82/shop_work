using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Inventory_Management_System
{
    
    public partial class update_item : Form
    {
        public InventoryDataModel dataHandlingModel;
        public update_item()
        {
            InitializeComponent();
            dataHandlingModel = new InventoryDataModel();
            mainDataGridView.DataSource = dataHandlingModel.getAllData();
            category.Items.AddRange(new object[] { "Allied", "GAC" });
        }

        private void filterCodeTextChanged(object sender, EventArgs e)
        {
            mainDataGridView.DataSource = dataHandlingModel.getDataByCode(filterCode.Text.ToString());
        }

        private void update_cancel_Click(object sender, EventArgs e)
        {
            showDashboardForm();
        }

        private void updateButtonClick(object sender, EventArgs e)
        {
            bool hasUpdatedData = dataHandlingModel.updateData(filterCode.Text.ToString(), des.Text.ToString(), price_pp.Value.ToString(), price_pc.Value.ToString(), quan.Text.ToString(), category.Text.ToString());
            if(!hasUpdatedData)
            {
                MessageBox.Show("Something went wrong. Item Not updated");
            }
            else
            {
                MessageBox.Show("Item Updated.");
                showDashboardForm();
            }
        }
        private void showDashboardForm()
        {
            this.Hide();
            Dashboard_form dashboard = new Dashboard_form();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}