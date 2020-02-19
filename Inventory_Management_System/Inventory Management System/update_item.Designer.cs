namespace Inventory_Management_System
{
    partial class update_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_item));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.des = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.price_pp = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.quan = new System.Windows.Forms.NumericUpDown();
            this.price_pc = new System.Windows.Forms.NumericUpDown();
            this.filterCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update_cancel = new System.Windows.Forms.Button();
            this.update_b1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price_pp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_pc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.des);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.category);
            this.groupBox1.Controls.Add(this.price_pp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.quan);
            this.groupBox1.Controls.Add(this.price_pc);
            this.groupBox1.Controls.Add(this.filterCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item\'s Details";
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(107, 273);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(209, 20);
            this.des.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Category:";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(107, 229);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(209, 21);
            this.category.TabIndex = 21;
            // 
            // price_pp
            // 
            this.price_pp.Location = new System.Drawing.Point(107, 91);
            this.price_pp.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.price_pp.Name = "price_pp";
            this.price_pp.Size = new System.Drawing.Size(209, 20);
            this.price_pp.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Unit Price:";
            // 
            // quan
            // 
            this.quan.Location = new System.Drawing.Point(107, 181);
            this.quan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(209, 20);
            this.quan.TabIndex = 18;
            // 
            // price_pc
            // 
            this.price_pc.Location = new System.Drawing.Point(107, 134);
            this.price_pc.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.price_pc.Name = "price_pc";
            this.price_pc.Size = new System.Drawing.Size(209, 20);
            this.price_pc.TabIndex = 17;
            // 
            // filterCode
            // 
            this.filterCode.Location = new System.Drawing.Point(107, 50);
            this.filterCode.Name = "filterCode";
            this.filterCode.Size = new System.Drawing.Size(209, 20);
            this.filterCode.TabIndex = 16;
            this.filterCode.TextChanged += new System.EventHandler(this.filterCodeTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Box Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Code:";
            // 
            // update_cancel
            // 
            this.update_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_cancel.BackgroundImage")));
            this.update_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_cancel.Location = new System.Drawing.Point(56, 411);
            this.update_cancel.Name = "update_cancel";
            this.update_cancel.Size = new System.Drawing.Size(137, 55);
            this.update_cancel.TabIndex = 4;
            this.update_cancel.Text = "Back";
            this.update_cancel.UseVisualStyleBackColor = true;
            this.update_cancel.Click += new System.EventHandler(this.update_cancel_Click);
            // 
            // update_b1
            // 
            this.update_b1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_b1.BackgroundImage")));
            this.update_b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_b1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_b1.Location = new System.Drawing.Point(199, 411);
            this.update_b1.Name = "update_b1";
            this.update_b1.Size = new System.Drawing.Size(137, 55);
            this.update_b1.TabIndex = 3;
            this.update_b1.Text = "Update";
            this.update_b1.UseVisualStyleBackColor = true;
            this.update_b1.Click += new System.EventHandler(this.update_b1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 488);
            this.dataGridView1.TabIndex = 5;
            // 
            // update_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(991, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.update_cancel);
            this.Controls.Add(this.update_b1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "update_item";
            this.Text = "Update Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price_pp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_pc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button update_cancel;
        private System.Windows.Forms.Button update_b1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox des;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.NumericUpDown price_pp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown quan;
        private System.Windows.Forms.NumericUpDown price_pc;
        private System.Windows.Forms.TextBox filterCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}