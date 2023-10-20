namespace Practica_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A;

            A = int.Parse(valor.Text);

            if (A % 2 == 0)
            {
                MessageBox.Show("EL NÚMERO ES PAR");
            }

            else
            {
                if (A % 3 == 0)
                {
                    MessageBox.Show("EL NUMERO ES IMPAR Y ES DIVISIBLE POR 3");
                }

                else
                {
                    MessageBox.Show("EL NÚMERO ES IMPAR Y NO ES DIVISIBLE POR 3");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor.Text = " ";
        }
    }
}