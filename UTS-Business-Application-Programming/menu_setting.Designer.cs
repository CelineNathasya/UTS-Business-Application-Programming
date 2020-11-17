namespace UTS_Business_Application_Programming
{
    partial class menu_setting
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
            this.label4 = new System.Windows.Forms.Label();
            this.menu_name = new System.Windows.Forms.Label();
            this.menu_id = new System.Windows.Forms.Label();
            this.admin_password_txtbox = new System.Windows.Forms.TextBox();
            this.admin_name_txtbox = new System.Windows.Forms.TextBox();
            this.admin_id_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menu_pic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menunameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menupriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menudescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuphotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.menusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiyoDataSet = new UTS_Business_Application_Programming.kiyoDataSet();
            this.menusTableAdapter = new UTS_Business_Application_Programming.kiyoDataSetTableAdapters.MenusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(12, 189);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(112, 41);
            this.Admin.TabIndex = 8;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // menu_button
            // 
            this.menu_button.Location = new System.Drawing.Point(12, 122);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(112, 41);
            this.menu_button.TabIndex = 7;
            this.menu_button.Text = "Menu";
            this.menu_button.UseVisualStyleBackColor = true;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // dashboard_button
            // 
            this.dashboard_button.Location = new System.Drawing.Point(12, 55);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(112, 41);
            this.dashboard_button.TabIndex = 6;
            this.dashboard_button.Text = "Dashboard";
            this.dashboard_button.UseVisualStyleBackColor = true;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description:";
            // 
            // menu_name
            // 
            this.menu_name.AutoSize = true;
            this.menu_name.Location = new System.Drawing.Point(186, 90);
            this.menu_name.Name = "menu_name";
            this.menu_name.Size = new System.Drawing.Size(49, 17);
            this.menu_name.TabIndex = 16;
            this.menu_name.Text = "Name:";
            // 
            // menu_id
            // 
            this.menu_id.AutoSize = true;
            this.menu_id.Location = new System.Drawing.Point(186, 53);
            this.menu_id.Name = "menu_id";
            this.menu_id.Size = new System.Drawing.Size(64, 17);
            this.menu_id.TabIndex = 17;
            this.menu_id.Text = "Menu ID:";
            // 
            // admin_password_txtbox
            // 
            this.admin_password_txtbox.Location = new System.Drawing.Point(295, 125);
            this.admin_password_txtbox.Name = "admin_password_txtbox";
            this.admin_password_txtbox.Size = new System.Drawing.Size(224, 22);
            this.admin_password_txtbox.TabIndex = 12;
            // 
            // admin_name_txtbox
            // 
            this.admin_name_txtbox.Location = new System.Drawing.Point(295, 87);
            this.admin_name_txtbox.Name = "admin_name_txtbox";
            this.admin_name_txtbox.Size = new System.Drawing.Size(224, 22);
            this.admin_name_txtbox.TabIndex = 13;
            // 
            // admin_id_txtbox
            // 
            this.admin_id_txtbox.Location = new System.Drawing.Point(295, 50);
            this.admin_id_txtbox.Name = "admin_id_txtbox";
            this.admin_id_txtbox.Size = new System.Drawing.Size(100, 22);
            this.admin_id_txtbox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Price:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 22);
            this.textBox1.TabIndex = 19;
            // 
            // menu_pic
            // 
            this.menu_pic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menu_pic.Location = new System.Drawing.Point(295, 202);
            this.menu_pic.Name = "menu_pic";
            this.menu_pic.Size = new System.Drawing.Size(65, 65);
            this.menu_pic.TabIndex = 20;
            this.menu_pic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Photo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuidDataGridViewTextBoxColumn,
            this.menunameDataGridViewTextBoxColumn,
            this.menupriceDataGridViewTextBoxColumn,
            this.menuqtyDataGridViewTextBoxColumn,
            this.menudescriptionDataGridViewTextBoxColumn,
            this.menuphotoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.menusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(189, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(594, 154);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuidDataGridViewTextBoxColumn
            // 
            this.menuidDataGridViewTextBoxColumn.DataPropertyName = "menu_id";
            this.menuidDataGridViewTextBoxColumn.HeaderText = "menu_id";
            this.menuidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menuidDataGridViewTextBoxColumn.Name = "menuidDataGridViewTextBoxColumn";
            this.menuidDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuidDataGridViewTextBoxColumn.Width = 125;
            // 
            // menunameDataGridViewTextBoxColumn
            // 
            this.menunameDataGridViewTextBoxColumn.DataPropertyName = "menu_name";
            this.menunameDataGridViewTextBoxColumn.HeaderText = "menu_name";
            this.menunameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menunameDataGridViewTextBoxColumn.Name = "menunameDataGridViewTextBoxColumn";
            this.menunameDataGridViewTextBoxColumn.ReadOnly = true;
            this.menunameDataGridViewTextBoxColumn.Width = 125;
            // 
            // menupriceDataGridViewTextBoxColumn
            // 
            this.menupriceDataGridViewTextBoxColumn.DataPropertyName = "menu_price";
            this.menupriceDataGridViewTextBoxColumn.HeaderText = "menu_price";
            this.menupriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menupriceDataGridViewTextBoxColumn.Name = "menupriceDataGridViewTextBoxColumn";
            this.menupriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.menupriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuqtyDataGridViewTextBoxColumn
            // 
            this.menuqtyDataGridViewTextBoxColumn.DataPropertyName = "menu_qty";
            this.menuqtyDataGridViewTextBoxColumn.HeaderText = "menu_qty";
            this.menuqtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menuqtyDataGridViewTextBoxColumn.Name = "menuqtyDataGridViewTextBoxColumn";
            this.menuqtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuqtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // menudescriptionDataGridViewTextBoxColumn
            // 
            this.menudescriptionDataGridViewTextBoxColumn.DataPropertyName = "menu_description";
            this.menudescriptionDataGridViewTextBoxColumn.HeaderText = "menu_description";
            this.menudescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menudescriptionDataGridViewTextBoxColumn.Name = "menudescriptionDataGridViewTextBoxColumn";
            this.menudescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.menudescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuphotoDataGridViewImageColumn
            // 
            this.menuphotoDataGridViewImageColumn.DataPropertyName = "menu_photo";
            this.menuphotoDataGridViewImageColumn.HeaderText = "menu_photo";
            this.menuphotoDataGridViewImageColumn.MinimumWidth = 6;
            this.menuphotoDataGridViewImageColumn.Name = "menuphotoDataGridViewImageColumn";
            this.menuphotoDataGridViewImageColumn.ReadOnly = true;
            this.menuphotoDataGridViewImageColumn.Width = 125;
            // 
            // menusBindingSource
            // 
            this.menusBindingSource.DataMember = "Menus";
            this.menusBindingSource.DataSource = this.kiyoDataSet;
            // 
            // kiyoDataSet
            // 
            this.kiyoDataSet.DataSetName = "kiyoDataSet";
            this.kiyoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menusTableAdapter
            // 
            this.menusTableAdapter.ClearBeforeFill = true;
            // 
            // menu_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menu_pic);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menu_name);
            this.Controls.Add(this.menu_id);
            this.Controls.Add(this.admin_password_txtbox);
            this.Controls.Add(this.admin_name_txtbox);
            this.Controls.Add(this.admin_id_txtbox);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.dashboard_button);
            this.Name = "menu_setting";
            this.Text = "m,m ";
            this.Load += new System.EventHandler(this.menu_setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label menu_name;
        private System.Windows.Forms.Label menu_id;
        private System.Windows.Forms.TextBox admin_password_txtbox;
        private System.Windows.Forms.TextBox admin_name_txtbox;
        private System.Windows.Forms.TextBox admin_id_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox menu_pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kiyoDataSet kiyoDataSet;
        private System.Windows.Forms.BindingSource menusBindingSource;
        private kiyoDataSetTableAdapters.MenusTableAdapter menusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menunameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menupriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menudescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn menuphotoDataGridViewImageColumn;
    }
}