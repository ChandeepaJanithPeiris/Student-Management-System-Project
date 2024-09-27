using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_institute_student_management_system
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (username == "chan" && password == "123")
            {
                MessageBox.Show("Login Sucess!");
                this.Hide();
                AdminPage obj1 = new AdminPage();
                obj1.Show();
            }
            else
            {
                MessageBox.Show("Login not sucess!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                MainMenu b = new MainMenu();
                this.Hide();
                b.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
