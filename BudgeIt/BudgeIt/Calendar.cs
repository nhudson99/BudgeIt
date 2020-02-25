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
    public partial class Calendar : Form
    {
        SqlConnection sqlConnection = new SqlConnection();

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            try
            {
                /*sqlConnection.ConnectionString =
                    "Data Source=SERVERNAME;" + // Change to your server name ------------
                    "Initial Catalog=BudgeIt;" +
                    "Integrated Security=True";
                sqlConnection.Open();*/
                
                MessageBox.Show("Testting");
                sqlConnection.ConnectionString =
                    "Data Source=NATE-SURFACE;" +
                    "Initial Catalog=BudgeIt;" +
                    "Integrated Security=True";
                sqlConnection.Open();

                MessageBox.Show("Connected to DB");

                SqlCommand cmdTest =  sqlConnection.CreateCommand();
                cmdTest.CommandText = "SELECT Fname , Lname FROM USERS ";

                SqlDataReader reader = cmdTest.ExecuteReader();

                if(reader.Read())
                {
                    Console.WriteLine("Income");
                    RTBTesting.Text = RTBTesting.Text + reader[0].ToString().Trim() + " " + reader[1].ToString().Trim();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
