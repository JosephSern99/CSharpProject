using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCM_Management_System
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("server=157.230.247.129;user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True");
        public Login()
        {
            InitializeComponent();
        }
        //Username Generation
        public string createUsername(string name)
        {
            string[] uname = name.Split(new char[0]);
            string username = "";
            for (int x = 0; x <= uname.Length + 1; x++)
            {
                if (x < uname.Length)
                {

                    username += uname[x].Substring(0, 1);
                }
                else if (x == uname.Length)
                {
                    username += uname[x];
                }
            }
            return username;
        }
        //Password Generation
        public string createPassword()
        {
            int length = 8;
            // Create a string of characters, numbers, special characters that allowed in the password  
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();

            // Select one random character at a time from the string  
            // and create an array of chars  
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
        private void Btn_login_Click(object sender, EventArgs e)
        {

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select* FROM staff WHERE Username='" + Username.Text + "' and Password='" + Password.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            int i = 0;
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select* FROM Customer WHERE CustomerID='" + Username.Text + "' and Password='" + Password.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                da1.Fill(dt1);
                int o = 0;
                o = Convert.ToInt32(dt1.Rows.Count.ToString());
                if (o == 0)
                {
                    MessageBox.Show("No Account Found");
                }
                else
                {
                    MessageBox.Show("Welcome");
                    this.Hide();
                    Customer Customer = new Customer();
                    Customer.ShowDialog();
                }
            }
            else
            {
                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT * FROM `staff` WHERE Username = '" + Username.Text + "' AND Job_Position = 'Manager' AND Department = 'Operations'";
                cmd1.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd1);
                da2.Fill(dt2);
                int p = 0;
                p = Convert.ToInt32(dt2.Rows.Count.ToString());
                if (p == 1)
                {
                    MessageBox.Show("Welcome !!!");
                    this.Hide();
                    Admin Admin = new Admin();
                    Admin.ShowDialog();
                }
                else
                {
                    MySqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "SELECT * FROM Staff WHERE Username = '" + Username.Text + "' AND Department = 'Human Resources'";
                    cmd2.ExecuteNonQuery();
                    DataTable dt3 = new DataTable();
                    MySqlDataAdapter da3 = new MySqlDataAdapter(cmd2);
                    da3.Fill(dt3);
                    int q = 0;
                    q = Convert.ToInt32(dt3.Rows.Count.ToString());
                    if (q == 1)
                    {
                        MessageBox.Show("Welcome !!");
                        this.Hide();
                        hr hr = new hr();
                        hr.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome !");
                        this.Hide();
                        mgnt mgnt = new mgnt();
                        mgnt.ShowDialog();
                    }
                }
            }
            con.Close();
        }
    }
}