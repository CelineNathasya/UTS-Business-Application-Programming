using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_Business_Application_Programming;
using System.Data.SqlClient;

namespace UTS_Business_Application_Programming
{
    public partial class admin_setting : Form
    {
        string connString = @"Data Source=DESKTOP-43407LQ\SQLEXPRESS;Initial Catalog=kiyo;Integrated Security=True";

        public admin_setting()
        {
            InitializeComponent();
        }

        private void admin_setting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kiyoDataSet.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.kiyoDataSet.Admins);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_setting_back_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 objform1 = new Form1();
            objform1.Show();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin_id_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_id_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        bool check = false;
        private void fieldcheck()
        {
            if (this.admin_id_txtbox.Text.Trim() == "")
            {
                MessageBox.Show("Please input admin id (only numbers)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.admin_id_txtbox.Focus();
            }
            else if (this.admin_name_txtbox.Text.Trim() == "")
            {
                MessageBox.Show("Please input admin name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.admin_name_txtbox.Focus();
            }
            else if (this.admin_password_txtbox.Text.Trim() == "")
            {
                MessageBox.Show("Please input password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.admin_password_txtbox.Focus();
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
                MessageBox.Show("Please complete the fields!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(connString);

                SqlTransaction trans = default;
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
                            @"INSERT INTO Admins (admin_id, admin_name, admin_password) 
                        VALUES (@id, @name, @pass)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", this.admin_id_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", this.admin_name_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", this.admin_password_txtbox.Text.Trim());
                       
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            fieldcheck();
            if (check == false)
            {
                MessageBox.Show("Please complete the fields!");
            }
            else
            {

                SqlConnection conn = new SqlConnection(connString);

                SqlTransaction trans = default;
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
                            @"update Admins set admin_name = @name, admin_password = @pass where admin_id = @id";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", this.admin_id_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", this.admin_name_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", this.admin_password_txtbox.Text.Trim());
                        
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                    MessageBox.Show("Update Success. Please re-open.");
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString) ;
            string query = "SELECT * FROM Admins WHERE admin_id = '" + admin_id_txtbox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            if (dta.Rows.Count != 1)
            {
                MessageBox.Show("Please input valid id!");

            }
            else
            {
                SqlTransaction trans = default;
                try
                {
                    conn = new SqlConnection(connString);
                    conn.Open();
                    trans = conn.BeginTransaction();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.Transaction = trans;

                        cmd.CommandText = @"DELETE FROM Admins where admin_id = @id";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", this.admin_id_txtbox.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                    MessageBox.Show("Delete Success. Please re-open.");
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

        private void admin_name_Click(object sender, EventArgs e)
        {

        }

        private void admin_id_Click(object sender, EventArgs e)
        {

        }

        private void admin_password_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_setting objmenusetting = new menu_setting();
            objmenusetting.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_setting objadms = new admin_setting();
            objadms.Show();
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_page objadmpage = new admin_page();
            objadmpage.Show();
        }
    }
}
