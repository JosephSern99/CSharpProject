using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCM_Management_System
{
    
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("server=nandemo.online;user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True");
        public Login()
        {
            InitializeComponent();

        }

        public static object uname { get; private set; }

        //Code gained from stackoverflow
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
        private void Btn_login_Click(object sender, EventArgs e)
        {
            string pass = MD5Hash(Password.Text);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select* FROM staff WHERE Username='" + Username.Text + "' and Password='" + pass + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            int i = 0;
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Account information not found.\r\nPlease check login details if Username and Password correct","Login Unsuccessful");
            }
            else
            {
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT * FROM staff WHERE Username = '" + Username.Text + "' AND Job_Position = 'Manager' AND Department = 'Operations' OR Department = 'Corporate'";
                cmd1.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd1);
                da2.Fill(dt2);
                int p = 0;
                p = Convert.ToInt32(dt2.Rows.Count.ToString());
                if (p == 1)
                {
                    MySqlCommand AdmWelcome = con.CreateCommand();
                    AdmWelcome.CommandType = CommandType.Text;
                    AdmWelcome.CommandText = "SELECT Name FROM staff WHERE Username = '" + Username.Text + "' AND Job_Position = 'Manager' AND Department = 'Operations' OR Department = 'Management'";
                    MySqlDataReader myReader;
                    myReader = AdmWelcome.ExecuteReader();
                    myReader.Read();
                    string name = myReader[0].ToString();
                    MessageBox.Show("Welcome " + name + "\r\nOpenning Up Administration Module", "Login Successful");
                    Login.uname = name;
                    this.Hide();
                    Admin Admin = new Admin();
                    Admin.ShowDialog();
                }
                else
                {
                    MySqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "SELECT * FROM staff WHERE Username = '" + Username.Text + "' AND Job_Position = 'Manager' AND Department 'Human Resources'";
                    cmd2.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    MySqlDataAdapter da3 = new MySqlDataAdapter(cmd2);
                    da3.Fill(dt3);
                    int q = 0;
                    q = Convert.ToInt32(dt3.Rows.Count.ToString());
                    if (q == 1)
                    {
                        MySqlCommand hrWelcome = con.CreateCommand();
                        hrWelcome.CommandType = CommandType.Text;
                        hrWelcome.CommandText = "SELECT Name FROM staff WHERE Username = '" + Username.Text + "' AND Job_Position = 'Manager' AND Department = 'Human Resources'";
                        MySqlDataReader myReader;
                        myReader = hrWelcome.ExecuteReader();
                        myReader.Read();
                        string name = myReader[0].ToString();
                        MessageBox.Show("Welcome " + name + "\r\nOpenning Up Human Resources Module", "Login Successful");
                        Login.uname = name;
                        this.Hide();
                        hr hr = new hr();
                        hr.ShowDialog();
                    }
                    else
                    {
                        MySqlCommand others = con.CreateCommand();
                        others.CommandType = CommandType.Text;
                        others.CommandText = "SELECT Name FROM staff WHERE Username = '" + Username.Text;
                        MySqlDataReader myReader;
                        myReader = others.ExecuteReader();
                        myReader.Read();
                        string name = myReader[0].ToString();
                        MessageBox.Show("Hello " + name + "\r\nIt appears you do not have access rights for this system.\r\nPlease contact the ITS if you feel this is a mistake", "Invalid Access Right");
                    }
                }
            }
            con.Close();
        }
    }
}