﻿namespace Week_3_Assignment_3._3._1
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
            btnAdd = new Button();
            label1 = new Label();
            lstNames = new ListBox();
            txtName = new TextBox();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(224, 184);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Names";
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 15;
            lstNames.Location = new Point(12, 9);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(312, 169);
            lstNames.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 185);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(118, 184);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(100, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove Name";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 562);
            Controls.Add(btnRemove);
            Controls.Add(txtName);
            Controls.Add(lstNames);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Names";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private ListBox lstNames;
        private TextBox txtName;
        private Button btnRemove;
    }
}
