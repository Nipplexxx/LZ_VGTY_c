namespace LZ2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btRezult = new System.Windows.Forms.Button();
            this.Y_tB = new System.Windows.Forms.TextBox();
            this.Z_tB = new System.Windows.Forms.TextBox();
            this.X_tB = new System.Windows.Forms.TextBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rezult_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRezult
            // 
            this.btRezult.BackColor = System.Drawing.Color.LightGray;
            this.btRezult.Location = new System.Drawing.Point(100, 113);
            this.btRezult.Name = "btRezult";
            this.btRezult.Size = new System.Drawing.Size(120, 25);
            this.btRezult.TabIndex = 0;
            this.btRezult.Text = "Вычислить";
            this.btRezult.UseVisualStyleBackColor = false;
            this.btRezult.Click += new System.EventHandler(this.bRezult_Click);
            // 
            // Y_tB
            // 
            this.Y_tB.BackColor = System.Drawing.SystemColors.Control;
            this.Y_tB.Location = new System.Drawing.Point(100, 51);
            this.Y_tB.Multiline = true;
            this.Y_tB.Name = "Y_tB";
            this.Y_tB.Size = new System.Drawing.Size(120, 25);
            this.Y_tB.TabIndex = 2;
            this.Y_tB.TextChanged += new System.EventHandler(this.Y_tB_TextChanged);
            // 
            // Z_tB
            // 
            this.Z_tB.BackColor = System.Drawing.SystemColors.Control;
            this.Z_tB.Location = new System.Drawing.Point(100, 82);
            this.Z_tB.Multiline = true;
            this.Z_tB.Name = "Z_tB";
            this.Z_tB.Size = new System.Drawing.Size(120, 25);
            this.Z_tB.TabIndex = 3;
            this.Z_tB.TextChanged += new System.EventHandler(this.Z_tB_TextChanged);
            // 
            // X_tB
            // 
            this.X_tB.BackColor = System.Drawing.SystemColors.Control;
            this.X_tB.Location = new System.Drawing.Point(100, 20);
            this.X_tB.Multiline = true;
            this.X_tB.Name = "X_tB";
            this.X_tB.Size = new System.Drawing.Size(120, 25);
            this.X_tB.TabIndex = 4;
            this.X_tB.TextChanged += new System.EventHandler(this.X_tB_TextChanged_1);
            // 
            // img1
            // 
            this.img1.Image = ((System.Drawing.Image)(resources.GetObject("img1.Image")));
            this.img1.InitialImage = null;
            this.img1.Location = new System.Drawing.Point(226, 20);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(468, 118);
            this.img1.TabIndex = 5;
            this.img1.TabStop = false;
            this.img1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите знач х:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите знач у:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите знач z:";
            // 
            // Rezult_label
            // 
            this.Rezult_label.Location = new System.Drawing.Point(226, 141);
            this.Rezult_label.Name = "Rezult_label";
            this.Rezult_label.Size = new System.Drawing.Size(468, 115);
            this.Rezult_label.TabIndex = 9;
            this.Rezult_label.Text = "Ответ";
            this.Rezult_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(697, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rezult_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.X_tB);
            this.Controls.Add(this.Z_tB);
            this.Controls.Add(this.Y_tB);
            this.Controls.Add(this.btRezult);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Л.Р. 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRezult;
        private System.Windows.Forms.TextBox Y_tB;
        private System.Windows.Forms.TextBox Z_tB;
        private System.Windows.Forms.TextBox X_tB;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Rezult_label;
        private System.Windows.Forms.Button button1;
    }
}

