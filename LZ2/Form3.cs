using System;
using System.Windows.Forms;

namespace LZ2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
        private double CalculateY(double x, double a, double b)
        {
            // Формула y(x) = 10^-1 * a * x^3 * tan(a - bx)
            return 0.1 * a * Math.Pow(x, 3) * Math.Tan(a - b * x);
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Очищаем старые результаты
            listBoxResults.Items.Clear();

            try
            {
                // Чтение входных данных
                double x0 = Convert.ToDouble(textBoxX0.Text); // начальное значение x
                double xk = Convert.ToDouble(textBoxXk.Text); // конечное значение x
                double dx = Convert.ToDouble(textBoxDx.Text); // шаг изменения x
                double a = Convert.ToDouble(textBoxA.Text);   // значение параметра a
                double b = Convert.ToDouble(textBoxB.Text);   // значение параметра b

                // Цикл для табулирования функции
                for (double x = x0; x <= xk; x += dx)
                {
                    double y = CalculateY(x, a, b);
                    // Добавляем результат в список
                    listBoxResults.Items.Add($"x = {x:F2}, y = {y:F4}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}