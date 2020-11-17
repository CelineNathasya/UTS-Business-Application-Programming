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
    public partial class admin_page : Form
    {
        public admin_page()
        {
            InitializeComponent();
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
    }
}
