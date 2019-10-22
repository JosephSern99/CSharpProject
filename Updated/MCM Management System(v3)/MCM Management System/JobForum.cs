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
    public partial class JobForum : UserControl
    {
        public JobForum()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = new MySqlConnection("server=157.230.247.129;user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True");
                con.Open();
                MySqlCommand scid = con.CreateCommand();
                scid.CommandType = CommandType.Text;
                scid.CommandText = "SELECT * FROM `job` WHERE `JobID` = '" + Convert.ToInt32(textBox1.Text) + "'";

                MySqlDataReader MyReader1;
                MyReader1 = scid.ExecuteReader();
                MyReader1.Read();

                comboBox1.Text = MyReader1.GetString("JobStatus");
                textBox3.Text = MyReader1.GetString("Date");
                textBox4.Text = MyReader1.GetInt32("Main_Staff_ID").ToString();
                if (!MyReader1.IsDBNull(MyReader1.GetOrdinal("Staff_1_ID")))
                {
                    textBox5.Text = MyReader1.GetInt32("Staff_1_ID").ToString();
                }
                else
                {
                    textBox5.Text = "";
                }

                if (!MyReader1.IsDBNull(MyReader1.GetOrdinal("Staff_2_ID")))
                {
                    textBox6.Text = MyReader1.GetInt32("Staff_2_ID").ToString();
                }
                else
                {
                    textBox6.Text = "";
                }

                if (!MyReader1.IsDBNull(MyReader1.GetOrdinal("Staff_3_ID")))
                {
                    textBox7.Text = MyReader1.GetInt32("Staff_3_ID").ToString();
                }
                else
                {
                    textBox7.Text = "";
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text  = "";
            comboBox1.Text = "";
            textBox3.Text  = "";
            textBox4.Text  = "";
            textBox5.Text  = "";
            textBox6.Text  = "";
            textBox7.Text  = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            //Checking using simple approach - if there is reocrd searched earlier then can Update/Edit record
            {
                MessageBox.Show("No Record to Update", "Records");
            }
            else
            {
                try
                {

                    string Conn = "server=157.230.247.129;user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True";

                    string Query = "UPDATE `job` set JobStatus='" + this.comboBox1.Text + "',Date='" + this.textBox3.Text + "',Main_Staff_ID='" + Convert.ToInt32(this.textBox4.Text) + "',Staff_1_ID='" + Convert.ToInt32(this.textBox5.Text) + "',Staff_2_ID='" + Convert.ToInt32(this.textBox6.Text) + "',Staff_3_ID='" + Convert.ToInt32(this.textBox7.Text) + "'+ where Employee_ID='" + Convert.ToInt32(this.textBox1.Text) + "';";

                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand MyComd = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyComd.ExecuteReader();
                    MessageBox.Show("Job Allocated", "Jobs");

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
