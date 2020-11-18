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
    public partial class favourite_menu : Form
    {
        public favourite_menu()
        {
            InitializeComponent();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-43407LQ\SQLEXPRESS;Initial Catalog=kiyo;Integrated Security=True");
            conn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"Select menus.menu_name, COUNT(orders.menu_id) as total From orders RIGHT JOIN menus on orders.menu_id = menus.menu_id GROUP BY orders.menu_id, menus.menu_name   ";
            cmd.Parameters.Clear();
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.dataGridView1.Rows.Add(new string[] {
                                          reader["menu_name"].ToString(),
                                          reader["total"].ToString(),

                                     });
                    }
                }
            }
        }
    }
}
