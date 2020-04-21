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
        //public int userID;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlCommand cmdCheckLogin = sqlConnection.CreateCommand();

            cmdCheckLogin.CommandText = "SELECT userId FROM USERS WHERE userName = @uName AND  password = @pass";
            cmdCheckLogin.Parameters.AddWithValue("@uName", txtUserName.Text);
            cmdCheckLogin.Parameters.AddWithValue("@pass", txtPassword.Text);


            SqlDataReader reader = cmdCheckLogin.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    //MessageBox.Show("Worked");
                    Calendar form = new Calendar();
                    form.sqlConnection.ConnectionString = sqlConnection.ConnectionString;
                    form.userID = int.Parse(reader[0].ToString());
                    this.Hide();
                    ClearControls();
                    form.ShowDialog();
                    this.Show();
                    
                }
                else
                    throw new Exception("Invalid Login Attempt");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            reader.Close();
    
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                /* Connection strings servers 
                 * USE YOURS
                 * Data Source=DESKTOP-GJ2VEDA\\MSSQLSERVER02; - Niles
                 * Data Source=NATE-SURFACE; - Nate surface
                 * Data Source=DESKTOP-V7U3425; - Nate PC
                 * DESKTOP-L3400E3; - Justin's MiniComputer
                 * */
                sqlConnection.ConnectionString =
                        "Data Source= DESKTOP-V7U3425;" +
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
            frm.sqlCon = sqlConnection;
            frm.ShowDialog();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ClearControls()
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}
