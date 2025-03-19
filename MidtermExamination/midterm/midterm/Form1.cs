namespace midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.AddRange(new string[]
            {
                "iPhone 16 Pro Max (256GB)",
                "iPhone 16 Pro (128GB)",
                "iPhone 16 Plus (128GB)",
                "iPhone 16 (128GB)",
                "iPhone 16e (128GB)"
            });

            checkedListBox1.Items.AddRange(new string[]
            {
                "Apple Care Plus",
                "USB-C Charging Adapter",
                "MagSafe Charger (1M)"
            });

            comboBox1.Items.AddRange(new string[]
            {
                "12 Months",
                "24 Months",
                "30 Months",
                "36 Months"
            });
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
