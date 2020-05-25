using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace sport_complex
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Зайти_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text != "" &&textBox_password.Text != "" )
            {
               
                    
                        try
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RLDAVIH;Initial Catalog=usersdb;Integrated Security=True");

                            con.Open();


                            string query = "select * from DB_LOG where USER_LOGIN = '" + textBox_login.Text + "';";
                            SqlCommand cmd = new SqlCommand(query, con);
                        
                            SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
              //пользователь существует, проверка пароля
                                if (textBox_password.Text.ToString() != (dr["password"].ToString()))
                                {
                                    MessageBox.Show("Invalid password.");
                                }
                        //пользователь существует, проверка пароля успешная
                        else
                        {
                            //запись в файл для вывода информации

                            string log = textBox_login.Text;
                            

                            System.IO.File.WriteAllText(@"D:\arya\sport_complex\sport_complex\sport_complex\userdata.txt", log);
                            

                            Form2 form2 = new Form2();
                            form2.StartPosition = FormStartPosition.CenterParent;
                            form2.ShowDialog();
                             Hide();
                        }

                    }
                        else
                        {
                            MessageBox.Show("Такого користувача не існує.");
                        }
                            con.Close();




                     
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        //  Application.Exit();
                    }
                
            
            else
            {
                MessageBox.Show("Введіть логін та пароль для входу.");
            }
               

            
        }

        private void Зареєструватися_Click(object sender, EventArgs e)
        {
            Form3 register = new sport_complex.Form3();
            register.StartPosition = FormStartPosition.CenterParent;
            register.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
