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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.Зареєструватися = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Зайти
            // 
            this.Зайти.Location = new System.Drawing.Point(117, 161);
            this.Зайти.Name = "Зайти";
            this.Зайти.Size = new System.Drawing.Size(75, 23);
            this.Зайти.TabIndex = 0;
            this.Зайти.Text = "Зайти";
            this.Зайти.UseVisualStyleBackColor = true;
            this.Зайти.Click += new System.EventHandler(this.Зайти_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(105, 68);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(108, 118);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(97, 20);
            this.textBox_password.TabIndex = 2;
            // 
            // Зареєструватися
            // 
            this.Зареєструватися.Location = new System.Drawing.Point(95, 203);
            this.Зареєструватися.Name = "Зареєструватися";
            this.Зареєструватися.Size = new System.Drawing.Size(123, 25);
            this.Зареєструватися.TabIndex = 3;
            this.Зареєструватися.Text = "Зареєструватися";
            this.Зареєструватися.UseVisualStyleBackColor = true;
            this.Зареєструватися.Click += new System.EventHandler(this.Зареєструватися_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(70, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(50, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(306, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Зареєструватися);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.Зайти);
            this.Name = "Form1";
            this.Text = "Вхід";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Зайти;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button Зареєструватися;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

