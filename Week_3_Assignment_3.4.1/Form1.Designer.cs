namespace Week_3_Assignment_3._4._1
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
            isDecafDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            varietyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roastyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bevNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            temperaturedegFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            packageTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeOzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coffeeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { isDecafDataGridViewCheckBoxColumn, varietyDataGridViewTextBoxColumn, roastyDataGridViewTextBoxColumn, bevNameDataGridViewTextBoxColumn, temperaturedegFDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, packageTypeDataGridViewTextBoxColumn, sizeOzDataGridViewTextBoxColumn, expirationDataGridViewTextBoxColumn });
            dataGridView1.DataSource = coffeeBindingSource;
            dataGridView1.Location = new Point(12, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(943, 176);
            dataGridView1.TabIndex = 0;
            // 
            // isDecafDataGridViewCheckBoxColumn
            // 
            isDecafDataGridViewCheckBoxColumn.DataPropertyName = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.HeaderText = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.Name = "isDecafDataGridViewCheckBoxColumn";
            // 
            // varietyDataGridViewTextBoxColumn
            // 
            varietyDataGridViewTextBoxColumn.DataPropertyName = "Variety";
            varietyDataGridViewTextBoxColumn.HeaderText = "Variety";
            varietyDataGridViewTextBoxColumn.Name = "varietyDataGridViewTextBoxColumn";
            // 
            // roastyDataGridViewTextBoxColumn
            // 
            roastyDataGridViewTextBoxColumn.DataPropertyName = "Roasty";
            roastyDataGridViewTextBoxColumn.HeaderText = "Roasty";
            roastyDataGridViewTextBoxColumn.Name = "roastyDataGridViewTextBoxColumn";
            // 
            // bevNameDataGridViewTextBoxColumn
            // 
            bevNameDataGridViewTextBoxColumn.DataPropertyName = "BevName";
            bevNameDataGridViewTextBoxColumn.HeaderText = "BevName";
            bevNameDataGridViewTextBoxColumn.Name = "bevNameDataGridViewTextBoxColumn";
            // 
            // temperaturedegFDataGridViewTextBoxColumn
            // 
            temperaturedegFDataGridViewTextBoxColumn.DataPropertyName = "TemperaturedegF";
            temperaturedegFDataGridViewTextBoxColumn.HeaderText = "TemperaturedegF";
            temperaturedegFDataGridViewTextBoxColumn.Name = "temperaturedegFDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // packageTypeDataGridViewTextBoxColumn
            // 
            packageTypeDataGridViewTextBoxColumn.DataPropertyName = "PackageType";
            packageTypeDataGridViewTextBoxColumn.HeaderText = "PackageType";
            packageTypeDataGridViewTextBoxColumn.Name = "packageTypeDataGridViewTextBoxColumn";
            // 
            // sizeOzDataGridViewTextBoxColumn
            // 
            sizeOzDataGridViewTextBoxColumn.DataPropertyName = "SizeOz";
            sizeOzDataGridViewTextBoxColumn.HeaderText = "SizeOz";
            sizeOzDataGridViewTextBoxColumn.Name = "sizeOzDataGridViewTextBoxColumn";
            // 
            // expirationDataGridViewTextBoxColumn
            // 
            expirationDataGridViewTextBoxColumn.DataPropertyName = "Expiration";
            expirationDataGridViewTextBoxColumn.HeaderText = "Expiration";
            expirationDataGridViewTextBoxColumn.Name = "expirationDataGridViewTextBoxColumn";
            // 
            // coffeeBindingSource
            // 
            coffeeBindingSource.DataSource = typeof(Coffee);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn isDecafDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn varietyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roastyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bevNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn temperaturedegFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packageTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeOzDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationDataGridViewTextBoxColumn;
        private BindingSource coffeeBindingSource;
    }
}
