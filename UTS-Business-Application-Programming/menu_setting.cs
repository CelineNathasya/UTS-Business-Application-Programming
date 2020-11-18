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
using help;

namespace UTS_Business_Application_Programming
{
    public partial class menu_setting : Form
    {

        string connString = @"Data Source=DESKTOP-43407LQ\SQLEXPRESS;Initial Catalog=kiyo;Integrated Security=True";

        public menu_setting()
        {
            InitializeComponent();
        }

        private void menu_setting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kiyoDataSet.Menus' table. You can move, or remove it, as needed.
            this.menusTableAdapter.Fill(this.kiyoDataSet.Menus);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_page objadmpage = new admin_page();
            objadmpage.Show();
        }
        string opnfdFn = "";
        private void photo_upload_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                menu_pic.Image = new Bitmap(opnfd.FileName);
                opnfdFn = opnfd.FileName;
            }

        }

        private void menu_pic_Click(object sender, EventArgs e)
        {

        }


        bool check = false;
        private void fieldcheck()
        {
            if (this.menu_id_txtbox.Text.Trim() == "")
            {
                MessageBox.Show("Please input menu id (only numbers)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.menu_id_txtbox.Focus();
            }
            else if (this.menu_name_txtbox.Text.Trim() == "")
            {
                MessageBox.Show("Please input menu name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.menu_name_txtbox.Focus();
            }
            else if (this.menu_price_txtbox.Text.Trim() == "")
            {
                MessageBox.Show("Please input price", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.menu_price_txtbox.Focus();
            }
            else if (this.menu_desc_txtbox.Text.Trim() == null)
            {
                MessageBox.Show("Please input description", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.menu_pic.Image == null)
            {
                MessageBox.Show("Please input photo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                check = true;
            }
        }

        private void add_new_btn_Click(object sender, EventArgs e)
        {
            fieldcheck();
            if (check == false)
            {
                MessageBox.Show("Please complete the field!");
            }
            else
            {
                string saveimg = "";
                SqlConnection conn = new SqlConnection(connString);

                SqlTransaction trans = default;

                ImageServices imgs = new ImageServices(opnfdFn);
                imgs.storeImage();
                saveimg = imgs.createdFileName;
                
                try
                {
                    conn = new SqlConnection(connString);
                    conn.Open();
                    trans = conn.BeginTransaction();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.Transaction = trans;
                        cmd.CommandText =
                            @"INSERT INTO Menus (menu_id, menu_name, menu_price, menu_description, menu_img) 
                        VALUES (@id, @name, @price, @des, @img)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", this.menu_id_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", this.menu_name_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@price", this.menu_price_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@des", this.menu_desc_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@img", saveimg);

                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                    MessageBox.Show("Add Success. Please re-open.");
                }
                catch (Exception ex)
                {
                    if (trans != null) trans.Rollback();
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    if (trans != null) trans.Dispose();
                    if (conn != null) conn.Close();
                }
            }
        }

        private void menu_desc_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
