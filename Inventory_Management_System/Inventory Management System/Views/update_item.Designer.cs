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
            this.current_quan = new System.Windows.Forms.Label();
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
            this.items_in_box = new System.Windows.Forms.NumericUpDown();
            this.filterCode = new System.Windows.Forms.TextBox();
            this.currentQuantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.update_cancel = new System.Windows.Forms.Button();
            this.update_b1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_pp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items_in_box)).BeginInit();
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
            this.groupBox1.Controls.Add(this.items_in_box);
            this.groupBox1.Controls.Add(this.filterCode);
            this.groupBox1.Controls.Add(this.currentQuantity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(472, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item\'s Details";
            // 
            // current_quan
            // 
            this.current_quan.BackColor = System.Drawing.Color.White;
            this.current_quan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.current_quan.Location = new System.Drawing.Point(160, 214);
            this.current_quan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.current_quan.Name = "current_quan";
            this.current_quan.Size = new System.Drawing.Size(261, 27);
            this.current_quan.TabIndex = 29;
            this.current_quan.Text = "0";
            this.current_quan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantityToAdd
            // 
            this.quantityToAdd.Location = new System.Drawing.Point(160, 271);
            this.quantityToAdd.Margin = new System.Windows.Forms.Padding(4);
            this.quantityToAdd.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.quantityToAdd.Name = "quantityToAdd";
            this.quantityToAdd.Size = new System.Drawing.Size(261, 22);
            this.quantityToAdd.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Added Quantity:";
            // 
            // quantityToSub
            // 
            this.quantityToSub.Location = new System.Drawing.Point(188, 322);
            this.quantityToSub.Margin = new System.Windows.Forms.Padding(4);
            this.quantityToSub.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.quantityToSub.Name = "quantityToSub";
            this.quantityToSub.Size = new System.Drawing.Size(233, 22);
            this.quantityToSub.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Subtracted Quantity:";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Inventory_Management_System.Properties.Resources.download;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(431, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 25);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LoadDataButtonClick);
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(133, 428);
            this.des.Margin = new System.Windows.Forms.Padding(4);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(287, 22);
            this.des.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Category:";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(123, 374);
            this.category.Margin = new System.Windows.Forms.Padding(4);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(297, 24);
            this.category.TabIndex = 21;
            // 
            // price_pp
            // 
            this.price_pp.Location = new System.Drawing.Point(123, 112);
            this.price_pp.Margin = new System.Windows.Forms.Padding(4);
            this.price_pp.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.price_pp.Name = "price_pp";
            this.price_pp.Size = new System.Drawing.Size(299, 22);
            this.price_pp.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Unit Price:";
            // 
            // items_in_box
            // 
            this.items_in_box.Location = new System.Drawing.Point(133, 165);
            this.items_in_box.Margin = new System.Windows.Forms.Padding(4);
            this.items_in_box.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.items_in_box.Name = "items_in_box";
            this.items_in_box.Size = new System.Drawing.Size(289, 22);
            this.items_in_box.TabIndex = 17;
            // 
            // filterCode
            // 
            this.filterCode.Location = new System.Drawing.Point(123, 62);
            this.filterCode.Margin = new System.Windows.Forms.Padding(4);
            this.filterCode.Name = "filterCode";
            this.filterCode.Size = new System.Drawing.Size(297, 22);
            this.filterCode.TabIndex = 16;
            this.filterCode.TextChanged += new System.EventHandler(this.filterCodeTextChanged);
            // 
            // currentQuantity
            // 
            this.currentQuantity.AutoSize = true;
            this.currentQuantity.Location = new System.Drawing.Point(41, 219);
            this.currentQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentQuantity.Name = "currentQuantity";
            this.currentQuantity.Size = new System.Drawing.Size(120, 17);
            this.currentQuantity.TabIndex = 15;
            this.currentQuantity.Text = "Current Quantity: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Items in Box :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 428);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Code:";
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.AllowUserToResizeColumns = false;
            this.mainDataGridView.AllowUserToResizeRows = false;
            this.mainDataGridView.BackgroundColor = System.Drawing.Color.Turquoise;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(511, 15);
            this.mainDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.mainDataGridView.MultiSelect = false;
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mainDataGridView.Size = new System.Drawing.Size(882, 610);
            this.mainDataGridView.TabIndex = 5;
            // 
            // update_cancel
            // 
            this.update_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_cancel.BackgroundImage")));
            this.update_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_cancel.Location = new System.Drawing.Point(77, 537);
            this.update_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.update_cancel.Name = "update_cancel";
            this.update_cancel.Size = new System.Drawing.Size(183, 68);
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
            this.update_b1.Location = new System.Drawing.Point(268, 537);
            this.update_b1.Margin = new System.Windows.Forms.Padding(4);
            this.update_b1.Name = "update_b1";
            this.update_b1.Size = new System.Drawing.Size(183, 68);
            this.update_b1.TabIndex = 3;
            this.update_b1.Text = "Update";
            this.update_b1.UseVisualStyleBackColor = true;
            this.update_b1.Click += new System.EventHandler(this.updateButtonClick);
            // 
            // update_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1406, 638);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.update_cancel);
            this.Controls.Add(this.update_b1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "update_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_pp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items_in_box)).EndInit();
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
        private System.Windows.Forms.NumericUpDown items_in_box;
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