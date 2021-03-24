namespace Inventory_Management_System
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
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.AllowUserToResizeColumns = false;
            this.mainDataGridView.AllowUserToResizeRows = false;
            this.mainDataGridView.BackgroundColor = System.Drawing.Color.Turquoise;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(389, 15);
            this.mainDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainDataGridView.MultiSelect = false;
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mainDataGridView.Size = new System.Drawing.Size(884, 535);
            this.mainDataGridView.TabIndex = 9;
            // 
            // update_cancel
            // 
            this.update_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_cancel.BackgroundImage")));
            this.update_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_cancel.Location = new System.Drawing.Point(8, 417);
            this.update_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_cancel.Name = "update_cancel";
            this.update_cancel.Size = new System.Drawing.Size(183, 68);
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
            this.update_b1.Location = new System.Drawing.Point(199, 417);
            this.update_b1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update_b1.Name = "update_b1";
            this.update_b1.Size = new System.Drawing.Size(183, 68);
            this.update_b1.TabIndex = 7;
            this.update_b1.Text = "Delete";
            this.update_b1.UseVisualStyleBackColor = true;
            this.update_b1.Click += new System.EventHandler(this.deleteButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.new_code);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(373, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item\'s Details";
            // 
            // new_code
            // 
            this.new_code.Location = new System.Drawing.Point(63, 69);
            this.new_code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new_code.Name = "new_code";
            this.new_code.Size = new System.Drawing.Size(277, 22);
            this.new_code.TabIndex = 12;
            this.new_code.TextChanged += new System.EventHandler(this.filterCodeTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Code:";
            // 
            // Delete_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1277, 553);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.update_cancel);
            this.Controls.Add(this.update_b1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Delete_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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