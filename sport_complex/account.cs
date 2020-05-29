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
using System.Data.Linq;
using ClassLibrary;

namespace sport_complex
{
   
    public partial class account : MetroForm
    {
        static string connectionString = "@Data Source=DESKTOP-9TLFS8I;Initial Catalog=USERSDB;Integrated Security=True";

        public account()
        {
            InitializeComponent();
            ///trying to use LINQ for better connection with database
          //  DataContext db = new DataContext(connectionString);
          //  public System.Data.Linq.Table<TEntity> GetTable<TEntity>() where TEntity : class;
          //  Table<usersCl> users = db.GetTable<usersCl>();
         
            





            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9TLFS8I;Initial Catalog=USERSDB;Integrated Security=True");

                con.Open();

                string currlog = System.IO.File.ReadAllText(@"C:\Users\arina\Source\Repos\comradearya\project_automatic_system_for_events\sport_complex\userdata.txt");
                //считываю логин с текстового файла чтобы по нему найти пользователя
                Console.WriteLine(currlog);

                string query = "SELECT * FROM db_log WHERE login_name = '" + currlog.ToString() + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox2.Text = (dr["username"].ToString());
                    textBox1.Text = (dr["login_name"].ToString());

                    textBox3.Text = (dr["telephone"].ToString());
                    textBox4.Text = (dr["age"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
