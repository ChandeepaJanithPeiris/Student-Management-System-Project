namespace ABC_institute_student_management_system
{
    partial class LecturerDetails_A
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
            System.Windows.Forms.Label lecturerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label teleNoLabel;
            System.Windows.Forms.Label cityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerDetails_A));
            this.button1 = new System.Windows.Forms.Button();
            this.databaseDataSet = new ABC_institute_student_management_system.DatabaseDataSet();
            this.lecturerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerDetailsTableAdapter = new ABC_institute_student_management_system.DatabaseDataSetTableAdapters.LecturerDetailsTableAdapter();
            this.tableAdapterManager = new ABC_institute_student_management_system.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.lecturerDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lecturerDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lecturerIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.teleNoTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.lecturerDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lecturerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            teleNoLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDetailsBindingNavigator)).BeginInit();
            this.lecturerDetailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lecturerIDLabel
            // 
            lecturerIDLabel.AutoSize = true;
            lecturerIDLabel.Location = new System.Drawing.Point(186, 54);
            lecturerIDLabel.Name = "lecturerIDLabel";
            lecturerIDLabel.Size = new System.Drawing.Size(82, 17);
            lecturerIDLabel.TabIndex = 9;
            lecturerIDLabel.Text = "Lecturer ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(186, 82);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(186, 110);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // teleNoLabel
            // 
            teleNoLabel.AutoSize = true;
            teleNoLabel.Location = new System.Drawing.Point(186, 138);
            teleNoLabel.Name = "teleNoLabel";
            teleNoLabel.Size = new System.Drawing.Size(62, 17);
            teleNoLabel.TabIndex = 15;
            teleNoLabel.Text = "Tele No:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(186, 166);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 17;
            cityLabel.Text = "City:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(24, 407);
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
            // lecturerDetailsBindingSource
            // 
            this.lecturerDetailsBindingSource.DataMember = "LecturerDetails";
            this.lecturerDetailsBindingSource.DataSource = this.databaseDataSet;
            // 
            // lecturerDetailsTableAdapter
            // 
            this.lecturerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LecturerDetailsTableAdapter = this.lecturerDetailsTableAdapter;
            this.tableAdapterManager.StudentAttendenceTableAdapter = null;
            this.tableAdapterManager.StudentDetailsTableAdapter = null;
            this.tableAdapterManager.StudentMarksTableAdapter = null;
            this.tableAdapterManager.StudentPaymentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ABC_institute_student_management_system.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lecturerDetailsBindingNavigator
            // 
            this.lecturerDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lecturerDetailsBindingNavigator.BindingSource = this.lecturerDetailsBindingSource;
            this.lecturerDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lecturerDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lecturerDetailsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lecturerDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lecturerDetailsBindingNavigatorSaveItem});
            this.lecturerDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lecturerDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lecturerDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lecturerDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lecturerDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lecturerDetailsBindingNavigator.Name = "lecturerDetailsBindingNavigator";
            this.lecturerDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lecturerDetailsBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.lecturerDetailsBindingNavigator.TabIndex = 9;
            this.lecturerDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // lecturerDetailsBindingNavigatorSaveItem
            // 
            this.lecturerDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lecturerDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lecturerDetailsBindingNavigatorSaveItem.Image")));
            this.lecturerDetailsBindingNavigatorSaveItem.Name = "lecturerDetailsBindingNavigatorSaveItem";
            this.lecturerDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.lecturerDetailsBindingNavigatorSaveItem.Text = "Save Data";
            this.lecturerDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.lecturerDetailsBindingNavigatorSaveItem_Click);
            // 
            // lecturerIDTextBox
            // 
            this.lecturerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerDetailsBindingSource, "LecturerID", true));
            this.lecturerIDTextBox.Location = new System.Drawing.Point(274, 51);
            this.lecturerIDTextBox.Name = "lecturerIDTextBox";
            this.lecturerIDTextBox.Size = new System.Drawing.Size(298, 22);
            this.lecturerIDTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerDetailsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(274, 79);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(298, 22);
            this.nameTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerDetailsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(274, 107);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(298, 22);
            this.emailTextBox.TabIndex = 14;
            // 
            // teleNoTextBox
            // 
            this.teleNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerDetailsBindingSource, "TeleNo", true));
            this.teleNoTextBox.Location = new System.Drawing.Point(274, 135);
            this.teleNoTextBox.Name = "teleNoTextBox";
            this.teleNoTextBox.Size = new System.Drawing.Size(298, 22);
            this.teleNoTextBox.TabIndex = 16;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerDetailsBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(274, 163);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(298, 22);
            this.cityTextBox.TabIndex = 18;
            // 
            // lecturerDetailsDataGridView
            // 
            this.lecturerDetailsDataGridView.AutoGenerateColumns = false;
            this.lecturerDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecturerDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.lecturerDetailsDataGridView.DataSource = this.lecturerDetailsBindingSource;
            this.lecturerDetailsDataGridView.Location = new System.Drawing.Point(189, 246);
            this.lecturerDetailsDataGridView.Name = "lecturerDetailsDataGridView";
            this.lecturerDetailsDataGridView.RowHeadersWidth = 51;
            this.lecturerDetailsDataGridView.RowTemplate.Height = 24;
            this.lecturerDetailsDataGridView.Size = new System.Drawing.Size(542, 220);
            this.lecturerDetailsDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LecturerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "LecturerID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TeleNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "TeleNo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn5.HeaderText = "City";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // LecturerDetails_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.lecturerDetailsDataGridView);
            this.Controls.Add(lecturerIDLabel);
            this.Controls.Add(this.lecturerIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(teleNoLabel);
            this.Controls.Add(this.teleNoTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.lecturerDetailsBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "LecturerDetails_A";
            this.Text = "LecturerDetails_A";
            this.Load += new System.EventHandler(this.LecturerDetails_A_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDetailsBindingNavigator)).EndInit();
            this.lecturerDetailsBindingNavigator.ResumeLayout(false);
            this.lecturerDetailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource lecturerDetailsBindingSource;
        private DatabaseDataSetTableAdapters.LecturerDetailsTableAdapter lecturerDetailsTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lecturerDetailsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lecturerDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox lecturerIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox teleNoTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DataGridView lecturerDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}