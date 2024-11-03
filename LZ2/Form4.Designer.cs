namespace LZ2
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCountPunctuation = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.listBoxStrings = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(697, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCountPunctuation
            // 
            this.btnCountPunctuation.Location = new System.Drawing.Point(12, 113);
            this.btnCountPunctuation.Name = "btnCountPunctuation";
            this.btnCountPunctuation.Size = new System.Drawing.Size(75, 23);
            this.btnCountPunctuation.TabIndex = 13;
            this.btnCountPunctuation.Text = "Жмяк!";
            this.btnCountPunctuation.UseVisualStyleBackColor = true;
            this.btnCountPunctuation.Click += new System.EventHandler(this.btnCountPunctuation_Click_1);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 139);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 13);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "Результат";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // listBoxStrings
            // 
            this.listBoxStrings.FormattingEnabled = true;
            this.listBoxStrings.Items.AddRange(new object[] {
            "Во всех заданиях исходные данные вводить с помощью ListBox. ",
            "Строки вводятся на этапе проектирования формы, используя окно свойств. Вывод резу" +
                "льтата организовать в метку Label.",
            "3 Вариант. Найти количество знаков препинания в исходной строке."});
            this.listBoxStrings.Location = new System.Drawing.Point(12, 12);
            this.listBoxStrings.Name = "listBoxStrings";
            this.listBoxStrings.Size = new System.Drawing.Size(760, 95);
            this.listBoxStrings.TabIndex = 16;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.listBoxStrings);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCountPunctuation);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Л.Р. 6";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCountPunctuation;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox listBoxStrings;
    }
}