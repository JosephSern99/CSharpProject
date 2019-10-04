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

namespace MCM_Management_System
{
    public partial class StaffAccountManagement : UserControl
    {
        public StaffAccountManagement()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
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
                    this.textBox3.Text = "Employee ID: " + (MyReader.GetInt32("Employee_ID").ToString()) + "\r\n" + "Employee Name: " + (MyReader.GetString("Name"));

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
                    this.textBox9.Text ="Data Updated";

                    MyConn.Close();//Connection closed here  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
