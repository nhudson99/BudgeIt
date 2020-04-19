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
    public partial class Schedule : Form
    {
        public int userID;
        public string Fname;
        public SqlConnection sqlConnection = new SqlConnection();
        public Schedule()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            lblName.Text = Fname;

            sqlConnection.Open();

            SqlCommand cmdCurrentBalance = sqlConnection.CreateCommand();
            cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@id";
            cmdCurrentBalance.Parameters.AddWithValue("@id", userID);
            SqlDataReader reader1 = cmdCurrentBalance.ExecuteReader();

            while (reader1.Read())
            {
                txtBalance.Text = reader1[0].ToString();
            }

            reader1.Close();

            SqlCommand cmdload = sqlConnection.CreateCommand();
            cmdload.CommandText = "Select * from [Bills] where uId= @id";
            cmdload.Parameters.AddWithValue("@id", userID);
            SqlDataReader reader = cmdload.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            table.Columns.RemoveAt(table.Columns.Count - 1);
            dataGridView1.DataSource = table;
            
            reader.Close();
        }
    }
}
