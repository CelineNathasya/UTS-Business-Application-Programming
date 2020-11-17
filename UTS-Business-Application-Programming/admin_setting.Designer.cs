namespace UTS_Business_Application_Programming
{
    partial class admin_setting
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
            this.Admin = new System.Windows.Forms.Button();
            this.menu_button = new System.Windows.Forms.Button();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_setting_back_login = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiyoDataSet = new UTS_Business_Application_Programming.kiyoDataSet();
            this.adminsTableAdapter = new UTS_Business_Application_Programming.kiyoDataSetTableAdapters.AdminsTableAdapter();
            this.admin_id_txtbox = new System.Windows.Forms.TextBox();
            this.admin_id = new System.Windows.Forms.Label();
            this.admin_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.admin_name_txtbox = new System.Windows.Forms.TextBox();
            this.admin_password_txtbox = new System.Windows.Forms.TextBox();
            this.add_new_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(12, 193);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(112, 41);
            this.Admin.TabIndex = 5;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // menu_button
            // 
            this.menu_button.Location = new System.Drawing.Point(12, 126);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(112, 41);
            this.menu_button.TabIndex = 4;
            this.menu_button.Text = "Menu";
            this.menu_button.UseVisualStyleBackColor = true;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // dashboard_button
            // 
            this.dashboard_button.Location = new System.Drawing.Point(12, 59);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(112, 41);
            this.dashboard_button.TabIndex = 3;
            this.dashboard_button.Text = "Dashboard";
            this.dashboard_button.UseVisualStyleBackColor = true;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // admin_setting_back_login
            // 
            this.admin_setting_back_login.Location = new System.Drawing.Point(480, 393);
            this.admin_setting_back_login.Name = "admin_setting_back_login";
            this.admin_setting_back_login.Size = new System.Drawing.Size(154, 36);
            this.admin_setting_back_login.TabIndex = 7;
            this.admin_setting_back_login.Text = ">Back to Order Page";
            this.admin_setting_back_login.UseVisualStyleBackColor = true;
            this.admin_setting_back_login.Click += new System.EventHandler(this.admin_setting_back_login_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(654, 393);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(119, 36);
            this.logout_button.TabIndex = 8;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminidDataGridViewTextBoxColumn,
            this.adminnameDataGridViewTextBoxColumn,
            this.adminpasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(165, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 114);
            this.dataGridView1.TabIndex = 9;
            // 
            // adminidDataGridViewTextBoxColumn
            // 
            this.adminidDataGridViewTextBoxColumn.DataPropertyName = "admin_id";
            this.adminidDataGridViewTextBoxColumn.HeaderText = "admin_id";
            this.adminidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminidDataGridViewTextBoxColumn.Name = "adminidDataGridViewTextBoxColumn";
            this.adminidDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminnameDataGridViewTextBoxColumn
            // 
            this.adminnameDataGridViewTextBoxColumn.DataPropertyName = "admin_name";
            this.adminnameDataGridViewTextBoxColumn.HeaderText = "admin_name";
            this.adminnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminnameDataGridViewTextBoxColumn.Name = "adminnameDataGridViewTextBoxColumn";
            this.adminnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminpasswordDataGridViewTextBoxColumn
            // 
            this.adminpasswordDataGridViewTextBoxColumn.DataPropertyName = "admin_password";
            this.adminpasswordDataGridViewTextBoxColumn.HeaderText = "admin_password";
            this.adminpasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminpasswordDataGridViewTextBoxColumn.Name = "adminpasswordDataGridViewTextBoxColumn";
            this.adminpasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.kiyoDataSet;
            // 
            // kiyoDataSet
            // 
            this.kiyoDataSet.DataSetName = "kiyoDataSet";
            this.kiyoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // admin_id_txtbox
            // 
            this.admin_id_txtbox.Location = new System.Drawing.Point(277, 80);
            this.admin_id_txtbox.Name = "admin_id_txtbox";
            this.admin_id_txtbox.Size = new System.Drawing.Size(100, 22);
            this.admin_id_txtbox.TabIndex = 10;
            this.admin_id_txtbox.TextChanged += new System.EventHandler(this.admin_id_txtbox_TextChanged);
            this.admin_id_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.admin_id_txtbox_KeyPress);
            // 
            // admin_id
            // 
            this.admin_id.AutoSize = true;
            this.admin_id.Location = new System.Drawing.Point(168, 83);
            this.admin_id.Name = "admin_id";
            this.admin_id.Size = new System.Drawing.Size(25, 17);
            this.admin_id.TabIndex = 11;
            this.admin_id.Text = "ID:";
            this.admin_id.Click += new System.EventHandler(this.admin_id_Click);
            // 
            // admin_name
            // 
            this.admin_name.AutoSize = true;
            this.admin_name.Location = new System.Drawing.Point(168, 119);
            this.admin_name.Name = "admin_name";
            this.admin_name.Size = new System.Drawing.Size(49, 17);
            this.admin_name.TabIndex = 11;
            this.admin_name.Text = "Name:";
            this.admin_name.Click += new System.EventHandler(this.admin_name_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // admin_name_txtbox
            // 
            this.admin_name_txtbox.Location = new System.Drawing.Point(277, 116);
            this.admin_name_txtbox.Name = "admin_name_txtbox";
            this.admin_name_txtbox.Size = new System.Drawing.Size(100, 22);
            this.admin_name_txtbox.TabIndex = 10;
            this.admin_name_txtbox.TextChanged += new System.EventHandler(this.admin_name_txtbox_TextChanged);
            // 
            // admin_password_txtbox
            // 
            this.admin_password_txtbox.Location = new System.Drawing.Point(277, 155);
            this.admin_password_txtbox.Name = "admin_password_txtbox";
            this.admin_password_txtbox.Size = new System.Drawing.Size(100, 22);
            this.admin_password_txtbox.TabIndex = 10;
            this.admin_password_txtbox.TextChanged += new System.EventHandler(this.admin_password_txtbox_TextChanged);
            // 
            // add_new_btn
            // 
            this.add_new_btn.Location = new System.Drawing.Point(505, 77);
            this.add_new_btn.Name = "add_new_btn";
            this.add_new_btn.Size = new System.Drawing.Size(75, 23);
            this.add_new_btn.TabIndex = 12;
            this.add_new_btn.Text = "Add";
            this.add_new_btn.UseVisualStyleBackColor = true;
            this.add_new_btn.Click += new System.EventHandler(this.add_new_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(505, 117);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 12;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(505, 155);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 12;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // admin_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_new_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.admin_name);
            this.Controls.Add(this.admin_id);
            this.Controls.Add(this.admin_password_txtbox);
            this.Controls.Add(this.admin_name_txtbox);
            this.Controls.Add(this.admin_id_txtbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.admin_setting_back_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.dashboard_button);
            this.Name = "admin_setting";
            this.Text = "admin_setting";
            this.Load += new System.EventHandler(this.admin_setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admin_setting_back_login;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kiyoDataSet kiyoDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private kiyoDataSetTableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox admin_id_txtbox;
        private System.Windows.Forms.Label admin_id;
        private System.Windows.Forms.Label admin_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox admin_name_txtbox;
        private System.Windows.Forms.TextBox admin_password_txtbox;
        private System.Windows.Forms.Button add_new_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}