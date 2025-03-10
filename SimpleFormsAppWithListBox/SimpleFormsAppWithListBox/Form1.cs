namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox.Text) && !lstbox.Items.Contains(txtbox.Text))
            {
                lstbox.Items.Add(txtbox.Text);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            lstbox.Items.Remove(txtbox.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            lstbox.Items.Clear();
        }
    }
}
