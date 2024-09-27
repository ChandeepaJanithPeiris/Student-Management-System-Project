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
    public partial class StudentPayments_A : Form
    {
        public StudentPayments_A()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPage a = new AdminPage();
            this.Hide();
            a.Show();
        }

        private void studentPaymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentPaymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void StudentPayments_A_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.StudentPayments' table. You can move, or remove it, as needed.
            this.studentPaymentsTableAdapter.Fill(this.databaseDataSet.StudentPayments);

        }
    }
}
