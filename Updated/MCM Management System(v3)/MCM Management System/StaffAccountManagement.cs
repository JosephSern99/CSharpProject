using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace MCM_Management_System
{
    public partial class StaffAccountManagement : UserControl
    {
        public StaffAccountManagement()
        {
            InitializeComponent();
        }

        string username = "";
        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text == "")
            //Checking using simple approach - if there is reocrd searched earlier then can Update/Edit record
            {
                MessageBox.Show("No Record to Update", "Records");
            }
            else
            {
                try
                {

                    string Conn = "server=157.230.247.129;user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True";

                    string Query = "UPDATE `staff` set Department='" + this.textBox5.Text + "',Job_Position='" + this.textBox6.Text + "',Email='" + this.textBox7.Text + "',Employment_End='" + this.textBox8.Text + "' where Employee_ID='" + this.textBox4.Text + "';";

                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand MyComd = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyComd.ExecuteReader();
                    this.textBox9.Text = "Data Updated";

                    MyConn.Close();//Connection closed here  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=157.230.247.129;user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True");
                con.Open();
                MySqlCommand scid = con.CreateCommand();
                scid.CommandType = CommandType.Text;
                scid.CommandText = "SELECT * FROM `staff` WHERE `Employee_ID` = '" + textBox4.Text + "'";

                MySqlDataReader MyReader1;
                MyReader1 = scid.ExecuteReader();
                MyReader1.Read();

                textBox5.Text = MyReader1.GetString("Department");
                textBox6.Text = MyReader1.GetString("Job_Position");
                textBox7.Text = MyReader1.GetString("Email");
                textBox8.Text = MyReader1.GetString("Employment_End");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            
            textBox11.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";

            textBox10.Text = "";
         

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox1.Enabled = true;
            textBox20.Text = "";
            textBox21.Text = "";
          
            textBox23.Text = "";
            textBox24.Text = "";


           
            textBox26.Text = "";
            textBox27.Text = "";

            textBox29.Text = "";
        }

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
        private void TextBox11_KeyUp(object sender, KeyEventArgs e)
        {


            

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {

                string newPassword = createPassword();
                string password = MD5Hash(newPassword);

                string Conn2 = "server=157.230.247.129;user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True";

                string Query = "INSERT INTO `staff` (Username, Name, Password, Email, Contact_Number, Department, Job_Position, Employment_Type, Employment_Start, Alt_Phone_Number, Birth_date, Marital_Status, Reference_Name, Reference_Address, Reference_Relationship, Reference_Phone_Number, Reference_Alt_Phone_Number, Salary_Type, Salary) VALUES ('" + username + "','" + this.textBox11.Text + "','" + password + "','" 
                + this.textBox13.Text + "','" + this.textBox14.Text + "','" + this.comboBox2.Text + "','" + this.textBox10.Text + "','" + this.comboBox1.Text + "','" + DateTime.Now.ToString("dd.MM.yyy") + "','" + this.textBox20.Text + "','" + this.textBox21.Text + "','" + this.comboBox3.Text + "','" + this.textBox23.Text + "','" + this.textBox24.Text + "','" + this.comboBox5.Text + "','" + this.textBox26.Text + "','" + this.textBox27.Text + "','" + this.comboBox4.Text + "','" + Double.Parse(this.textBox29.Text)  + "');";

                MySqlConnection MyConn2 = new MySqlConnection(Conn2);

                MySqlCommand MyComd = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader;
                MyConn2.Open();
                MyReader = MyComd.ExecuteReader();
                MessageBox.Show("Record Saved", "Records");

                MyConn2.Close();
                MyConn2.Close();
                
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TextBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection("server=157.230.247.129;user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True");

                string Query = "SELECT * FROM `staff` WHERE Employee_ID =" + int.Parse(textBox2.Text);

                MySqlCommand MyComd = new MySqlCommand(Query, con);
                MySqlDataReader MyReader;

                con.Open();
                MyReader = MyComd.ExecuteReader();

                if (MyReader.Read())
                {
                    this.textBox3.Text = "Employee ID: " + (MyReader.GetInt32("Employee_ID").ToString()) + "\r\n" + "Employee Name: " + (MyReader.GetString("Name")) +
                    "\r\n" + "Email: " + (MyReader.GetString("Email")) + "\r\n" + "Contact No: " + (MyReader.GetString("Contact_Number")) + "\r\n" + "Department: " + (MyReader.GetString("Department"))
                      + "\r\n" + "Job Position: " + (MyReader.GetString("Job_Position")) + "\r\n" + "Employment Type: " + (MyReader.GetString("Employment_Type")) +
                      "\r\n" + "Employment Start: " + (MyReader.GetString("Employment_Start")) + "\r\n" + "Employment End: " + (MyReader.GetString("Employment_End"))
                      + "\r\n" + "Birth Date: " + (MyReader.GetString("Birth_date"))
                      + "\r\n" + "Marital Status: " + (MyReader.GetString("Marital_Status")) + "\r\n" + "Salary Type: " + (MyReader.GetString("Salary_Type")) + "\r\n" +
                      "Salary: " + (MyReader.GetDouble("Salary").ToString());

                }
                else

                {
                    MessageBox.Show("No record found", "Records");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int delStaff = 0;
        private void Button6_Click(object sender, EventArgs e)
        {

            try
            {

                MySqlConnection con = new MySqlConnection("server=157.230.247.129;user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True");

                string Query = "SELECT * FROM `staff` WHERE Employee_ID =" + int.Parse(textBox30.Text);

                MySqlCommand MyComd = new MySqlCommand(Query, con);
                MySqlDataReader MyReader;

                con.Open();
                MyReader = MyComd.ExecuteReader();

                if (MyReader.Read())
                {
                    this.textBox31.Text = (MyReader.GetString("Name"));
                    delStaff = int.Parse(textBox30.Text);
                }
                else

                {
                    MessageBox.Show("No record found", "Records");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (this.textBox30.Text == "")
            //Checking using simple approach - if there is reocrd searched earlier then can Delete
            {
                MessageBox.Show("No Record to Delete", "Records");
            }
            else
            {
                try
                {

                    MySqlConnection Conn3 = new MySqlConnection("server=157.230.247.129;user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True");

                    string Query = "DELETE FROM `staff` WHERE Employee_ID =" + delStaff;

                  
                    MySqlCommand MyComd = new MySqlCommand(Query, Conn3);
                    MySqlDataReader MyReader;
                    Conn3.Open();
                    MyReader = MyComd.ExecuteReader();


                    textBox30.Text = "";
                    textBox31.Text = "";

                    MySqlConnection Conn4 = new MySqlConnection("server=157.230.247.129;user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True");
                    string Query1 = "ALTER TABLE `staff` AUTO_INCREMENT = "+ delStaff.ToString();

                    MySqlCommand MyComd1 = new MySqlCommand(Query1, Conn4);
                    MySqlDataReader MyReader1;
                    Conn4.Open();
                    MyReader1 = MyComd1.ExecuteReader();
                    MessageBox.Show("Record Deleted", "Records");

                    //Just Refresh the Form
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

       

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                comboBox1.SelectedIndex = 1;
                comboBox1.Enabled = false;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                comboBox1.Text = "";
                comboBox1.Enabled = true;
            }
            
            else if (comboBox2.SelectedIndex == 2)
            {
                comboBox1.SelectedIndex = 1;
                comboBox1.Enabled = false;
            }

            else if (comboBox2.SelectedIndex == 3)
            {
                comboBox1.Text = "";
                comboBox1.Enabled = true;
            }
        }

        private void ComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                comboBox1.Text="Permanent";
                comboBox1.Enabled = false;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                comboBox1.Text = "";
                comboBox1.Enabled = true;
            }

            else if (comboBox2.SelectedIndex == 2)
            {
                comboBox1.Text = "Permanent";
                comboBox1.Enabled = false;
            }

            else if (comboBox2.SelectedIndex == 3)
            {
                comboBox1.Text = "";
                comboBox1.Enabled = true;
            }
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }

     
        public int CountSpace(string name)
        {
            string str_split = textBox11.Text;

            string[] broken_str = str_split.Split('-', ' ', ';');
            int count = 0;


            foreach (var sub_str in broken_str)

            {

                count += 1;

            }
            count = count - 1;
            return count;
        }

       
        public string getUsername(string username)
        {
            int num = CountSpace(username);
            String [] nameArray = new String[num];
            nameArray = explode(" ", username);

            string un = "";
            string firstname = "";
            string middlename = "";
            string lastname = "";
            string fnameSplit,mnameSplit;

                firstname = nameArray[0];
                middlename = nameArray[1];
                lastname = nameArray[2];

                fnameSplit = firstname.Substring(0, 1);
                mnameSplit = middlename.Substring(0, 1);

                un = fnameSplit;
                un += mnameSplit;
                un += lastname;
                
            return un;
        }

        private void TextBox11_Leave(object sender, EventArgs e)
        {
            username = getUsername(this.textBox11.Text);
        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }
    }
}