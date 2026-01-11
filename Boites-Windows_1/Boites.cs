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

        private void videoGame_d1_Click(object sender, EventArgs e)
        {
            Form VideoGameModule = new VideoGame();
            VideoGameModule.ShowDialog();
        }

        private void water_d1_Click(object sender, EventArgs e)
        {
            Form WaterModule = new Water();
            WaterModule.ShowDialog();
        }

        private void breakfast_d1_Click(object sender, EventArgs e)
        {
            Form FoodModule = new Food();
            FoodModule.ShowDialog();
        }

        private void lunch_d1_Click(object sender, EventArgs e)
        {
            Form FoodModule = new Food();
            FoodModule.ShowDialog();
        }

        private void supper_d1_Click(object sender, EventArgs e)
        {
            Form FoodModule = new Food();
            FoodModule.ShowDialog();
        }

        private void snack_d1_Click(object sender, EventArgs e)
        {
            Form FoodModule = new Food();
            FoodModule.ShowDialog();
        }

        private void shower1_d1_Click(object sender, EventArgs e)
        {
            Form ShowerModule = new Shower();
            ShowerModule.ShowDialog();
        }

        private void shower2_d1_Click(object sender, EventArgs e)
        {
            Form ShowerModule = new Shower();
            ShowerModule.ShowDialog();
        }
    }
}
