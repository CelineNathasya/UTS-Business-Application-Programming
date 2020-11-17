namespace UTS_Business_Application_Programming
{
    partial class admin_page
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.menu_button = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sales_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboard_button
            // 
            this.dashboard_button.Location = new System.Drawing.Point(12, 59);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(112, 41);
            this.dashboard_button.TabIndex = 0;
            this.dashboard_button.Text = "Dashboard";
            this.dashboard_button.UseVisualStyleBackColor = true;
            this.dashboard_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu_button
            // 
            this.menu_button.Location = new System.Drawing.Point(12, 126);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(112, 41);
            this.menu_button.TabIndex = 1;
            this.menu_button.Text = "Menu";
            this.menu_button.UseVisualStyleBackColor = true;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(12, 193);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(112, 41);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(211, 63);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(390, 214);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // sales_label
            // 
            this.sales_label.AutoSize = true;
            this.sales_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sales_label.Location = new System.Drawing.Point(206, 23);
            this.sales_label.Name = "sales_label";
            this.sales_label.Size = new System.Drawing.Size(192, 25);
            this.sales_label.TabIndex = 4;
            this.sales_label.Text = "Today\'s Menu Sales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Sales:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sales_label);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.dashboard_button);
            this.Name = "admin_page";
            this.Text = "admin_page";
            this.Load += new System.EventHandler(this.admin_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label sales_label;
        private System.Windows.Forms.Label label1;
    }
}