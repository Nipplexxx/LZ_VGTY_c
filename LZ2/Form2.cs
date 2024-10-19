using System;
using System.Windows.Forms;

namespace LZ2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private double CalculateF(double x)
        {
            if (radioButtonSinh.Checked)
                return Math.Sinh(x); // sh(x)
            else if (radioButtonX2.Checked)
                return Math.Pow(x, 2); // x^2
            else if (radioButtonExp.Checked)
                return Math.Exp(x); // e^x
            else
                throw new Exception("Не выбрана функция f(x)");
        }

        private double CalculateC(double x, double y)
        {
            double f_x = CalculateF(x);

            if (x - y == 0)
            {
                return Math.Pow(f_x, 2) + Math.Pow(y, 2) + Math.Sin(y);
            }
            else if (x - y > 0)
            {
                return Math.Pow(f_x - y, 2) + Math.Cos(y);
            }
            else
            {
                return Math.Pow(y - f_x, 2) + Math.Tan(y);
            }
        }

        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBoxX.Text);
                double y = Convert.ToDouble(textBoxY.Text);

                double c = CalculateC(x, y);

                labelResult.Text = $"Результат: c = {c:F4}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}