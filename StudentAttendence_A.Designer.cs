namespace ABC_institute_student_management_system
{
    partial class StudentAttendence_A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAttendence_A));
            this.button1 = new System.Windows.Forms.Button();
            this.databaseDataSet = new ABC_institute_student_management_system.DatabaseDataSet();
            this.studentAttendenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentAttendenceTableAdapter = new ABC_institute_student_management_system.DatabaseDataSetTableAdapters.StudentAttendenceTableAdapter();
            this.tableAdapterManager = new ABC_institute_student_management_system.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.studentAttendenceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.studentAttendenceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentAttendenceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn12 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn13 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn14 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn15 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn16 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn17 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn18 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn19 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn20 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn21 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn22 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn23 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn24 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn25 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn26 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn27 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn28 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn29 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn30 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendenceBindingNavigator)).BeginInit();
            this.studentAttendenceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendenceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(27, 370);
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
            // studentAttendenceBindingSource
            // 
            this.studentAttendenceBindingSource.DataMember = "StudentAttendence";
            this.studentAttendenceBindingSource.DataSource = this.databaseDataSet;
            // 
            // studentAttendenceTableAdapter
            // 
            this.studentAttendenceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LecturerDetailsTableAdapter = null;
            this.tableAdapterManager.StudentAttendenceTableAdapter = this.studentAttendenceTableAdapter;
            this.tableAdapterManager.StudentDetailsTableAdapter = null;
            this.tableAdapterManager.StudentMarksTableAdapter = null;
            this.tableAdapterManager.StudentPaymentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ABC_institute_student_management_system.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentAttendenceBindingNavigator
            // 
            this.studentAttendenceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentAttendenceBindingNavigator.BindingSource = this.studentAttendenceBindingSource;
            this.studentAttendenceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentAttendenceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentAttendenceBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentAttendenceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentAttendenceBindingNavigatorSaveItem});
            this.studentAttendenceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentAttendenceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentAttendenceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentAttendenceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentAttendenceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentAttendenceBindingNavigator.Name = "studentAttendenceBindingNavigator";
            this.studentAttendenceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentAttendenceBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.studentAttendenceBindingNavigator.TabIndex = 9;
            this.studentAttendenceBindingNavigator.Text = "bindingNavigator1";
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
            // studentAttendenceBindingNavigatorSaveItem
            // 
            this.studentAttendenceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentAttendenceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentAttendenceBindingNavigatorSaveItem.Image")));
            this.studentAttendenceBindingNavigatorSaveItem.Name = "studentAttendenceBindingNavigatorSaveItem";
            this.studentAttendenceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.studentAttendenceBindingNavigatorSaveItem.Text = "Save Data";
            this.studentAttendenceBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentAttendenceBindingNavigatorSaveItem_Click);
            // 
            // studentAttendenceDataGridView
            // 
            this.studentAttendenceDataGridView.AutoGenerateColumns = false;
            this.studentAttendenceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentAttendenceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6,
            this.dataGridViewCheckBoxColumn7,
            this.dataGridViewCheckBoxColumn8,
            this.dataGridViewCheckBoxColumn9,
            this.dataGridViewCheckBoxColumn10,
            this.dataGridViewCheckBoxColumn11,
            this.dataGridViewCheckBoxColumn12,
            this.dataGridViewCheckBoxColumn13,
            this.dataGridViewCheckBoxColumn14,
            this.dataGridViewCheckBoxColumn15,
            this.dataGridViewCheckBoxColumn16,
            this.dataGridViewCheckBoxColumn17,
            this.dataGridViewCheckBoxColumn18,
            this.dataGridViewCheckBoxColumn19,
            this.dataGridViewCheckBoxColumn20,
            this.dataGridViewCheckBoxColumn21,
            this.dataGridViewCheckBoxColumn22,
            this.dataGridViewCheckBoxColumn23,
            this.dataGridViewCheckBoxColumn24,
            this.dataGridViewCheckBoxColumn25,
            this.dataGridViewCheckBoxColumn26,
            this.dataGridViewCheckBoxColumn27,
            this.dataGridViewCheckBoxColumn28,
            this.dataGridViewCheckBoxColumn29,
            this.dataGridViewCheckBoxColumn30});
            this.studentAttendenceDataGridView.DataSource = this.studentAttendenceBindingSource;
            this.studentAttendenceDataGridView.Location = new System.Drawing.Point(86, 69);
            this.studentAttendenceDataGridView.Name = "studentAttendenceDataGridView";
            this.studentAttendenceDataGridView.RowTemplate.Height = 24;
            this.studentAttendenceDataGridView.Size = new System.Drawing.Size(644, 220);
            this.studentAttendenceDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Day 1";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Day 1";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Day 2";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Day 2";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Day 3";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Day 3";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Day 4";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Day 4";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "Day 5";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Day 5";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "Day 6";
            this.dataGridViewCheckBoxColumn6.HeaderText = "Day 6";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn7
            // 
            this.dataGridViewCheckBoxColumn7.DataPropertyName = "Day 7";
            this.dataGridViewCheckBoxColumn7.HeaderText = "Day 7";
            this.dataGridViewCheckBoxColumn7.Name = "dataGridViewCheckBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn8
            // 
            this.dataGridViewCheckBoxColumn8.DataPropertyName = "Day 8";
            this.dataGridViewCheckBoxColumn8.HeaderText = "Day 8";
            this.dataGridViewCheckBoxColumn8.Name = "dataGridViewCheckBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn9
            // 
            this.dataGridViewCheckBoxColumn9.DataPropertyName = "Day 9";
            this.dataGridViewCheckBoxColumn9.HeaderText = "Day 9";
            this.dataGridViewCheckBoxColumn9.Name = "dataGridViewCheckBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn10
            // 
            this.dataGridViewCheckBoxColumn10.DataPropertyName = "Day 10";
            this.dataGridViewCheckBoxColumn10.HeaderText = "Day 10";
            this.dataGridViewCheckBoxColumn10.Name = "dataGridViewCheckBoxColumn10";
            // 
            // dataGridViewCheckBoxColumn11
            // 
            this.dataGridViewCheckBoxColumn11.DataPropertyName = "Day 11";
            this.dataGridViewCheckBoxColumn11.HeaderText = "Day 11";
            this.dataGridViewCheckBoxColumn11.Name = "dataGridViewCheckBoxColumn11";
            // 
            // dataGridViewCheckBoxColumn12
            // 
            this.dataGridViewCheckBoxColumn12.DataPropertyName = "Day 12";
            this.dataGridViewCheckBoxColumn12.HeaderText = "Day 12";
            this.dataGridViewCheckBoxColumn12.Name = "dataGridViewCheckBoxColumn12";
            // 
            // dataGridViewCheckBoxColumn13
            // 
            this.dataGridViewCheckBoxColumn13.DataPropertyName = "Day 13";
            this.dataGridViewCheckBoxColumn13.HeaderText = "Day 13";
            this.dataGridViewCheckBoxColumn13.Name = "dataGridViewCheckBoxColumn13";
            // 
            // dataGridViewCheckBoxColumn14
            // 
            this.dataGridViewCheckBoxColumn14.DataPropertyName = "Day 14";
            this.dataGridViewCheckBoxColumn14.HeaderText = "Day 14";
            this.dataGridViewCheckBoxColumn14.Name = "dataGridViewCheckBoxColumn14";
            // 
            // dataGridViewCheckBoxColumn15
            // 
            this.dataGridViewCheckBoxColumn15.DataPropertyName = "Day 15";
            this.dataGridViewCheckBoxColumn15.HeaderText = "Day 15";
            this.dataGridViewCheckBoxColumn15.Name = "dataGridViewCheckBoxColumn15";
            // 
            // dataGridViewCheckBoxColumn16
            // 
            this.dataGridViewCheckBoxColumn16.DataPropertyName = "Day 16";
            this.dataGridViewCheckBoxColumn16.HeaderText = "Day 16";
            this.dataGridViewCheckBoxColumn16.Name = "dataGridViewCheckBoxColumn16";
            // 
            // dataGridViewCheckBoxColumn17
            // 
            this.dataGridViewCheckBoxColumn17.DataPropertyName = "Day 17";
            this.dataGridViewCheckBoxColumn17.HeaderText = "Day 17";
            this.dataGridViewCheckBoxColumn17.Name = "dataGridViewCheckBoxColumn17";
            // 
            // dataGridViewCheckBoxColumn18
            // 
            this.dataGridViewCheckBoxColumn18.DataPropertyName = "Day 18";
            this.dataGridViewCheckBoxColumn18.HeaderText = "Day 18";
            this.dataGridViewCheckBoxColumn18.Name = "dataGridViewCheckBoxColumn18";
            // 
            // dataGridViewCheckBoxColumn19
            // 
            this.dataGridViewCheckBoxColumn19.DataPropertyName = "Day 19";
            this.dataGridViewCheckBoxColumn19.HeaderText = "Day 19";
            this.dataGridViewCheckBoxColumn19.Name = "dataGridViewCheckBoxColumn19";
            // 
            // dataGridViewCheckBoxColumn20
            // 
            this.dataGridViewCheckBoxColumn20.DataPropertyName = "Day 20";
            this.dataGridViewCheckBoxColumn20.HeaderText = "Day 20";
            this.dataGridViewCheckBoxColumn20.Name = "dataGridViewCheckBoxColumn20";
            // 
            // dataGridViewCheckBoxColumn21
            // 
            this.dataGridViewCheckBoxColumn21.DataPropertyName = "Day 21";
            this.dataGridViewCheckBoxColumn21.HeaderText = "Day 21";
            this.dataGridViewCheckBoxColumn21.Name = "dataGridViewCheckBoxColumn21";
            // 
            // dataGridViewCheckBoxColumn22
            // 
            this.dataGridViewCheckBoxColumn22.DataPropertyName = "Day 22";
            this.dataGridViewCheckBoxColumn22.HeaderText = "Day 22";
            this.dataGridViewCheckBoxColumn22.Name = "dataGridViewCheckBoxColumn22";
            // 
            // dataGridViewCheckBoxColumn23
            // 
            this.dataGridViewCheckBoxColumn23.DataPropertyName = "Day 23";
            this.dataGridViewCheckBoxColumn23.HeaderText = "Day 23";
            this.dataGridViewCheckBoxColumn23.Name = "dataGridViewCheckBoxColumn23";
            // 
            // dataGridViewCheckBoxColumn24
            // 
            this.dataGridViewCheckBoxColumn24.DataPropertyName = "Day 24";
            this.dataGridViewCheckBoxColumn24.HeaderText = "Day 24";
            this.dataGridViewCheckBoxColumn24.Name = "dataGridViewCheckBoxColumn24";
            // 
            // dataGridViewCheckBoxColumn25
            // 
            this.dataGridViewCheckBoxColumn25.DataPropertyName = "Day 25";
            this.dataGridViewCheckBoxColumn25.HeaderText = "Day 25";
            this.dataGridViewCheckBoxColumn25.Name = "dataGridViewCheckBoxColumn25";
            // 
            // dataGridViewCheckBoxColumn26
            // 
            this.dataGridViewCheckBoxColumn26.DataPropertyName = "Day 26";
            this.dataGridViewCheckBoxColumn26.HeaderText = "Day 26";
            this.dataGridViewCheckBoxColumn26.Name = "dataGridViewCheckBoxColumn26";
            // 
            // dataGridViewCheckBoxColumn27
            // 
            this.dataGridViewCheckBoxColumn27.DataPropertyName = "Day 27";
            this.dataGridViewCheckBoxColumn27.HeaderText = "Day 27";
            this.dataGridViewCheckBoxColumn27.Name = "dataGridViewCheckBoxColumn27";
            // 
            // dataGridViewCheckBoxColumn28
            // 
            this.dataGridViewCheckBoxColumn28.DataPropertyName = "Day 28";
            this.dataGridViewCheckBoxColumn28.HeaderText = "Day 28";
            this.dataGridViewCheckBoxColumn28.Name = "dataGridViewCheckBoxColumn28";
            // 
            // dataGridViewCheckBoxColumn29
            // 
            this.dataGridViewCheckBoxColumn29.DataPropertyName = "Day 29";
            this.dataGridViewCheckBoxColumn29.HeaderText = "Day 29";
            this.dataGridViewCheckBoxColumn29.Name = "dataGridViewCheckBoxColumn29";
            // 
            // dataGridViewCheckBoxColumn30
            // 
            this.dataGridViewCheckBoxColumn30.DataPropertyName = "Day 30";
            this.dataGridViewCheckBoxColumn30.HeaderText = "Day 30";
            this.dataGridViewCheckBoxColumn30.Name = "dataGridViewCheckBoxColumn30";
            // 
            // StudentAttendence_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentAttendenceDataGridView);
            this.Controls.Add(this.studentAttendenceBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "StudentAttendence_A";
            this.Text = "StudentAttendence_A";
            this.Load += new System.EventHandler(this.StudentAttendence_A_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendenceBindingNavigator)).EndInit();
            this.studentAttendenceBindingNavigator.ResumeLayout(false);
            this.studentAttendenceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendenceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource studentAttendenceBindingSource;
        private DatabaseDataSetTableAdapters.StudentAttendenceTableAdapter studentAttendenceTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentAttendenceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentAttendenceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView studentAttendenceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn16;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn17;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn19;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn20;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn21;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn22;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn23;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn24;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn25;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn26;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn27;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn28;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn29;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn30;
    }
}