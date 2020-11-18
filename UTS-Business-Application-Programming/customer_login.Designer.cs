namespace UTS_Business_Application_Programming
{
    partial class customer_login
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
            this.label2 = new System.Windows.Forms.Label();
            this.tablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiyoDataSet = new UTS_Business_Application_Programming.kiyoDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.continue_btn = new System.Windows.Forms.Button();
            this.new_acc = new System.Windows.Forms.LinkLabel();
            this.tablesTableAdapter = new UTS_Business_Application_Programming.kiyoDataSetTableAdapters.TablesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // tablesBindingSource
            // 
            this.tablesBindingSource.DataMember = "Tables";
            this.tablesBindingSource.DataSource = this.kiyoDataSet;
            // 
            // kiyoDataSet
            // 
            this.kiyoDataSet.DataSetName = "kiyoDataSet";
            this.kiyoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(333, 167);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(153, 22);
            this.name_txtbox.TabIndex = 4;
            this.name_txtbox.TextChanged += new System.EventHandler(this.name_txtbox_TextChanged);
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(333, 214);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(153, 22);
            this.password_txtbox.TabIndex = 5;
            // 
            // continue_btn
            // 
            this.continue_btn.Location = new System.Drawing.Point(360, 272);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(94, 29);
            this.continue_btn.TabIndex = 6;
            this.continue_btn.Text = "Continue";
            this.continue_btn.UseVisualStyleBackColor = true;
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // new_acc
            // 
            this.new_acc.AutoSize = true;
            this.new_acc.Location = new System.Drawing.Point(340, 318);
            this.new_acc.Name = "new_acc";
            this.new_acc.Size = new System.Drawing.Size(136, 17);
            this.new_acc.TabIndex = 7;
            this.new_acc.TabStop = true;
            this.new_acc.Text = "Create New Account";
            this.new_acc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.new_acc_LinkClicked);
            // 
            // tablesTableAdapter
            // 
            this.tablesTableAdapter.ClearBeforeFill = true;
            // 
            // customer_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.new_acc);
            this.Controls.Add(this.continue_btn);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "customer_login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.customer_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Button continue_btn;
        private System.Windows.Forms.LinkLabel new_acc;
        private kiyoDataSet kiyoDataSet;
        private System.Windows.Forms.BindingSource tablesBindingSource;
        private kiyoDataSetTableAdapters.TablesTableAdapter tablesTableAdapter;
    }
}