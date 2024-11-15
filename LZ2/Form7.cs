using System;
using System.Linq;
using System.Windows.Forms;

namespace LZ2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Добавляем кнопку для выполнения задачи
            Button calculateButton = new Button
            {
                Text = "Вычислить",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(100, 30)
            };
            calculateButton.Click += CalculateButton_Click;

            // Добавляем ListBox для отображения результатов
            ListBox resultListBox = new ListBox
            {
                Name = "ResultListBox",
                Location = new System.Drawing.Point(20, 60),
                Size = new System.Drawing.Size(400, 300)
            };

            // Добавляем элементы на форму
            this.Controls.Add(calculateButton);
            this.Controls.Add(resultListBox);
            this.Text = "Преобразование матрицы";
            this.Size = new System.Drawing.Size(500, 400);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Создаем матрицу B (10x10)
            double[,] B = new double[10, 10];
            Random random = new Random();

            // Заполняем матрицу случайными числами от -10 до 10
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    B[i, j] = random.NextDouble() * 20 - 10;
                }
            }

            // Вычисляем сумму S элементов главной диагонали
            double S = 0;
            for (int i = 0; i < 10; i++)
            {
                S += B[i, i];
            }

            // Преобразуем матрицу на основе значения S
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (S > 10)
                    {
                        B[i, j] += 13.5;
                    }
                    else
                    {
                        B[i, j] = Math.Pow(B[i, j], 2) - 1.5;
                    }
                }
            }

            // Отображаем результаты
            var resultListBox = this.Controls.Find("ResultListBox", true).FirstOrDefault() as ListBox;
            if (resultListBox != null)
            {
                resultListBox.Items.Clear();
                resultListBox.Items.Add($"Сумма элементов главной диагонали (S): {S:F2}");
                resultListBox.Items.Add("Преобразованная матрица:");

                for (int i = 0; i < 10; i++)
                {
                    string row = string.Join(" ", Enumerable.Range(0, 10).Select(j => B[i, j].ToString("F2")));
                    resultListBox.Items.Add(row);
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
