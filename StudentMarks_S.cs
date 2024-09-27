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
    public partial class StudentMarks_S : Form
    {
        public StudentMarks_S()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPage c = new StudentPage();
            this.Hide();
            c.Show();
        }

        private void studentMarksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentMarksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void StudentMarks_S_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.StudentMarks' table. You can move, or remove it, as needed.
            this.studentMarksTableAdapter.Fill(this.databaseDataSet.StudentMarks);

        }
    }
}
