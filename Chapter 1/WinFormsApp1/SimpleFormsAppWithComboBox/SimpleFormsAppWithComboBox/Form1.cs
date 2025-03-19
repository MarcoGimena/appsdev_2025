namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            {
                string[] cuisineGenre = { "Filipino", "Chinese", "American", "Mexican" };
                comboBox1.Items.AddRange(cuisineGenre);

                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.SelectedIndex = 0;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filipinoCuisineList = { "Adobo", "Sinigang", "Lechon", "Pancit" };
            string[] chineseCuisinelist = { "Huaiyang", "Shandong", "Sichuan", "Cantonese" };
            string[] americanCuisineList = { " Fried Chicken", "Grilled Cheese", "Cheeseburger", "Steak And Fries" };
            string[] mexicanCuisineList = { "tacos", "chimichangas", "pozole", "ceviche" };

            checkedListBox1.Items.Clear();

            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString()!.Contains("Filipino"))
            {
                checkedListBox1.Items.AddRange(filipinoCuisineList);

            }
            else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString()!.Contains("Chinese"))
            {
                checkedListBox1.Items.AddRange(chineseCuisinelist);
            }
            else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString()!.Contains("American"))
            {
                checkedListBox1.Items.AddRange(americanCuisineList);

            }
            else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString()!.Contains("Mexican"))
            {
                checkedListBox1.Items.AddRange(mexicanCuisineList);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item));
                if (isSelected && !listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1 && listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}

