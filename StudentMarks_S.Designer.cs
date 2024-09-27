namespace ABC_institute_student_management_system
{
    partial class StudentMarks_S
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.databaseDataSet = new ABC_institute_student_management_system.DatabaseDataSet();
            this.studentMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentMarksTableAdapter = new ABC_institute_student_management_system.DatabaseDataSetTableAdapters.StudentMarksTableAdapter();
            this.tableAdapterManager = new ABC_institute_student_management_system.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.studentMarksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentMarksBindingSource
            // 
            this.studentMarksBindingSource.DataMember = "StudentMarks";
            this.studentMarksBindingSource.DataSource = this.databaseDataSet;
            // 
            // studentMarksTableAdapter
            // 
            this.studentMarksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LecturerDetailsTableAdapter = null;
            this.tableAdapterManager.StudentAttendenceTableAdapter = null;
            this.tableAdapterManager.StudentDetailsTableAdapter = null;
            this.tableAdapterManager.StudentMarksTableAdapter = this.studentMarksTableAdapter;
            this.tableAdapterManager.StudentPaymentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ABC_institute_student_management_system.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentMarksDataGridView
            // 
            this.studentMarksDataGridView.AutoGenerateColumns = false;
            this.studentMarksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentMarksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.studentMarksDataGridView.DataSource = this.studentMarksBindingSource;
            this.studentMarksDataGridView.Location = new System.Drawing.Point(85, 59);
            this.studentMarksDataGridView.Name = "studentMarksDataGridView";
            this.studentMarksDataGridView.RowTemplate.Height = 24;
            this.studentMarksDataGridView.Size = new System.Drawing.Size(640, 238);
            this.studentMarksDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Exam 1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Exam 1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Exam 2";
            this.dataGridViewTextBoxColumn3.HeaderText = "Exam 2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Exam 3";
            this.dataGridViewTextBoxColumn4.HeaderText = "Exam 3";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Exam 4";
            this.dataGridViewTextBoxColumn5.HeaderText = "Exam 4";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Exam 5";
            this.dataGridViewTextBoxColumn6.HeaderText = "Exam 5";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // StudentMarks_S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentMarksDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "StudentMarks_S";
            this.Text = "StudentMarks_S";
            this.Load += new System.EventHandler(this.StudentMarks_S_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource studentMarksBindingSource;
        private DatabaseDataSetTableAdapters.StudentMarksTableAdapter studentMarksTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView studentMarksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}