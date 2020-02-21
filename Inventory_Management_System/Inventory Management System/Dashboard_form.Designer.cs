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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.catBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dash_insert
            // 
            this.dash_insert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dash_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dash_insert.BackgroundImage")));
            this.dash_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash_insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dash_insert.Location = new System.Drawing.Point(32, 21);
            this.dash_insert.Name = "dash_insert";
            this.dash_insert.Size = new System.Drawing.Size(208, 59);
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
            this.dash_update.Location = new System.Drawing.Point(32, 104);
            this.dash_update.Name = "dash_update";
            this.dash_update.Size = new System.Drawing.Size(208, 59);
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
            this.dash_delete.Location = new System.Drawing.Point(32, 189);
            this.dash_delete.Name = "dash_delete";
            this.dash_delete.Size = new System.Drawing.Size(208, 59);
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
            this.dash_back.Location = new System.Drawing.Point(76, 459);
            this.dash_back.Name = "dash_back";
            this.dash_back.Size = new System.Drawing.Size(75, 39);
            this.dash_back.TabIndex = 3;
            this.dash_back.Text = "Logout";
            this.dash_back.UseVisualStyleBackColor = true;
            this.dash_back.Click += new System.EventHandler(this.dash_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(272, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 508);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "By Code:";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(108, 36);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(140, 20);
            this.codeBox.TabIndex = 6;
            this.codeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.catBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.descBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.codeBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 193);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Filters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "By Category:";
            // 
            // catBox
            // 
            this.catBox.Location = new System.Drawing.Point(108, 138);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(140, 20);
            this.catBox.TabIndex = 10;
            this.catBox.TextChanged += new System.EventHandler(this.catBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "By Description:";
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(108, 86);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(140, 20);
            this.descBox.TabIndex = 8;
            this.descBox.TextChanged += new System.EventHandler(this.descBox_TextChanged);
            // 
            // controller_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(990, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dash_back);
            this.Controls.Add(this.dash_delete);
            this.Controls.Add(this.dash_update);
            this.Controls.Add(this.dash_insert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "controller_form";
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dash_insert;
        private System.Windows.Forms.Button dash_update;
        private System.Windows.Forms.Button dash_delete;
        private System.Windows.Forms.Button dash_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox catBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descBox;
    }
}