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
            this.quantityToAdd = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.quantityToSub = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.des = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.price_pp = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.price_pc = new System.Windows.Forms.NumericUpDown();
            this.filterCode = new System.Windows.Forms.TextBox();
            this.currentQuantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.update_cancel = new System.Windows.Forms.Button();
            this.update_b1 = new System.Windows.Forms.Button();
            this.current_quan = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_pp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_pc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.current_quan);
            this.groupBox1.Controls.Add(this.quantityToAdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.quantityToSub);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.des);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.category);
            this.groupBox1.Controls.Add(this.price_pp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.price_pc);
            this.groupBox1.Controls.Add(this.filterCode);
            this.groupBox1.Controls.Add(this.currentQuantity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item\'s Details";
            // 
            // quantityToAdd
            // 
            this.quantityToAdd.Location = new System.Drawing.Point(120, 220);
            this.quantityToAdd.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.quantityToAdd.Name = "quantityToAdd";
            this.quantityToAdd.Size = new System.Drawing.Size(196, 20);
            this.quantityToAdd.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Added Quantity:";
            // 
            // quantityToSub
            // 
            this.quantityToSub.Location = new System.Drawing.Point(141, 262);
            this.quantityToSub.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.quantityToSub.Name = "quantityToSub";
            this.quantityToSub.Size = new System.Drawing.Size(175, 20);
            this.quantityToSub.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Subtracted Quantity:";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Inventory_Management_System.Properties.Resources.download;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(323, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LoadDataButtonClick);
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(100, 348);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(216, 20);
            this.des.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Category:";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(92, 304);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(224, 21);
            this.category.TabIndex = 21;
            // 
            // price_pp
            // 
            this.price_pp.Location = new System.Drawing.Point(92, 91);
            this.price_pp.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.price_pp.Name = "price_pp";
            this.price_pp.Size = new System.Drawing.Size(224, 20);
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
            // price_pc
            // 
            this.price_pc.Location = new System.Drawing.Point(92, 134);
            this.price_pc.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.price_pc.Name = "price_pc";
            this.price_pc.Size = new System.Drawing.Size(224, 20);
            this.price_pc.TabIndex = 17;
            // 
            // filterCode
            // 
            this.filterCode.Location = new System.Drawing.Point(92, 50);
            this.filterCode.Name = "filterCode";
            this.filterCode.Size = new System.Drawing.Size(224, 20);
            this.filterCode.TabIndex = 16;
            this.filterCode.TextChanged += new System.EventHandler(this.filterCodeTextChanged);
            // 
            // currentQuantity
            // 
            this.currentQuantity.AutoSize = true;
            this.currentQuantity.Location = new System.Drawing.Point(31, 183);
            this.currentQuantity.Name = "currentQuantity";
            this.currentQuantity.Size = new System.Drawing.Size(89, 13);
            this.currentQuantity.TabIndex = 15;
            this.currentQuantity.Text = "Current Quantity: ";
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
            this.label2.Location = new System.Drawing.Point(31, 348);
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
            // mainDataGridView
            // 
            this.mainDataGridView.BackgroundColor = System.Drawing.Color.Turquoise;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(383, 12);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.Size = new System.Drawing.Size(596, 488);
            this.mainDataGridView.TabIndex = 5;
            // 
            // update_cancel
            // 
            this.update_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_cancel.BackgroundImage")));
            this.update_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_cancel.Location = new System.Drawing.Point(58, 436);
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
            this.update_b1.Location = new System.Drawing.Point(201, 436);
            this.update_b1.Name = "update_b1";
            this.update_b1.Size = new System.Drawing.Size(137, 55);
            this.update_b1.TabIndex = 3;
            this.update_b1.Text = "Update";
            this.update_b1.UseVisualStyleBackColor = true;
            this.update_b1.Click += new System.EventHandler(this.updateButtonClick);
            // 
            // current_quan
            // 
            this.current_quan.BackColor = System.Drawing.Color.White;
            this.current_quan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_quan.Location = new System.Drawing.Point(120, 174);
            this.current_quan.Name = "current_quan";
            this.current_quan.Size = new System.Drawing.Size(196, 22);
            this.current_quan.TabIndex = 29;
            this.current_quan.Text = "0";
            this.current_quan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // update_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(991, 512);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.update_cancel);
            this.Controls.Add(this.update_b1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "update_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_pp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_pc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button update_cancel;
        private System.Windows.Forms.Button update_b1;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.TextBox des;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.NumericUpDown price_pp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown price_pc;
        private System.Windows.Forms.TextBox filterCode;
        private System.Windows.Forms.Label currentQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown quantityToAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown quantityToSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label current_quan;
    }
}