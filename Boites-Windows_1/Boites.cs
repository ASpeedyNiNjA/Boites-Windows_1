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
    }
}
