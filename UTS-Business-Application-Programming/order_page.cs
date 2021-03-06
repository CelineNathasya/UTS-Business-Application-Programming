﻿using System;
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
    public partial class order_page : Form
    {
        public order_page()
        {
            InitializeComponent();
        }

        private void order_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kiyoDataSet.Orders' table. You can move, or remove it, as needed.
            ////this.ordersTableAdapter.Fill(this.kiyoDataSet.Orders);
            // TODO: This line of code loads data into the 'kiyoDataSet.Menus' table. You can move, or remove it, as needed.
            this.menusTableAdapter.Fill(this.kiyoDataSet.Menus);
            LoadToComboBox();



        }

        private void connection()
        {
            string connString = @"Data Source = DESKTOP - 43407LQ\SQLEXPRESS; Initial Catalog = kiyo; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void showData(string id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-43407LQ\SQLEXPRESS;Initial Catalog=kiyo;Integrated Security=True");
                conn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = @"SELECT menu_id, menu_name, menu_price From menus Where menu_id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView2.Rows.Add(((KeyValuePair<string, string>)comboBox1.SelectedItem).Key.ToString(), reader["menu_price"].ToString(), qty_txtbox.Text, Convert.ToString(Convert.ToInt32(reader["menu_price"].ToString()) * Convert.ToInt32(qty_txtbox.Text)));
                            int sum = 0;
                            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                            {
                                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells["Subtotal"].Value);
                            }
                            total_lbl.Text = sum.ToString();
                        }
                    }
                }


            }
            catch (Exception)
            {
                throw;
            }
        }
        private void LoadToComboBox()
        {

            IDictionary<string, string> comboSource = new Dictionary<string, string>();
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-43407LQ\SQLEXPRESS;Initial Catalog=kiyo;Integrated Security=True");
                conn.Open();
                var cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = @"Select menu_id,menu_name From menus";
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            comboSource.Add(reader["menu_id"].ToString(), reader["menu_name"].ToString());
                        }
                    }
                }


            }
            catch (Exception)
            {
                throw;
            }

            comboBox1.DataSource = new BindingSource(comboSource, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (qty_txtbox.Text.Equals(""))
            {
                MessageBox.Show("Please input quantity", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (qty_txtbox.Text.Equals("0"))
            {
                MessageBox.Show("Quantity must not 0!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool checker = false;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Cells["ID"].Value.ToString().Equals(((KeyValuePair<string, string>)comboBox1.SelectedItem).Key.ToString()))
                    {
                        checker = true;
                        MessageBox.Show("Already added", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                if (!checker)
                    showData(((KeyValuePair<string, string>)comboBox1.SelectedItem).Key.ToString());

            }
        }


        private void qty_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    dataGridView2.Rows.RemoveAt(row.Index);
                }
                int total_price = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    total_price += Convert.ToInt32(dataGridView2.Rows[i].Cells["subtotal"].Value);
                }
                total_lbl.Text = total_price.ToString();
            }
            else
            {
                MessageBox.Show("No menu selected, please select", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void table_txt_TextChanged(object sender, EventArgs e)
        {

        }

        string id_order;
        private void order_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count.ToString().Equals("0"))
            {
                MessageBox.Show("Please select your menu", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (table_txt.Text.Equals(""))
                {
                    MessageBox.Show("Please input table number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-43407LQ\SQLEXPRESS;Initial Catalog=kiyo;Integrated Security=True");
                    conn.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = @"Insert Into Orders (order_total,order_date,table_no) Values (@total,@date,@table)";
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@total", total_lbl.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);
                    cmd.Parameters.AddWithValue("@table", table_txt.Text.Trim());
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = @"SELECT TOP 1 * FROM orders ORDER BY order_id DESC";
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_order = reader["order_id"].ToString();
                            }
                        }
                        else
                        {
                            id_order = "1";
                        }
                    }

                    MessageBox.Show("Order completed, please proceed to payment", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 objfrm = new Form1();
                    this.Hide();
                    objfrm.Show();
                   

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            favourite_menu objfv = new favourite_menu();
            objfv.Show();
        }
    }
}
