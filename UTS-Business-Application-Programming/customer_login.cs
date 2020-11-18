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
    public partial class customer_login : Form
    {
        public customer_login()
        {
            InitializeComponent();
        }

        private void customer_login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kiyoDataSet._Tables' table. You can move, or remove it, as needed.
            this.tablesTableAdapter.Fill(this.kiyoDataSet._Tables);

        }

        private void new_acc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            customer_signup objcustsgn = new customer_signup();
            objcustsgn.Show();
        }

        private void name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-43407LQ\SQLEXPRESS;Initial Catalog=kiyo;Integrated Security=True");

            // DO VALIDATION

            string query = "SELECT * FROM Customers WHERE customer_name = '" + name_txtbox.Text.Trim() + "' AND customer_password = '" + password_txtbox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            if (dta.Rows.Count == 1)
            {
                this.Hide();
                order_page objorder = new order_page();
                objorder.Show();

            }
            else
            {
                MessageBox.Show("Check your id and password!");
            }
        }
    }
}
