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
            this.menu_desc_txtbox = new System.Windows.Forms.TextBox();
            this.menu_name_txtbox = new System.Windows.Forms.TextBox();
            this.menu_id_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_price_txtbox = new System.Windows.Forms.TextBox();
            this.menu_pic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.add_new_btn = new System.Windows.Forms.Button();
            this.photo_upload_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kiyoDataSet = new UTS_Business_Application_Programming.kiyoDataSet();
            this.menusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menusTableAdapter = new UTS_Business_Application_Programming.kiyoDataSetTableAdapters.MenusTableAdapter();
            this.menusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menunameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menupriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menudescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource2)).BeginInit();
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
            // menu_desc_txtbox
            // 
            this.menu_desc_txtbox.Location = new System.Drawing.Point(295, 125);
            this.menu_desc_txtbox.Name = "menu_desc_txtbox";
            this.menu_desc_txtbox.Size = new System.Drawing.Size(224, 22);
            this.menu_desc_txtbox.TabIndex = 12;
            this.menu_desc_txtbox.TextChanged += new System.EventHandler(this.menu_desc_txtbox_TextChanged);
            // 
            // menu_name_txtbox
            // 
            this.menu_name_txtbox.Location = new System.Drawing.Point(295, 87);
            this.menu_name_txtbox.Name = "menu_name_txtbox";
            this.menu_name_txtbox.Size = new System.Drawing.Size(224, 22);
            this.menu_name_txtbox.TabIndex = 13;
            // 
            // menu_id_txtbox
            // 
            this.menu_id_txtbox.Location = new System.Drawing.Point(295, 50);
            this.menu_id_txtbox.Name = "menu_id_txtbox";
            this.menu_id_txtbox.Size = new System.Drawing.Size(100, 22);
            this.menu_id_txtbox.TabIndex = 14;
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
            // menu_price_txtbox
            // 
            this.menu_price_txtbox.Location = new System.Drawing.Point(295, 163);
            this.menu_price_txtbox.Name = "menu_price_txtbox";
            this.menu_price_txtbox.Size = new System.Drawing.Size(224, 22);
            this.menu_price_txtbox.TabIndex = 19;
            // 
            // menu_pic
            // 
            this.menu_pic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menu_pic.Location = new System.Drawing.Point(295, 202);
            this.menu_pic.Name = "menu_pic";
            this.menu_pic.Size = new System.Drawing.Size(65, 65);
            this.menu_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu_pic.TabIndex = 20;
            this.menu_pic.TabStop = false;
            this.menu_pic.Click += new System.EventHandler(this.menu_pic_Click);
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
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(581, 162);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 23;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(581, 124);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 24;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            // 
            // add_new_btn
            // 
            this.add_new_btn.Location = new System.Drawing.Point(581, 84);
            this.add_new_btn.Name = "add_new_btn";
            this.add_new_btn.Size = new System.Drawing.Size(75, 23);
            this.add_new_btn.TabIndex = 25;
            this.add_new_btn.Text = "Add";
            this.add_new_btn.UseVisualStyleBackColor = true;
            this.add_new_btn.Click += new System.EventHandler(this.add_new_btn_Click);
            // 
            // photo_upload_btn
            // 
            this.photo_upload_btn.Location = new System.Drawing.Point(376, 220);
            this.photo_upload_btn.Name = "photo_upload_btn";
            this.photo_upload_btn.Size = new System.Drawing.Size(75, 23);
            this.photo_upload_btn.TabIndex = 26;
            this.photo_upload_btn.Text = "Upload ";
            this.photo_upload_btn.UseVisualStyleBackColor = true;
            this.photo_upload_btn.Click += new System.EventHandler(this.photo_upload_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuidDataGridViewTextBoxColumn,
            this.menunameDataGridViewTextBoxColumn,
            this.menupriceDataGridViewTextBoxColumn,
            this.menudescriptionDataGridViewTextBoxColumn,
            this.menu_img});
            this.dataGridView1.DataSource = this.menusBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(189, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 130);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // menusBindingSource1
            // 
            this.menusBindingSource1.DataMember = "Menus";
            this.menusBindingSource1.DataSource = this.kiyoDataSet;
            // 
            // kiyoDataSet
            // 
            this.kiyoDataSet.DataSetName = "kiyoDataSet";
            this.kiyoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menusBindingSource
            // 
            this.menusBindingSource.DataMember = "Menus";
            this.menusBindingSource.DataSource = this.kiyoDataSet;
            // 
            // menusTableAdapter
            // 
            this.menusTableAdapter.ClearBeforeFill = true;
            // 
            // menusBindingSource2
            // 
            this.menusBindingSource2.DataMember = "Menus";
            this.menusBindingSource2.DataSource = this.kiyoDataSet;
            // 
            // menuidDataGridViewTextBoxColumn
            // 
            this.menuidDataGridViewTextBoxColumn.DataPropertyName = "menu_id";
            this.menuidDataGridViewTextBoxColumn.HeaderText = "menu_id";
            this.menuidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menuidDataGridViewTextBoxColumn.Name = "menuidDataGridViewTextBoxColumn";
            this.menuidDataGridViewTextBoxColumn.Width = 125;
            // 
            // menunameDataGridViewTextBoxColumn
            // 
            this.menunameDataGridViewTextBoxColumn.DataPropertyName = "menu_name";
            this.menunameDataGridViewTextBoxColumn.HeaderText = "menu_name";
            this.menunameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menunameDataGridViewTextBoxColumn.Name = "menunameDataGridViewTextBoxColumn";
            this.menunameDataGridViewTextBoxColumn.Width = 125;
            // 
            // menupriceDataGridViewTextBoxColumn
            // 
            this.menupriceDataGridViewTextBoxColumn.DataPropertyName = "menu_price";
            this.menupriceDataGridViewTextBoxColumn.HeaderText = "menu_price";
            this.menupriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menupriceDataGridViewTextBoxColumn.Name = "menupriceDataGridViewTextBoxColumn";
            this.menupriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // menudescriptionDataGridViewTextBoxColumn
            // 
            this.menudescriptionDataGridViewTextBoxColumn.DataPropertyName = "menu_description";
            this.menudescriptionDataGridViewTextBoxColumn.HeaderText = "menu_description";
            this.menudescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menudescriptionDataGridViewTextBoxColumn.Name = "menudescriptionDataGridViewTextBoxColumn";
            this.menudescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // menu_img
            // 
            this.menu_img.DataPropertyName = "menu_img";
            this.menu_img.HeaderText = "menu_img";
            this.menu_img.MinimumWidth = 6;
            this.menu_img.Name = "menu_img";
            this.menu_img.Width = 125;
            // 
            // menu_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.photo_upload_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_new_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menu_pic);
            this.Controls.Add(this.menu_price_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menu_name);
            this.Controls.Add(this.menu_id);
            this.Controls.Add(this.menu_desc_txtbox);
            this.Controls.Add(this.menu_name_txtbox);
            this.Controls.Add(this.menu_id_txtbox);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.dashboard_button);
            this.Name = "menu_setting";
            this.Text = "Menu Settings";
            this.Load += new System.EventHandler(this.menu_setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource2)).EndInit();
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
        private System.Windows.Forms.TextBox menu_desc_txtbox;
        private System.Windows.Forms.TextBox menu_name_txtbox;
        private System.Windows.Forms.TextBox menu_id_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox menu_price_txtbox;
        private System.Windows.Forms.PictureBox menu_pic;
        private System.Windows.Forms.Label label2;
        private kiyoDataSet kiyoDataSet;
        private System.Windows.Forms.BindingSource menusBindingSource;
        private kiyoDataSetTableAdapters.MenusTableAdapter menusTableAdapter;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button add_new_btn;
        private System.Windows.Forms.Button photo_upload_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn menuphotoDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource menusBindingSource1;
        private System.Windows.Forms.BindingSource menusBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menunameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menupriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menudescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_img;
    }
}