namespace sport_complex
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
            this.Зайти = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Зареєструватися = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Зайти
            // 
            this.Зайти.Location = new System.Drawing.Point(188, 189);
            this.Зайти.Name = "Зайти";
            this.Зайти.Size = new System.Drawing.Size(75, 23);
            this.Зайти.TabIndex = 0;
            this.Зайти.Text = "Зайти";
            this.Зайти.UseVisualStyleBackColor = true;
            this.Зайти.Click += new System.EventHandler(this.Зайти_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Логін";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Пароль";
            // 
            // Зареєструватися
            // 
            this.Зареєструватися.Location = new System.Drawing.Point(176, 227);
            this.Зареєструватися.Name = "Зареєструватися";
            this.Зареєструватися.Size = new System.Drawing.Size(110, 23);
            this.Зареєструватися.TabIndex = 3;
            this.Зареєструватися.Text = "Зареєструватися";
            this.Зареєструватися.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 305);
            this.Controls.Add(this.Зареєструватися);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Зайти);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Зайти;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Зареєструватися;
    }
}

