using System;
using System.Linq;
using System.Windows.Forms;

namespace LZ2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Тык
            Button calculateButton = new Button
            {
                Text = "Вычислить",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(100, 30)
            };
            calculateButton.Click += CalculateButton_Click;

            // ListBox
            ListBox resultListBox = new ListBox
            {
                Name = "ResultListBox",
                Location = new System.Drawing.Point(20, 60),
                Size = new System.Drawing.Size(300, 200)
            };
            this.Controls.Add(calculateButton);
            this.Controls.Add(resultListBox);
            this.Size = new System.Drawing.Size(400, 300);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Массив
            double[] F = new double[18];
            Random random = new Random();
            for (int i = 0; i < F.Length; i++)
            {
                F[i] = random.NextDouble() * 20 - 10;
            }

            double[] P = F.Select(f => 0.13 * Math.Pow(f, 3) - 2.5 * f + 8).ToArray();

            var negativeElements = P.Where(p => p < 0).ToArray();

            var resultListBox = this.Controls.Find("ResultListBox", true).FirstOrDefault() as ListBox;
            if (resultListBox != null)
            {
                resultListBox.Items.Clear();
                resultListBox.Items.Add("Отрицательные элементы массива P:");
                foreach (var p in negativeElements)
                {
                    resultListBox.Items.Add(p.ToString("F2"));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f1 = new Main();
            f1.ShowDialog();
        }
    }
}
