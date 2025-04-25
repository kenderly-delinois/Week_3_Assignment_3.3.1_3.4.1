namespace Week_3_Assignment_3._3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstNames.Items.Remove(lstNames.SelectedItem);
                
        }
    }
}
