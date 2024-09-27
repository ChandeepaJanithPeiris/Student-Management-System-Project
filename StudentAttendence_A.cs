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
    public partial class StudentAttendence_A : Form
    {
        public StudentAttendence_A()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage a = new AdminPage();
            this.Hide();
            a.Show();
        }

        private void studentAttendenceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentAttendenceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void StudentAttendence_A_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.StudentAttendence' table. You can move, or remove it, as needed.
            this.studentAttendenceTableAdapter.Fill(this.databaseDataSet.StudentAttendence);

        }
    }
}
