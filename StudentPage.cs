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
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu b = new MainMenu();
            this.Hide();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDetails_S obj1 = new StudentDetails_S();
            obj1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMarks_S obj1 = new StudentMarks_S();
            obj1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAttendence_S obj1 = new StudentAttendence_S();
            obj1.Show();
        }
    }
}
