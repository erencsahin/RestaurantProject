namespace restaurantProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.ShowDialog();
            this.Close();
        }

        private void restButton_Click(object sender, EventArgs e)
        {
            RestaurantForm islemler = new RestaurantForm();
            islemler.ShowDialog();
            this.Close();
        }
    }
}