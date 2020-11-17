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
    public partial class admin_login_page : Form
    {
        public admin_login_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void admin_login_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kiyoDataSet.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.kiyoDataSet.Admins);

        }

        private void admin_login_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-43407LQ\SQLEXPRESS;Initial Catalog=kiyo;Integrated Security=True");

            // DO VALIDATION

            string query = "SELECT * FROM Admins WHERE admin_id = '" + admin_id.Text.Trim() +"' AND admin_password = '" + admin_pass.Text.Trim() +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            if(dta.Rows.Count == 1)
            {
                admin_page objadmin_page = new admin_page();
                this.Hide();
                objadmin_page.Show();

            }
            else
            {
                MessageBox.Show("Check your id and password!");
            }
        }

        private void admin_back_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 objform1 = new Form1();
            objform1.Show();
        }

        private void admin_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void admin_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
