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
    public partial class StudentDetails_A : Form
    {
        public StudentDetails_A()
        {
            InitializeComponent();
        }

        private void studentDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void StudentDetails_A_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.StudentDetails' table. You can move, or remove it, as needed.
            this.studentDetailsTableAdapter.Fill(this.databaseDataSet.StudentDetails);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage a = new AdminPage();
            this.Hide();
            a.Show();
        }
    }
}
