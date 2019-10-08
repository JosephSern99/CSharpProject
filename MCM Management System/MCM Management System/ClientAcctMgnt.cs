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
    public partial class ClientAcctMgnt : UserControl
    {
        public ClientAcctMgnt()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=nandemo.online; user id=operations; password=sdmconnect1; database=mypoolcm; persistsecurityinfo=True");

        public int custIDno(String type)
        {
            int IdNO;

            con.Open();
            MySqlCommand others = con.CreateCommand();
            others.CommandType = CommandType.Text;
            others.CommandText = "SELECT COUNT(`CustomerID`) FROM `customer` WHERE `CustomerID` LIKE '" + type;
            MySqlDataReader myReader;
            myReader = others.ExecuteReader();
            myReader.Read();
            IdNO = Convert.ToInt32(myReader[0]);
            con.Close();

            return IdNO;

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

        private void CustReset_Click(object sender, EventArgs e)
        {
            cName.Text = "";
            cEmail.Text = "";
            cCNumber.Text = "";
            cAddress.Text = "";
            cType.Text = "";
            cPoolType.Text = "";
            cPoolRemarks.Text = "";
            cScheduleType.Text = "";
            cScheduleRemarks.Text = "";

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (sCName.Text != "")
            {
                con.Open();
                MySqlCommand scname = con.CreateCommand();
                scname.CommandType = CommandType.Text;
                scname.CommandText = "SELECT * FROM customer WHERE Name ='" + sCName.Text + "'";
                MySqlDataReader myReader;
                myReader = scname.ExecuteReader();
                myReader.Read();

                string rCID = myReader[0].ToString();
                string custName = myReader[1].ToString();
                string email = myReader[2].ToString();
                string Contact = myReader[4].ToString();
                string Address = myReader[5].ToString();
                string type = myReader[6].ToString();

                int ptypeNo = Convert.ToInt32(myReader[7]);
                string PoolType;
                switch (ptypeNo)
                {
                    case 1: PoolType = "1. Small size swimming pool"; break;
                    case 2: PoolType = "2. Medium size swimming pool"; break;
                    case 3: PoolType = "3. Large size swimming pool"; break;
                    case 4: PoolType = "4. Large and Complex size swimming pool"; break;
                    default: PoolType = "Pool Information Not Recorded"; break;
                }

                string poolRemark = myReader[8].ToString();
                string ScheduleType = myReader[9].ToString();
                string SchedueRemark = myReader[10].ToString();

                con.Close();
                txtBxResult.Text = "Search Results" + "\n\r" + "\nCustomer ID: " + rCID + "\n\r" + "\nCustomer Name: " + custName + "\n\r" + "\nemail: " + email + "\n\r" + "\nContact Number: " + Contact + "\n\r" + "\nAddress: " + Address + "\n\r" + "\nCustomer Type: " + type + "\n\r" + "\nPool Type: " + PoolType + "\n\r" + "\nPool Remarks: " + poolRemark + "\n\r" + "\nSchedule Type: " + ScheduleType + "\n\r" + "\nSchedule Remarks: " + SchedueRemark;
            }
            else if (sCID.Text != "")
            {
                con.Open();
                MySqlCommand scid = con.CreateCommand();
                scid.CommandType = CommandType.Text;
                scid.CommandText = "SELECT * FROM `customer` WHERE `CustomerID` = '" + sCID.Text + "'";
                MySqlDataReader myReader;
                myReader = scid.ExecuteReader();
                myReader.Read();

                string rCID = myReader[0].ToString();
                string custName = myReader[1].ToString();
                string email = myReader[2].ToString();
                string Contact = myReader[4].ToString();
                string Address = myReader[5].ToString();
                string type = myReader[6].ToString();

                int ptypeNo = Convert.ToInt32(myReader[7]);
                string PoolType;
                switch (ptypeNo)
                {
                    case 1: PoolType = "1. Small size swimming pool"; break;
                    case 2: PoolType = "2. Medium size swimming pool"; break;
                    case 3: PoolType = "3. Large size swimming pool"; break;
                    case 4: PoolType = "4. Large and Complex size swimming pool"; break;
                    default: PoolType = "Pool Information Not Recorded"; break;
                }

                string poolRemark = myReader[8].ToString();
                string ScheduleType = myReader[9].ToString();
                string SchedueRemark = myReader[10].ToString();

                con.Close();
                txtBxResult.Text = "Search Results" + "\n\r" + "\nCustomer ID: " + rCID +"\n\r"+ "\nCustomer Name: " + custName + "\n\r" + "\nemail: " + email + "\n\r" + "\nContact Number: " + Contact + "\n\r" + "\nAddress: " + Address + "\n\r" + "\nCustomer Type: " + type + "\n\r" + "\nPool Type: " + PoolType + "\n\r"  + "\nPool Remarks: " + poolRemark + "\n\r" + "\nSchedule Type: " + ScheduleType + "\n\r" + "\nSchedule Remarks: " + SchedueRemark;

            }


        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand scid = con.CreateCommand();
            scid.CommandType = CommandType.Text;
            scid.CommandText = "SELECT * FROM `customer` WHERE `CustomerID` = '" + uCID.Text + "'";
            MySqlDataReader myReader;
            myReader = scid.ExecuteReader();
            myReader.Read();

            uEmail.Text = myReader[2].ToString();
            uContactNumber.Text = myReader[4].ToString();
            uAddress.Text = myReader[5].ToString();
            uCustType.Text = myReader[6].ToString();

            int ptypeNo = Convert.ToInt32(myReader[7]);
            string PoolType;
            switch (ptypeNo)
            {
                case 1: PoolType = "1. Small size swimming pool"; break;
                case 2: PoolType = "2. Medium size swimming pool"; break;
                case 3: PoolType = "3. Large size swimming pool"; break;
                case 4: PoolType = "4. Large and Complex size swimming pool"; break;
                default: PoolType = "Pool Information Not Recorded"; break;
            }

            uPoolType.Text = PoolType;
            uPoolRemarks.Text = myReader[8].ToString();
            uScheduleType.Text = myReader[9].ToString();
            uScheduleRemarks.Text = myReader[10].ToString();

            con.Close();
        }

        private void CustSub_Click(object sender, EventArgs e)
        {
            string Name = cName.Text;
            string Email = cEmail.Text;
            string Number = cCNumber.Text;
            string Address = cAddress.Text;
            string Type = cType.Text;
            string PoolType1 = cPoolType.Text;
            string PoolRemarks = cPoolRemarks.Text;
            string ScheduleType = cScheduleType.Text;
            string ScheduleRemarks = cScheduleRemarks.Text;

            int poolType;
            switch (PoolType1)
            {
                case "1. Small size swimming pool": poolType =1 ; break;
                case "2. Medium size swimming pool": poolType =2 ; break;
                case "3. Large size swimming pool": poolType =3; break;
                case "4. Large and Complex size swimming pool": poolType =4; break;
                default: poolType = 0;break;
            }

            con.Open();
            MySqlCommand scid = con.CreateCommand();
            scid.CommandType = CommandType.Text;
            scid.CommandText = "INSERT INTO `customer` (`CustomerID`, `Name`, `Email`, `Password`, `Contact_Number`, `Address`, `Customer_Type`, `Pool Type`, `Pool Remarks`, `Schedule Type`, `Schedule Remark`) VALUES (@name,@email,@password,@cnumber,@address,@ctype,@ptype,@pRemarks,@stype,@sremarks)";




        }
    }
}
