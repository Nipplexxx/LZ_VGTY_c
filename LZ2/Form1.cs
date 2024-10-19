using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LZ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void X_tB_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Y_tB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Z_tB_TextChanged(object sender, EventArgs e)
        {

        }

        private void bRezult_Click(object sender, EventArgs e)
        {
            double x = double.Parse(X_tB.Text);
            double y = double.Parse(Y_tB.Text);
            double z = double.Parse(Z_tB.Text);
            Rezult_label.Text += Environment.NewLine + "Значение X = " + x.ToString();
            Rezult_label.Text += Environment.NewLine + "Значение Y = " + y.ToString();
            Rezult_label.Text += Environment.NewLine + "Значение Z = " + z.ToString();
            double resultV = CalculateV(x, y, z);
            Rezult_label.Text += Environment.NewLine + "Результат V = " + resultV.ToString();
        }

        //Мега вычисления
        private static double CalculateV(double x, double y, double z)
        {
            double sinPart = Math.Sin(x + y);
            double numerator = 1 + Math.Pow(sinPart, 2);
            double denominator = Math.Abs(x - (2 * y) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2)));
            if (denominator == 0)
            {
                throw new DivideByZeroException("Знаменатель равен нулю, проверьте введенные значения x и y.");
            }

            double xPowerY = Math.Pow(x, Math.Abs(y));

            double arctgPart = Math.Atan(1 / z);
            double cosPart = Math.Pow(Math.Cos(arctgPart), 2);

            return (numerator / denominator) * xPowerY + cosPart;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
