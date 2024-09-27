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
    public partial class StudentMarks_A : Form
    {
        public StudentMarks_A()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage a = new AdminPage();
            this.Hide();
            a.Show();
        }

        private void studentMarksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentMarksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void StudentMarks_A_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.StudentMarks' table. You can move, or remove it, as needed.
            this.studentMarksTableAdapter.Fill(this.databaseDataSet.StudentMarks);

        }
    }
}
