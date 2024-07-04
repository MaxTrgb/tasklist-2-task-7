namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            double num = (int)numericUpDown1.Value;
            int power = (int)numericUpDown2.Value;
            double result = await calculatePowerAsync(num, power);
            label3.Text = result.ToString();
        }

        private Task<double> calculatePowerAsync(double num, int power)
        {
            return Task.Run(() => calculatePower(num, power));
        }
        private double calculatePower(double num, int power) 
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
