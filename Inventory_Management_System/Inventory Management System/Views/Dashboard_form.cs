﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
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
            mainDataGridView.DataSource = InventoryModel.getDataByCode(codeBox.Text.ToString());
        }

        private void descriptionBoxTextChanged(object sender, EventArgs e)
        {
            mainDataGridView.DataSource = InventoryModel.getDataByDesc(descBox.Text.ToString());
        }

        private void categoryBoxTextChanged(object sender, EventArgs e)
        {
            mainDataGridView.DataSource = InventoryModel.getDataByCategory(catBox.Text.ToString());
        }
    }
}
