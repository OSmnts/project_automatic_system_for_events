namespace sport_complex
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_telephone = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.textbox_userlogin = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.checkBox_spuser = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПІБ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Телефон";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вік";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(217, 271);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(390, 20);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_telephone
            // 
            this.textBox_telephone.Location = new System.Drawing.Point(217, 327);
            this.textBox_telephone.Name = "textBox_telephone";
            this.textBox_telephone.Size = new System.Drawing.Size(390, 20);
            this.textBox_telephone.TabIndex = 6;
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(217, 204);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(390, 20);
            this.textbox_password.TabIndex = 9;
            // 
            // textbox_userlogin
            // 
            this.textbox_userlogin.Location = new System.Drawing.Point(217, 139);
            this.textbox_userlogin.Name = "textbox_userlogin";
            this.textbox_userlogin.Size = new System.Drawing.Size(390, 20);
            this.textbox_userlogin.TabIndex = 10;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(51, 139);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(34, 13);
            this.login.TabIndex = 11;
            this.login.Text = "Логін";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Пароль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(217, 398);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(390, 20);
            this.textBox_age.TabIndex = 8;
            this.textBox_age.TextChanged += new System.EventHandler(this.textBox_age_TextChanged);
            // 
            // checkBox_spuser
            // 
            this.checkBox_spuser.AutoSize = true;
            this.checkBox_spuser.Location = new System.Drawing.Point(54, 461);
            this.checkBox_spuser.Name = "checkBox_spuser";
            this.checkBox_spuser.Size = new System.Drawing.Size(118, 17);
            this.checkBox_spuser.TabIndex = 15;
            this.checkBox_spuser.Text = "Хочу додати подію\r\n";
            this.checkBox_spuser.UseVisualStyleBackColor = true;
            this.checkBox_spuser.CheckedChanged += new System.EventHandler(this.checkBox_spuser_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 581);
            this.Controls.Add(this.checkBox_spuser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textbox_userlogin);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_telephone);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Реєстрація";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_name;
        public System.Windows.Forms.TextBox textBox_telephone;
        public System.Windows.Forms.TextBox textbox_password;
        public System.Windows.Forms.TextBox textbox_userlogin;
        public System.Windows.Forms.Label login;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox_age;
        public System.Windows.Forms.CheckBox checkBox_spuser;
    }
}