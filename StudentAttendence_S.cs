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
    public partial class StudentAttendence_S : Form
    {
        public StudentAttendence_S()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPage c = new StudentPage();
            this.Hide();
            c.Show();
        }

        private void studentAttendenceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentAttendenceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void StudentAttendence_S_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.StudentAttendence' table. You can move, or remove it, as needed.
            this.studentAttendenceTableAdapter.Fill(this.databaseDataSet.StudentAttendence);

        }
    }
}
