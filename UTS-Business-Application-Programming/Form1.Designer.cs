namespace UTS_Business_Application_Programming
{
    partial class Form1
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
            this.order_button = new System.Windows.Forms.Button();
            this.admin_login_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // order_button
            // 
            this.order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.order_button.Location = new System.Drawing.Point(319, 184);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(165, 52);
            this.order_button.TabIndex = 0;
            this.order_button.Text = "Order Here";
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // admin_login_link
            // 
            this.admin_login_link.AutoSize = true;
            this.admin_login_link.Location = new System.Drawing.Point(361, 263);
            this.admin_login_link.Name = "admin_login_link";
            this.admin_login_link.Size = new System.Drawing.Size(86, 17);
            this.admin_login_link.TabIndex = 1;
            this.admin_login_link.TabStop = true;
            this.admin_login_link.Text = "Admin Login";
            this.admin_login_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.admin_login_link_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_login_link);
            this.Controls.Add(this.order_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.LinkLabel admin_login_link;
    }
}

