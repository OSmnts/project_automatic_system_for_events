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

    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TLFS8I;Initial Catalog=USERSDB;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\Users\arina\Source\Repos\comradearya\project_automatic_system_for_events\sport_complex\userdata.txt", String.Empty);

            // проверка на наличие пустых полей
            if (textbox_userlogin.Text != " " && textbox_password.Text != " " && textBox_name.Text != "")

            {

                try
                {

                    // проверка на уникальность логина - извлечение из бд данных
                    string uniqueLog = "select * from db_log where login_name = '" + textbox_userlogin.Text + "';";
                    SqlDataAdapter SDALog = new SqlDataAdapter(uniqueLog, con);
                    SDALog.SelectCommand.ExecuteNonQuery();
                    //



                    //проверка на уникальность логина
                    string query = "INSERT INTO db_log(login_name,password,username,telephone,age) VALUES ('" + textbox_userlogin.Text + "','" + textbox_password.Text + "','" + textBox_name.Text + "','" + textBox_telephone.Text + "','" + textBox_age.Text + "')";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();

                    if (checkBox_spuser.Checked == true)
                    {
                        string query1 = "INSERT INTO db_log(special_user) VALUES 1";
                        SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
                        SDA1.SelectCommand.ExecuteNonQuery();

                        string[] sp_user = { "special user" };
                        System.IO.File.WriteAllLines(@"C:\Users\arina\Source\Repos\comradearya\project_automatic_system_for_events\sport_complex\userdata.txt", sp_user);

                    }
                    else
                    {
                        string query2 = "INSERT INTO db_log(special_user) VALUES 2";
                        SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                        SDA2.SelectCommand.ExecuteNonQuery();
                    }
                    string lines = textbox_userlogin.Text.ToString();
                    System.IO.File.WriteAllText(@"C:\Users\arina\Source\Repos\comradearya\project_automatic_system_for_events\sport_complex\userdata.txt", lines);



                    MessageBox.Show("INSERTED SUCCESSFULLY");

                }
                catch (Exception)
                {


                }

                finally
                {
                    con.Close();
                    Form2 form2 = new Form2();
                    form2.StartPosition = FormStartPosition.CenterParent;
                    form2.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Введіть обовязкові поля.");

            }




        }

        private void CheckBox_spuser_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_spuser_CheckedChanged(object sender, EventArgs e)
        {

        }

 
    }
}
