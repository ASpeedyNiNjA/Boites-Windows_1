namespace Boites_Windows_1
{
    public partial class Boites : Form
    {
        public Boites()
        {
            InitializeComponent();
        }

        private void teeth1_d1_Click(object sender, EventArgs e)
        {
            //Murach C# 8th Edition Book
            Form teethModule = new Teeth();
            teethModule.ShowDialog();
        }

        private void coffee1_d1_Click(object sender, EventArgs e)
        {
            Form coffeeModule = new Coffee();
            coffeeModule.ShowDialog();
        }

        private void tv_d1_Click(object sender, EventArgs e)
        {
            Form TVModule = new TV();
            TVModule.ShowDialog();
        }

        private void book_d1_Click(object sender, EventArgs e)
        {
            Form BookModule = new Book();
            BookModule.ShowDialog();
        }

        private void sleep_d1_Click(object sender, EventArgs e)
        {
            Form SleepModule = new Sleep();
            SleepModule.ShowDialog();
        }

        private void movie_d1_Click(object sender, EventArgs e)
        {
            Form MovieModule = new Movie();
            MovieModule.ShowDialog();
        }

        private void music_d1_Click(object sender, EventArgs e)
        {
            Form MusicModule = new Music();
            MusicModule.ShowDialog();
        }
    }
}
