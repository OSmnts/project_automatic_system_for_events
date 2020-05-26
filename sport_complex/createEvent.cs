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


namespace sport_complex
{
    public partial class createEvent : Form
    {
        public createEvent()
        {
            InitializeComponent();
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TLFS8I;Initial Catalog=USERSDB;Integrated Security=True");
                con.Open();
               
                if (textBox1.Text != String.Empty && textBox2.Text != String.Empty) // check if there are text inside textboxes
                {

                    string query = "INSERT INTO event(name,date,price,maxnumber) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();

                    string caption = "Ваша подія додана до реєстру.";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string message = "Бажаєте додати ще?";
                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        // пользователь хочет добавить еще одно мероприятие -- очистить все поля
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();

                    }
                    else
                    {
                       
                        Form2 form2Update = new Form2();
                        form2Update.Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Ви залишили пустими обов'язкові поля!");
                
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void createEvent_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
