using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework;

namespace sport_complex
{
    public partial class account : MetroForm
    {
        public account()
        {
            InitializeComponent();
 SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RLDAVIH;Initial Catalog=usersdb;Integrated Security=True");

        con.Open();

            string currlog = System.IO.File.ReadAllText(@"D:\arya\sport_complex\sport_complex\sport_complex\userdata.txt");
            //считываю логин с текстового файла чтобы по нему найти пользователя
            Console.WriteLine(currlog);
           
        string query = "select * from DB_LOG where USER_LOGIN = '" + currlog.ToString() + "';";
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataReader dr = cmd.ExecuteReader();
         if (dr.Read())
    {
         
        textBox2.Text = (dr["username"].ToString());
        textBox1.Text = (dr["user_login"].ToString());
            
                textBox3.Text = (dr["telephone"].ToString());
                textBox4.Text = (dr["age"].ToString());
    }
    con.Close();
        }

     

        private void account_Load(object sender, EventArgs e)
        {
  
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
