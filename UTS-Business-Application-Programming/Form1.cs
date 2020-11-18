using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_Business_Application_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void admin_login_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_login_page objalp = new admin_login_page();
            objalp.Show();
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer_login objcustlg = new customer_login();
            objcustlg.Show();
        }
    }
}
