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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentPayments_A obj1 = new StudentPayments_A();
            obj1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAttendence_A obj1 = new StudentAttendence_A();
            obj1.Show();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDetails_A obj1 = new StudentDetails_A();
            obj1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerDetails_A obj1 = new LecturerDetails_A();
            obj1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMarks_A obj1 = new StudentMarks_A();
            obj1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu b = new MainMenu();
            this.Hide();
            b.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
