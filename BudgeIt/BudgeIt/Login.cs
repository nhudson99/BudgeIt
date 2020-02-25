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
            Calendar form = new Calendar();
            form.sqlConnection = sqlConnection;
            form.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                /*sqlConnection.ConnectionString =
                    "Data Source=SERVERNAME;" + // Change to your server name ------------
                    "Initial Catalog=BudgeIt;" +
                    "Integrated Security=True";
                sqlConnection.Open();*/
                //MessageBox.Show("Testting");
                sqlConnection.ConnectionString =
                    "Data Source=NATE-SURFACE;" +
                    "Initial Catalog=BudgeIt;" +
                    "Integrated Security=True";
                sqlConnection.Open();

                //MessageBox.Show("Connected to DB");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
