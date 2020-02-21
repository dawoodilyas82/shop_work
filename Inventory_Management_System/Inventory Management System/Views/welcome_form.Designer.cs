namespace Inventory_Management_System
{
    partial class welcome_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wel_pass = new System.Windows.Forms.TextBox();
            this.wel_usr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wel_sign = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wel_pass);
            this.groupBox1.Controls.Add(this.wel_usr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // wel_pass
            // 
            this.wel_pass.Location = new System.Drawing.Point(104, 96);
            this.wel_pass.Name = "wel_pass";
            this.wel_pass.PasswordChar = '*';
            this.wel_pass.Size = new System.Drawing.Size(186, 20);
            this.wel_pass.TabIndex = 3;
            // 
            // wel_usr
            // 
            this.wel_usr.Location = new System.Drawing.Point(104, 48);
            this.wel_usr.Name = "wel_usr";
            this.wel_usr.Size = new System.Drawing.Size(186, 20);
            this.wel_usr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // wel_sign
            // 
            this.wel_sign.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.wel_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wel_sign.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.wel_sign.Location = new System.Drawing.Point(423, 210);
            this.wel_sign.Name = "wel_sign";
            this.wel_sign.Size = new System.Drawing.Size(173, 40);
            this.wel_sign.TabIndex = 1;
            this.wel_sign.Text = "Sign In";
            this.wel_sign.UseVisualStyleBackColor = false;
            this.wel_sign.Click += new System.EventHandler(this.loginButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Inventory_Management_System.Properties.Resources.login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(423, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 122);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // welcome_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(655, 340);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wel_sign);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "welcome_form";
            this.Text = "WELCOME TO INVENTORY MANAGEMENT SYSTEM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wel_pass;
        private System.Windows.Forms.TextBox wel_usr;
        private System.Windows.Forms.Button wel_sign;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}