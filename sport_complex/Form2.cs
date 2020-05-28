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
    public partial class Form2 : MetroForm
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }


       /* public void CollectUsers()
        {
            List<userClass> users = new List<userClass>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=DESKTOP-9TLFS8I;Initial Catalog=USERSDB;Integrated Security=True";
                conn.Open();

                using (SqlCommand myQuery = new SqlCommand("SELECT * FROM DB_LOG);", conn))
                using (SqlDataReader myReader = myQuery.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        var user = new userClass();

                        user.login_name = myReader["login_name"].ToString();
                        user.password = myReader["password"].ToString();
                        user.age = (int)myReader["age"];
                        user.special_user = (int)myReader["special_user"];
                        user.telephone = (int)myReader["telephone"];

                        users.Add(user);


                    }
                }

            }
        }

    */

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TLFS8I;Initial Catalog=USERSDB;Integrated Security=True");

        
        
       

        private void Form2_Load(object sender, EventArgs e)
        {
      con.Open();
            
        string selectQuery = "SELECT * FROM event";
            DataTable table = new DataTable();
        SqlDataAdapter SDA = new SqlDataAdapter(selectQuery, con);
            SDA.Fill(table);
            dataGridView1.DataSource = table;

            SDA.SelectCommand.ExecuteNonQuery();
             con.Close();
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_createEvent_Click(object sender, EventArgs e)
        {
            //check if this user has privelegue 
            try
            {
                string currlog = System.IO.File.ReadAllText(@"C:\Users\arina\Source\Repos\comradearya\project_automatic_system_for_events\sport_complex\userdata.txt");
                //считываю логин с ткст


                con.Open();
                string query = "SELECT * FROM DB_LOG WHERE login_name ='"+currlog.ToString()+"';";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                }
                
            }
                   
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
      
            createEvent cEvent = new createEvent();
           
            cEvent.ShowDialog();
     

        }

        private void button_cabinet_Click(object sender, EventArgs e)
        {
             account accountForm = new account();
             accountForm.ShowDialog();

           
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TLFS8I;Initial Catalog=USERSDB;Integrated Security=True");
            try
            {
            con.Open();
            string selectQuery = "SELECT * FROM event";
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
        //вібор ивента
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value != null)// || string.IsNullOrWhiteSpace(cell.Value.ToString()))
               // if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                dataGridView1.CurrentRow.Selected = true;
                string caption = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                string message = "Бажаєте зареєструватися?";
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Ви зареєструвались на вибрану подію!");
                    // пользователь хочет зарегистрироваться
                    //запись лога в файл для последующего извлечения в бд таблицу пользователя

                }

            }

            else
            {
                MessageBox.Show("Реєстрація не доступна.");
            }
        }
    }
}
