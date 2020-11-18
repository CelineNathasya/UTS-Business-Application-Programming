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
    public partial class customer_signup : Form
    {
        public customer_signup()
        {
            InitializeComponent();
        }

        string connString = @"Data Source=DESKTOP-43407LQ\SQLEXPRESS;Initial Catalog=kiyo;Integrated Security=True";

        bool check = false;
        private void fieldcheck()
        {
            if (this.cust_name.Text.Trim() == "")
            {
                MessageBox.Show("Please input admin id (only numbers)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cust_name.Focus();
            }
            else if (this.cust_pass.Text.Trim() == "")
            {
                MessageBox.Show("Please input admin name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cust_pass.Focus();
            }
            else
            {
                check = true;
            }
        }
        private void signup_btn_Click(object sender, EventArgs e)
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
                            @"INSERT INTO Customers (customer_name, customer_password) 
                        VALUES ( @name, @pass)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@name", this.cust_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", this.cust_pass.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                    MessageBox.Show("Add Success. Please continue ordering.");

                    this.Hide();
                    customer_login objcustlg = new customer_login();
                    objcustlg.Show();
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

        private void cust_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void cust_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
