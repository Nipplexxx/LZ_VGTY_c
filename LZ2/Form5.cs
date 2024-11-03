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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            panelMain.BackColor = Color.LightBlue;

            panelMain.Click += PanelMain_Click;
            this.Click += Form1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f1 = new Main();
            f1.ShowDialog();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelMain_Click(object sender, EventArgs e)
        {
            Button newButton = new Button
            {
                Text = "Button",
                Width = 80,
                Height = 30,
                Location = new Point(10, 10 + panelMain.Controls.Count * 35)
            };

            panelMain.Controls.Add(newButton);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            TextBox newTextBox = new TextBox
            {
                Width = 100,
                Location = new Point(10, 10 + this.Controls.OfType<TextBox>().Count() * 30)
            };

            this.Controls.Add(newTextBox);
        }
    }
}
