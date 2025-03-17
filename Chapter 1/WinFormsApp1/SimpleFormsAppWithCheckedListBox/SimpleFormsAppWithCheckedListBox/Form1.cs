using System.Windows.Forms;

namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            String[] movie = { "Deadpool", "Deadpool2", "BladeRunner2049", "Lord Of the rings", "Game of Thrones", "The Gray Man", "Harry Potter", "47Ronin", "Halo" };
            this.movies.Items.AddRange(movie);

            this.movies.CheckOnClick = true;
        }

        private void movie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var movie in movies.Items)
            {
                bool isSelected = movies.GetItemChecked(movies.Items.IndexOf(movie));
                if (isSelected && !listBox1.Items.Contains(movie))
                {
                    listBox1.Items.Add(movie);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                listBox1.Items.Remove(listBox1.SelectedItem);  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
