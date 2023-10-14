namespace taxcal
{
    public partial class Form1 : Form
    {
        public double tax;
        public Form1()
        {
            InitializeComponent();
        }


        private async void butselect_Click(object sender, EventArgs e)
        {
            
            if (cbxtax.Text == "Salary")
            {
            
            await taxcalu.taxcaluation(Convert.ToDouble(txbamout.Text), Convert.ToDouble(txbamout2.Text));

        }else if(cbxtax.Text == "hourly")
            {

            }
            else if (cbxtax.Text == "bussiness")
            {

            }
            else
            {
              await taxcalu.taxcaluation(Convert.ToDouble(txbamout.Text), Convert.ToDouble(txbamout2.Text));
            }

        }
    }
}