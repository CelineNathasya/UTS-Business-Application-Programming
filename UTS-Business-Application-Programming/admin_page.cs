using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UTS_Business_Application_Programming
{
    public partial class admin_page : Form
    {
        public admin_page()
        {
            InitializeComponent();
            loadData();
            loadTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_page objadmpage = new admin_page();
            objadmpage.Show();

        }

        private void admin_page_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_setting objadms = new admin_setting();
            objadms.Show();
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_setting objmenusetting = new menu_setting();
            objmenusetting.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadTotal()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-43407LQ\SQLEXPRESS;Initial Catalog=kiyo;Integrated Security=True");
            conn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"Select SUM(order_total) as total FROM orders ";
            cmd.Parameters.Clear();
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.label2.Text = reader["total"].ToString();

                    }
                }
            }
        }

        private void loadData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-43407LQ\SQLEXPRESS;Initial Catalog=kiyo;Integrated Security=True");
            conn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"Select orders.menu_id, menus.menu_name, COUNT(orders.menu_id) as total From orders RIGHT JOIN menus on orders.menu_id = menus.menu_id GROUP BY orders.menu_id, menus.menu_name ";
            cmd.Parameters.Clear();
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dataGridView1.Rows.Add(new string[] {
                                          reader["menu_id"].ToString(),
                                          reader["menu_name"].ToString(),
                                          reader["total"].ToString(),

                                     });
                    }
                }
            }
        }

        private void sales_label_Click(object sender, EventArgs e)
        {

        }
    }
    
}
