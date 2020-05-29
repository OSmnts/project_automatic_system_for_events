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
using MetroFramework.Forms;

namespace sport_complex
{
    public partial class EventRegistration : MetroForm
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TLFS8I;Initial Catalog=USERSDB;Integrated Security=True");

        public EventRegistration()
        {
            InitializeComponent();



            try
            {

                con.Open();
                string currEv = System.IO.File.ReadAllText(@"C:\Users\arina\Source\Repos\comradearya\project_automatic_system_for_events\sport_complex\currentEvent.txt");
                

                string selectQuery = "SELECT Members FROM event where name="+ currEv.ToString()+";";

                DataTable table = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter(selectQuery, con);
                SDA.Fill(table);
                dataGridView1.DataSource = table;

                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception )
            {

            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TLFS8I;Initial Catalog=USERSDB;Integrated Security=True");
            try
            {
                con.Open();
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                string caption = "";
                string message = "Бажаєте зареєструватися?";
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Ви зареєструвались на вибрану подію!");
                    //считывание его лога

                    string currlog = System.IO.File.ReadAllText(@"C:\Users\arina\Source\Repos\comradearya\project_automatic_system_for_events\sport_complex\userdata.txt");
                    string currEv = System.IO.File.ReadAllText(@"C:\Users\arina\Source\Repos\comradearya\project_automatic_system_for_events\sport_complex\currEv.txt");

                    //считываю логин с текстового файла чтобы по нему найти пользователя
                    Console.WriteLine(currlog);

                    string query = "SELECT * FROM db_log WHERE login_name = '" + currlog.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    string currUser;
                    if (dr.Read())
                    {

                        currUser = (dr["username"].ToString());
                        string insertMemQuery = "insert into event(Members) value '(" + currUser.ToString() + "') WHERE name = '" + currEv.ToString() + "';";
                        SqlCommand cmd2 = new SqlCommand(insertMemQuery, con);
                    }
                    //найден пользователь. добавляю в бд ивента


                   
                    //   SqlDataReader dr2 = cmd2.ExecuteReader();
                }
                con.Close();
            }
            catch
            {

            }
        }

        private void updateButtun_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TLFS8I;Initial Catalog=USERSDB;Integrated Security=True");
            try
            {
                con.Open();
                string selectQuery = "SELECT MEMBERS FROM event";
                DataTable table = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter(selectQuery, con);
                SDA.Fill(table);
                dataGridView1.DataSource = table;

                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
