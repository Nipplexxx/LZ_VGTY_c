using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LZ2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f1 = new Main();
            f1.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnCountPunctuation_Click_1(object sender, EventArgs e)
        {
            if (listBoxStrings.SelectedItem != null)
            {
                string selectedText = listBoxStrings.SelectedItem.ToString();

                int punctuationCount = selectedText.Count(char.IsPunctuation);

                lblResult.Text = $"Количество знаков препинания: {punctuationCount}";
            }
            else
            {
                lblResult.Text = "Пожалуйста, выберите строку.";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
