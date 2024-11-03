namespace LZ2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonSinh = new System.Windows.Forms.RadioButton();
            this.radioButtonX2 = new System.Windows.Forms.RadioButton();
            this.radioButtonExp = new System.Windows.Forms.RadioButton();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(697, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonSinh
            // 
            this.radioButtonSinh.AutoSize = true;
            this.radioButtonSinh.Location = new System.Drawing.Point(12, 12);
            this.radioButtonSinh.Name = "radioButtonSinh";
            this.radioButtonSinh.Size = new System.Drawing.Size(50, 17);
            this.radioButtonSinh.TabIndex = 12;
            this.radioButtonSinh.TabStop = true;
            this.radioButtonSinh.Text = "sin(h)";
            this.radioButtonSinh.UseVisualStyleBackColor = true;
            // 
            // radioButtonX2
            // 
            this.radioButtonX2.AutoSize = true;
            this.radioButtonX2.Location = new System.Drawing.Point(68, 12);
            this.radioButtonX2.Name = "radioButtonX2";
            this.radioButtonX2.Size = new System.Drawing.Size(42, 17);
            this.radioButtonX2.TabIndex = 13;
            this.radioButtonX2.TabStop = true;
            this.radioButtonX2.Text = "x^2";
            this.radioButtonX2.UseVisualStyleBackColor = true;
            // 
            // radioButtonExp
            // 
            this.radioButtonExp.AutoSize = true;
            this.radioButtonExp.Location = new System.Drawing.Point(116, 12);
            this.radioButtonExp.Name = "radioButtonExp";
            this.radioButtonExp.Size = new System.Drawing.Size(42, 17);
            this.radioButtonExp.TabIndex = 14;
            this.radioButtonExp.TabStop = true;
            this.radioButtonExp.Text = "e^x";
            this.radioButtonExp.UseVisualStyleBackColor = true;
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxX.Location = new System.Drawing.Point(12, 35);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 15;
            this.textBoxX.Text = "Значение X";
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxY.Location = new System.Drawing.Point(12, 61);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 16;
            this.textBoxY.Text = "Значение Y";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCalculate.Location = new System.Drawing.Point(12, 87);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 17;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click_1);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(93, 92);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 18;
            this.labelResult.Text = "Результат";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 128);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.radioButtonExp);
            this.Controls.Add(this.radioButtonX2);
            this.Controls.Add(this.radioButtonSinh);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form2";
            this.Opacity = 0.95D;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Л.Р. 3";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonSinh;
        private System.Windows.Forms.RadioButton radioButtonX2;
        private System.Windows.Forms.RadioButton radioButtonExp;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}