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
 
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RLDAVIH;Initial Catalog=usersdb;Integrated Security=True");

        
        
       

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

       /*       string[] lines = System.IO.File.ReadAllLines(@"D:\arya\sport_complex\sport_complex\sport_complex\userdata_log.txt");
            List<string> Source = new List<string>();
            foreach (string line in lines)
            {
                Source.Add(line);
            }
          for (int i = 0; i < Source.Count; i++) 
            {
               
                if (Source[i] != formData[i])
                {
                    MessageBox.Show("Такого користувача не існує. Перевірте правильність логіну та паролю.");
                    this.ResetText();
                }
           }

 */
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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RLDAVIH;Initial Catalog=usersdb;Integrated Security=True");

            con.Open();
            string selectQuery = "SELECT * FROM event";
            DataTable table = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(selectQuery, con);
            SDA.Fill(table);
            dataGridView1.DataSource = table;

            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

        }
        //вібор ивента
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
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
                    // пользователь хочет зарегистрироваться
                    //запись лога в файл для последующего извлечения в бд таблицу пользователя

                }

            }
        }
    }
}
