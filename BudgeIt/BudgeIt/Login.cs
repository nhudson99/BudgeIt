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
    public partial class Login : Form
    {
        public SqlConnection sqlConnection = new SqlConnection();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlCommand cmdCheckLogin = sqlConnection.CreateCommand();

            cmdCheckLogin.CommandText = "SELECT userName, password FROM USERS WHERE userName = @uName AND  password = @pass";
            cmdCheckLogin.Parameters.AddWithValue("@uName", txtUserName.Text);
            cmdCheckLogin.Parameters.AddWithValue("@pass", txtPassword.Text);


            SqlDataReader reader = cmdCheckLogin.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Worked");
                Calendar form = new Calendar();
                form.sqlConnection.ConnectionString = sqlConnection.ConnectionString;
                form.Show();
            }
            reader.Close();
    
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                /* Connection strings servers 
                 * USE YOURS
                 * Data Source=DESKTOP-GJ2VEDA\\MSSQLSERVER02; - 
                 * Data Source=NATE-SURFACE; - Nate
                 * */
                sqlConnection.ConnectionString =
                        "Data Source=NATE-SURFACE;" +
                        "Initial Catalog=BudgeIt;" +
                        "Integrated Security=True";
                sqlConnection.Open();

                //MessageBox.Show("Connected");
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegistration2 frm = new UserRegistration2();
            frm.ShowDialog();
        }
    }
}
