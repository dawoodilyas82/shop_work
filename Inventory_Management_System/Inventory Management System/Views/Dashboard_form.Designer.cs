namespace Inventory_Management_System
{
    partial class Dashboard_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_form));
            this.dash_insert = new System.Windows.Forms.Button();
            this.dash_update = new System.Windows.Forms.Button();
            this.dash_delete = new System.Windows.Forms.Button();
            this.dash_back = new System.Windows.Forms.Button();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.companyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dash_insert
            // 
            this.dash_insert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dash_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dash_insert.BackgroundImage")));
            this.dash_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dash_insert.Location = new System.Drawing.Point(43, 26);
            this.dash_insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dash_insert.Name = "dash_insert";
            this.dash_insert.Size = new System.Drawing.Size(277, 73);
            this.dash_insert.TabIndex = 0;
            this.dash_insert.Text = "Insert New Filter";
            this.dash_insert.UseVisualStyleBackColor = false;
            this.dash_insert.Click += new System.EventHandler(this.dash_insert_Click);
            // 
            // dash_update
            // 
            this.dash_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dash_update.BackgroundImage")));
            this.dash_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dash_update.Location = new System.Drawing.Point(43, 128);
            this.dash_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dash_update.Name = "dash_update";
            this.dash_update.Size = new System.Drawing.Size(277, 73);
            this.dash_update.TabIndex = 1;
            this.dash_update.Text = "Update Filter";
            this.dash_update.UseVisualStyleBackColor = true;
            this.dash_update.Click += new System.EventHandler(this.dash_update_Click);
            // 
            // dash_delete
            // 
            this.dash_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dash_delete.BackgroundImage")));
            this.dash_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dash_delete.Location = new System.Drawing.Point(43, 233);
            this.dash_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dash_delete.Name = "dash_delete";
            this.dash_delete.Size = new System.Drawing.Size(277, 73);
            this.dash_delete.TabIndex = 2;
            this.dash_delete.Text = "Delete a Filter";
            this.dash_delete.UseVisualStyleBackColor = true;
            this.dash_delete.Click += new System.EventHandler(this.dash_delete_Click);
            // 
            // dash_back
            // 
            this.dash_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dash_back.BackgroundImage")));
            this.dash_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dash_back.Location = new System.Drawing.Point(136, 565);
            this.dash_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dash_back.Name = "dash_back";
            this.dash_back.Size = new System.Drawing.Size(100, 48);
            this.dash_back.TabIndex = 3;
            this.dash_back.Text = "Logout";
            this.dash_back.UseVisualStyleBackColor = true;
            this.dash_back.Click += new System.EventHandler(this.logoutButtonClick);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.AllowUserToResizeColumns = false;
            this.mainDataGridView.AllowUserToResizeRows = false;
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mainDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainDataGridView.BackgroundColor = System.Drawing.Color.Turquoise;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.mainDataGridView.Location = new System.Drawing.Point(363, 0);
            this.mainDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainDataGridView.MultiSelect = false;
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.Size = new System.Drawing.Size(955, 625);
            this.mainDataGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "By Code:";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(144, 44);
            this.codeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(185, 22);
            this.codeBox.TabIndex = 6;
            this.codeBox.TextChanged += new System.EventHandler(this.filterCodeTextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.companyBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.descBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.codeBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 320);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(339, 238);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Filters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "By Category:";
            // 
            // companyBox
            // 
            this.companyBox.Location = new System.Drawing.Point(144, 170);
            this.companyBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.companyBox.Name = "companyBox";
            this.companyBox.Size = new System.Drawing.Size(185, 22);
            this.companyBox.TabIndex = 10;
            this.companyBox.TextChanged += new System.EventHandler(this.categoryBoxTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "By Description:";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(144, 106);
            this.descBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(185, 22);
            this.descBox.TabIndex = 8;
            this.descBox.TextChanged += new System.EventHandler(this.descriptionBoxTextChanged);
            // 
            // Dashboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1320, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.dash_back);
            this.Controls.Add(this.dash_delete);
            this.Controls.Add(this.dash_update);
            this.Controls.Add(this.dash_insert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Dashboard_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dash_insert;
        private System.Windows.Forms.Button dash_update;
        private System.Windows.Forms.Button dash_delete;
        private System.Windows.Forms.Button dash_back;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox companyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descBox;
    }
}