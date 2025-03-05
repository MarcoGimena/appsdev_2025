namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fnameValue = Firstname.Text;
            String mnameValue = Middlename.Text;
            String lnameValue = Lastname.Text;
            String SnameValue = Suffix.Text;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to submit?",
                    "confirm Submission",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Hello There! {fnameValue} {mnameValue} {lnameValue} {SnameValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Submission Canceled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
