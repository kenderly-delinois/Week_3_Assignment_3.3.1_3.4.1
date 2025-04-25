namespace WinformStudentApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            studentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monthOfAdmissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gPADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, studentAddressDataGridViewTextBoxColumn, monthOfAdmissionDataGridViewTextBoxColumn, gPADataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentBindingSource;
            dataGridView1.Location = new Point(131, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(634, 322);
            dataGridView1.TabIndex = 0;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // studentAddressDataGridViewTextBoxColumn
            // 
            studentAddressDataGridViewTextBoxColumn.DataPropertyName = "StudentAddress";
            studentAddressDataGridViewTextBoxColumn.HeaderText = "StudentAddress";
            studentAddressDataGridViewTextBoxColumn.Name = "studentAddressDataGridViewTextBoxColumn";
            // 
            // monthOfAdmissionDataGridViewTextBoxColumn
            // 
            monthOfAdmissionDataGridViewTextBoxColumn.DataPropertyName = "MonthOfAdmission";
            monthOfAdmissionDataGridViewTextBoxColumn.HeaderText = "MonthOfAdmission";
            monthOfAdmissionDataGridViewTextBoxColumn.Name = "monthOfAdmissionDataGridViewTextBoxColumn";
            // 
            // gPADataGridViewTextBoxColumn
            // 
            gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monthOfAdmissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
    }
}
