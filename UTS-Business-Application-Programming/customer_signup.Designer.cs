namespace UTS_Business_Application_Programming
{
    partial class customer_signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cust_name = new System.Windows.Forms.TextBox();
            this.cust_pass = new System.Windows.Forms.TextBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // cust_name
            // 
            this.cust_name.Location = new System.Drawing.Point(349, 115);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(133, 22);
            this.cust_name.TabIndex = 2;
            // 
            // cust_pass
            // 
            this.cust_pass.Location = new System.Drawing.Point(349, 167);
            this.cust_pass.Name = "cust_pass";
            this.cust_pass.Size = new System.Drawing.Size(133, 22);
            this.cust_pass.TabIndex = 3;
            this.cust_pass.TextChanged += new System.EventHandler(this.cust_pass_TextChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(289, 238);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(131, 31);
            this.signup_btn.TabIndex = 4;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // customer_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.cust_pass);
            this.Controls.Add(this.cust_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "customer_signup";
            this.Text = "customer_signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cust_name;
        private System.Windows.Forms.TextBox cust_pass;
        private System.Windows.Forms.Button signup_btn;
    }
}