using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgeIt
{
    public partial class UserRegistration2 : Form
    {
        public SqlConnection sqlCon;

        public UserRegistration2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int IDcount = 0;

            if (username.Text == "" || password.Text == "" || firstName.Text == "" ||
                lastName.Text == "")
                MessageBox.Show("Do not leave anything unfilled");
            else
            {

                //connection 
                
                //sqlCon.Open();
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

        private void ClearTextBoxes()
        {
            firstName.Text = lastName.Text = username.Text = password.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
