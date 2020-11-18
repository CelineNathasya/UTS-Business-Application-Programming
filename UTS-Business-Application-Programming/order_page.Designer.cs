namespace UTS_Business_Application_Programming
{
    partial class order_page
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menunameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menupriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menudescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuimgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiyoDataSet = new UTS_Business_Application_Programming.kiyoDataSet();
            this.menusTableAdapter = new UTS_Business_Application_Programming.kiyoDataSetTableAdapters.MenusTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qty_txtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new UTS_Business_Application_Programming.kiyoDataSetTableAdapters.OrdersTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.table_txt = new System.Windows.Forms.TextBox();
            this.order_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
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
            this.menudescriptionDataGridViewTextBoxColumn,
            this.menuimgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 547);
            this.dataGridView1.TabIndex = 1;
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
            // menudescriptionDataGridViewTextBoxColumn
            // 
            this.menudescriptionDataGridViewTextBoxColumn.DataPropertyName = "menu_description";
            this.menudescriptionDataGridViewTextBoxColumn.HeaderText = "menu_description";
            this.menudescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menudescriptionDataGridViewTextBoxColumn.Name = "menudescriptionDataGridViewTextBoxColumn";
            this.menudescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.menudescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuimgDataGridViewTextBoxColumn
            // 
            this.menuimgDataGridViewTextBoxColumn.DataPropertyName = "menu_img";
            this.menuimgDataGridViewTextBoxColumn.HeaderText = "menu_img";
            this.menuimgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menuimgDataGridViewTextBoxColumn.Name = "menuimgDataGridViewTextBoxColumn";
            this.menuimgDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuimgDataGridViewTextBoxColumn.Width = 125;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(746, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Order";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menu Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qty:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(837, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // menusBindingSource1
            // 
            this.menusBindingSource1.DataMember = "Menus";
            this.menusBindingSource1.DataSource = this.kiyoDataSet;
            // 
            // qty_txtbox
            // 
            this.qty_txtbox.Location = new System.Drawing.Point(837, 146);
            this.qty_txtbox.Name = "qty_txtbox";
            this.qty_txtbox.Size = new System.Drawing.Size(42, 22);
            this.qty_txtbox.TabIndex = 6;
            this.qty_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qty_txtbox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(999, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(999, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Qty,
            this.Price,
            this.Subtotal});
            this.dataGridView2.Location = new System.Drawing.Point(745, 276);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(543, 213);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.kiyoDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(749, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total:";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.total_lbl.Location = new System.Drawing.Point(833, 510);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(18, 20);
            this.total_lbl.TabIndex = 11;
            this.total_lbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(750, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Table No:";
            // 
            // table_txt
            // 
            this.table_txt.Location = new System.Drawing.Point(831, 563);
            this.table_txt.Name = "table_txt";
            this.table_txt.Size = new System.Drawing.Size(48, 22);
            this.table_txt.TabIndex = 13;
            this.table_txt.TextChanged += new System.EventHandler(this.table_txt_TextChanged);
            // 
            // order_btn
            // 
            this.order_btn.Location = new System.Drawing.Point(1118, 536);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(125, 48);
            this.order_btn.TabIndex = 14;
            this.order_btn.Text = "Order";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "See Favourite";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // order_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 639);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.table_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qty_txtbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "order_page";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.order_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiyoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kiyoDataSet kiyoDataSet;
        private System.Windows.Forms.BindingSource menusBindingSource;
        private kiyoDataSetTableAdapters.MenusTableAdapter menusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menunameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menupriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menudescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuimgDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource menusBindingSource1;
        private System.Windows.Forms.TextBox qty_txtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private kiyoDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox table_txt;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button button3;
    }
}