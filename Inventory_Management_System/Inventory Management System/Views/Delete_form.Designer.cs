﻿namespace Inventory_Management_System
{
    partial class Delete_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_form));
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.update_cancel = new System.Windows.Forms.Button();
            this.update_b1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.new_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDisplay
            // 
            this.mainDataGridView.BackgroundColor = System.Drawing.Color.Turquoise;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(292, 12);
            this.mainDataGridView.Name = "mainDisplay";
            this.mainDataGridView.Size = new System.Drawing.Size(663, 435);
            this.mainDataGridView.TabIndex = 9;
            // 
            // update_cancel
            // 
            this.update_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_cancel.BackgroundImage")));
            this.update_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_cancel.Location = new System.Drawing.Point(6, 339);
            this.update_cancel.Name = "update_cancel";
            this.update_cancel.Size = new System.Drawing.Size(137, 55);
            this.update_cancel.TabIndex = 8;
            this.update_cancel.Text = "Back";
            this.update_cancel.UseVisualStyleBackColor = true;
            this.update_cancel.Click += new System.EventHandler(this.deleteCancelClick);
            // 
            // update_b1
            // 
            this.update_b1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_b1.BackgroundImage")));
            this.update_b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_b1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_b1.Location = new System.Drawing.Point(149, 339);
            this.update_b1.Name = "update_b1";
            this.update_b1.Size = new System.Drawing.Size(137, 55);
            this.update_b1.TabIndex = 7;
            this.update_b1.Text = "Delete";
            this.update_b1.UseVisualStyleBackColor = true;
            this.update_b1.Click += new System.EventHandler(this.deleteButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.new_code);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item\'s Details";
            // 
            // new_code
            // 
            this.new_code.Location = new System.Drawing.Point(47, 56);
            this.new_code.Name = "new_code";
            this.new_code.Size = new System.Drawing.Size(209, 20);
            this.new_code.TabIndex = 12;
            this.new_code.TextChanged += new System.EventHandler(this.filterCodeTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Code:";
            // 
            // delete_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(958, 449);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.update_cancel);
            this.Controls.Add(this.update_b1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "delete_form";
            this.Text = "delete_form";
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Button update_cancel;
        private System.Windows.Forms.Button update_b1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox new_code;
        private System.Windows.Forms.Label label1;
    }
}