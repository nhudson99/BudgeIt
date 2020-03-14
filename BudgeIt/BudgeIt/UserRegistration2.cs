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

namespace BudgeIt
{
    public partial class UserRegistration2 : Form
    {
        public UserRegistration2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            int IDcount = 0;

            if (username.Text == "" || password.Text == "" || firstName.Text == "" ||
                lastName.Text == "")
                MessageBox.Show("Do not leave anything unfilled");
            else
            {

                //connection 
                SqlConnection sqlCon = new SqlConnection(); //enter propertie of DB here

                sqlCon.ConnectionString =
                                "Data Source=DESKTOP-GJ2VEDA\\MSSQLSERVER02;" +
                                "Initial Catalog=BudgeIt;" +
                                "Integrated Security=True";
                sqlCon.Open();
                SqlCommand cmdGet = sqlCon.CreateCommand();
                cmdGet.CommandText = "SELECT Count(*) FROM Users";
                SqlDataReader reader = cmdGet.ExecuteReader();
                if (reader.Read())
                {
                    //MessageBox.Show(reader[0].ToString());
                    IDcount = (int)(reader[0]);
                    reader.Close();

                } 
                SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@uid", IDcount + 1);
                sqlCmd.Parameters.AddWithValue("@Fname", firstName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Lname", lastName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@userName", username.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", password.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@bal", balance.Text.Trim());
                
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Register is confimred");
                ClearTextBoxes();
            }

        }

        void ClearTextBoxes()
        {
            firstName.Text = lastName.Text = username.Text = password.Text = "";
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frm = new Login();
            frm.ShowDialog();
        }

        /*private void btnSubmit_Click_1(object sender, EventArgs e)
        {

        }*/
    }
}
