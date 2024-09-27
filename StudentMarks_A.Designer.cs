namespace ABC_institute_student_management_system
{
    partial class StudentMarks_A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMarks_A));
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label exam_1Label;
            System.Windows.Forms.Label exam_2Label;
            System.Windows.Forms.Label exam_3Label;
            System.Windows.Forms.Label exam_4Label;
            System.Windows.Forms.Label exam_5Label;
            this.button1 = new System.Windows.Forms.Button();
            this.databaseDataSet = new ABC_institute_student_management_system.DatabaseDataSet();
            this.studentMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentMarksTableAdapter = new ABC_institute_student_management_system.DatabaseDataSetTableAdapters.StudentMarksTableAdapter();
            this.tableAdapterManager = new ABC_institute_student_management_system.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.studentMarksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.studentMarksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.exam_1TextBox = new System.Windows.Forms.TextBox();
            this.exam_2TextBox = new System.Windows.Forms.TextBox();
            this.exam_3TextBox = new System.Windows.Forms.TextBox();
            this.exam_4TextBox = new System.Windows.Forms.TextBox();
            this.exam_5TextBox = new System.Windows.Forms.TextBox();
            this.studentMarksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            studentIDLabel = new System.Windows.Forms.Label();
            exam_1Label = new System.Windows.Forms.Label();
            exam_2Label = new System.Windows.Forms.Label();
            exam_3Label = new System.Windows.Forms.Label();
            exam_4Label = new System.Windows.Forms.Label();
            exam_5Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksBindingNavigator)).BeginInit();
            this.studentMarksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 59);
            this.button1.TabIndex = 8;
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
            // studentMarksBindingNavigator
            // 
            this.studentMarksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentMarksBindingNavigator.BindingSource = this.studentMarksBindingSource;
            this.studentMarksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentMarksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentMarksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentMarksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentMarksBindingNavigatorSaveItem});
            this.studentMarksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentMarksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentMarksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentMarksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentMarksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentMarksBindingNavigator.Name = "studentMarksBindingNavigator";
            this.studentMarksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentMarksBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.studentMarksBindingNavigator.TabIndex = 9;
            this.studentMarksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // studentMarksBindingNavigatorSaveItem
            // 
            this.studentMarksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentMarksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentMarksBindingNavigatorSaveItem.Image")));
            this.studentMarksBindingNavigatorSaveItem.Name = "studentMarksBindingNavigatorSaveItem";
            this.studentMarksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.studentMarksBindingNavigatorSaveItem.Text = "Save Data";
            this.studentMarksBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentMarksBindingNavigatorSaveItem_Click);
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(97, 91);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(78, 17);
            studentIDLabel.TabIndex = 9;
            studentIDLabel.Text = "Student ID:";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentMarksBindingSource, "StudentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(181, 88);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.studentIDTextBox.TabIndex = 10;
            // 
            // exam_1Label
            // 
            exam_1Label.AutoSize = true;
            exam_1Label.Location = new System.Drawing.Point(446, 34);
            exam_1Label.Name = "exam_1Label";
            exam_1Label.Size = new System.Drawing.Size(58, 17);
            exam_1Label.TabIndex = 11;
            exam_1Label.Text = "Exam 1:";
            // 
            // exam_1TextBox
            // 
            this.exam_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentMarksBindingSource, "Exam 1", true));
            this.exam_1TextBox.Location = new System.Drawing.Point(530, 31);
            this.exam_1TextBox.Name = "exam_1TextBox";
            this.exam_1TextBox.Size = new System.Drawing.Size(100, 22);
            this.exam_1TextBox.TabIndex = 12;
            // 
            // exam_2Label
            // 
            exam_2Label.AutoSize = true;
            exam_2Label.Location = new System.Drawing.Point(446, 62);
            exam_2Label.Name = "exam_2Label";
            exam_2Label.Size = new System.Drawing.Size(58, 17);
            exam_2Label.TabIndex = 13;
            exam_2Label.Text = "Exam 2:";
            // 
            // exam_2TextBox
            // 
            this.exam_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentMarksBindingSource, "Exam 2", true));
            this.exam_2TextBox.Location = new System.Drawing.Point(530, 59);
            this.exam_2TextBox.Name = "exam_2TextBox";
            this.exam_2TextBox.Size = new System.Drawing.Size(100, 22);
            this.exam_2TextBox.TabIndex = 14;
            // 
            // exam_3Label
            // 
            exam_3Label.AutoSize = true;
            exam_3Label.Location = new System.Drawing.Point(446, 90);
            exam_3Label.Name = "exam_3Label";
            exam_3Label.Size = new System.Drawing.Size(58, 17);
            exam_3Label.TabIndex = 15;
            exam_3Label.Text = "Exam 3:";
            // 
            // exam_3TextBox
            // 
            this.exam_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentMarksBindingSource, "Exam 3", true));
            this.exam_3TextBox.Location = new System.Drawing.Point(530, 87);
            this.exam_3TextBox.Name = "exam_3TextBox";
            this.exam_3TextBox.Size = new System.Drawing.Size(100, 22);
            this.exam_3TextBox.TabIndex = 16;
            // 
            // exam_4Label
            // 
            exam_4Label.AutoSize = true;
            exam_4Label.Location = new System.Drawing.Point(446, 118);
            exam_4Label.Name = "exam_4Label";
            exam_4Label.Size = new System.Drawing.Size(58, 17);
            exam_4Label.TabIndex = 17;
            exam_4Label.Text = "Exam 4:";
            // 
            // exam_4TextBox
            // 
            this.exam_4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentMarksBindingSource, "Exam 4", true));
            this.exam_4TextBox.Location = new System.Drawing.Point(530, 115);
            this.exam_4TextBox.Name = "exam_4TextBox";
            this.exam_4TextBox.Size = new System.Drawing.Size(100, 22);
            this.exam_4TextBox.TabIndex = 18;
            // 
            // exam_5Label
            // 
            exam_5Label.AutoSize = true;
            exam_5Label.Location = new System.Drawing.Point(446, 146);
            exam_5Label.Name = "exam_5Label";
            exam_5Label.Size = new System.Drawing.Size(58, 17);
            exam_5Label.TabIndex = 19;
            exam_5Label.Text = "Exam 5:";
            // 
            // exam_5TextBox
            // 
            this.exam_5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentMarksBindingSource, "Exam 5", true));
            this.exam_5TextBox.Location = new System.Drawing.Point(530, 143);
            this.exam_5TextBox.Name = "exam_5TextBox";
            this.exam_5TextBox.Size = new System.Drawing.Size(100, 22);
            this.exam_5TextBox.TabIndex = 20;
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
            this.studentMarksDataGridView.Location = new System.Drawing.Point(145, 203);
            this.studentMarksDataGridView.Name = "studentMarksDataGridView";
            this.studentMarksDataGridView.RowTemplate.Height = 24;
            this.studentMarksDataGridView.Size = new System.Drawing.Size(643, 220);
            this.studentMarksDataGridView.TabIndex = 20;
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
            // StudentMarks_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.studentMarksDataGridView);
            this.Controls.Add(studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(exam_1Label);
            this.Controls.Add(this.exam_1TextBox);
            this.Controls.Add(exam_2Label);
            this.Controls.Add(this.exam_2TextBox);
            this.Controls.Add(exam_3Label);
            this.Controls.Add(this.exam_3TextBox);
            this.Controls.Add(exam_4Label);
            this.Controls.Add(this.exam_4TextBox);
            this.Controls.Add(exam_5Label);
            this.Controls.Add(this.exam_5TextBox);
            this.Controls.Add(this.studentMarksBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "StudentMarks_A";
            this.Text = "StudentMarks_A";
            this.Load += new System.EventHandler(this.StudentMarks_A_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksBindingNavigator)).EndInit();
            this.studentMarksBindingNavigator.ResumeLayout(false);
            this.studentMarksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource studentMarksBindingSource;
        private DatabaseDataSetTableAdapters.StudentMarksTableAdapter studentMarksTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentMarksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentMarksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox exam_1TextBox;
        private System.Windows.Forms.TextBox exam_2TextBox;
        private System.Windows.Forms.TextBox exam_3TextBox;
        private System.Windows.Forms.TextBox exam_4TextBox;
        private System.Windows.Forms.TextBox exam_5TextBox;
        private System.Windows.Forms.DataGridView studentMarksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}