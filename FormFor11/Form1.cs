namespace FormFor11
{
    public partial class Form1 : Form
    {
        private int Cycle(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1, i) * Math.Pow(i, 3);
            }
            return (int)sum;
        }
        private int Formula(int n)
        {
            double sign = Math.Pow(-1, n);
            double sum = ((1.0 / 8) * (1 - sign * (1 - 6 * Math.Pow(n, 2) - 4 * Math.Pow(n, 3))));
            return (int)sum;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Text1 = Convert.ToInt32(textBox1.Text);
                int result = Cycle(Text1);
                MessageBox.Show(Convert.ToString(result));
            }
            catch (FormatException)
            {
                MessageBox.Show("Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Text2 = Convert.ToInt32(textBox1.Text);
                int result1 = Formula(Text2);
                MessageBox.Show(Convert.ToString(result1));
            }
            catch (FormatException)
            {
                MessageBox.Show("Error");
            }
        }

    }
}