namespace UTS_Business_Application_Programming
{
    partial class admin_login_page
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
            this.components = new System.ComponentModel.Container();
            this.admin_login_button = new System.Windows.Forms.Button();
            this.admin_back_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.admin_id = new System.Windows.Forms.TextBox();
            this.admin_pass = new System.Windows.Forms.TextBox();
            this.kiyoDataSet = new UTS_Business_Application_Programming.kiyoDataSet();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new UTS_Business_Application_Programming.kiyoDataSetTableAdapters.AdminsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_login_button
            // 
            this.admin_login_button.Location = new System.Drawing.Point(422, 272);
            this.admin_login_button.Name = "admin_login_button";
            this.admin_login_button.Size = new System.Drawing.Size(82, 37);
            this.admin_login_button.TabIndex = 0;
            this.admin_login_button.Text = "Log in";
            this.admin_login_button.UseVisualStyleBackColor = true;
            this.admin_login_button.Click += new System.EventHandler(this.admin_login_button_Click);
            // 
            // admin_back_login
            // 
            this.admin_back_login.Location = new System.Drawing.Point(212, 272);
            this.admin_back_login.Name = "admin_back_login";
            this.admin_back_login.Size = new System.Drawing.Size(154, 36);
            this.admin_back_login.TabIndex = 1;
            this.admin_back_login.Text = ">Back to Order Page";
            this.admin_back_login.UseVisualStyleBackColor = true;
            this.admin_back_login.Click += new System.EventHandler(this.admin_back_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // admin_id
            // 
            this.admin_id.Location = new System.Drawing.Point(341, 143);
            this.admin_id.Name = "admin_id";
            this.admin_id.Size = new System.Drawing.Size(129, 22);
            this.admin_id.TabIndex = 4;
            this.admin_id.TextChanged += new System.EventHandler(this.admin_id_TextChanged);
            this.admin_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.admin_id_KeyPress);
            // 
            // admin_pass
            // 
            this.admin_pass.Location = new System.Drawing.Point(341, 196);
            this.admin_pass.Name = "admin_pass";
            this.admin_pass.Size = new System.Drawing.Size(129, 22);
            this.admin_pass.TabIndex = 5;
            // 
            // kiyoDataSet
            // 
            this.kiyoDataSet.DataSetName = "kiyoDataSet";
            this.kiyoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.kiyoDataSet;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // admin_login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_pass);
            this.Controls.Add(this.admin_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_back_login);
            this.Controls.Add(this.admin_login_button);
            this.Name = "admin_login_page";
            this.Text = "admin_login_page";
            this.Load += new System.EventHandler(this.admin_login_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_login_button;
        private System.Windows.Forms.Button admin_back_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox admin_id;
        private System.Windows.Forms.TextBox admin_pass;
        private kiyoDataSet kiyoDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private kiyoDataSetTableAdapters.AdminsTableAdapter adminsTableAdapter;
    }
}