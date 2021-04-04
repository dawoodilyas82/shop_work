namespace Inventory_Management_System
{
    partial class New_item_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_item_form));
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
            this.button1 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price_pp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_pc)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(33, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(432, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item\'s Details";
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(121, 335);
            this.des.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(277, 22);
            this.des.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category:";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(121, 281);
            this.category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(277, 24);
            this.category.TabIndex = 9;
            // 
            // price_pp
            // 
            this.price_pp.Location = new System.Drawing.Point(121, 111);
            this.price_pp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.price_pp.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.price_pp.Name = "price_pp";
            this.price_pp.Size = new System.Drawing.Size(279, 22);
            this.price_pp.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Unit Price:";
            // 
            // quan
            // 
            this.quan.Location = new System.Drawing.Point(121, 222);
            this.quan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(279, 22);
            this.quan.TabIndex = 6;
            // 
            // price_pc
            // 
            this.price_pc.Location = new System.Drawing.Point(121, 164);
            this.price_pc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.price_pc.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.price_pc.Name = "price_pc";
            this.price_pc.Size = new System.Drawing.Size(279, 22);
            this.price_pc.TabIndex = 5;
            // 
            // filterCode
            // 
            this.filterCode.Location = new System.Drawing.Point(121, 60);
            this.filterCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterCode.Name = "filterCode";
            this.filterCode.Size = new System.Drawing.Size(277, 22);
            this.filterCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Items Per Box:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(283, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.insertButtonClick);
            // 
            // Cancel
            // 
            this.Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel.BackgroundImage")));
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cancel.Location = new System.Drawing.Point(33, 539);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(183, 68);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Back";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // New_item_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(501, 638);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "New_item_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price_pp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_pc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown quan;
        private System.Windows.Forms.NumericUpDown price_pc;
        private System.Windows.Forms.TextBox filterCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown price_pp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox des;
    }
}