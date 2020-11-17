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
    public partial class menu_setting : Form
    {
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
    }
}
