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
    public partial class Transactions : Form
    {
        public SqlConnection sqlConnection = new SqlConnection();

        public Transactions()
        {
            InitializeComponent();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            // Opening connection and check it ---------------------------------------------------------------- MAJED
            try
            {
                sqlConnection.Open();
                MessageBox.Show("Welcome to the Transactions Box");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // to load all the user ID --------------------------------------------------------------------------- MAJED

            SqlCommand cmdLoad = sqlConnection.CreateCommand();
            cmdLoad.CommandText = "Select UserId from Users";
            SqlDataReader reader = cmdLoad.ExecuteReader();

            while (reader.Read())
            {
                comboBoxTransactionsUserID.Items.Add(reader[0].ToString());

            }

            reader.Close();


            textBoxTransactionsCurrentBalance.Enabled = false;
        }

        private void comboBoxTransactionsUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmdload = sqlConnection.CreateCommand();
            cmdload.CommandText = "Select * from [Transactions] where uId= @id";
            cmdload.Parameters.AddWithValue("@id", int.Parse(comboBoxTransactionsUserID.Text));
            SqlDataReader reader = cmdload.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            reader.Close();


            // To load the amount from the DB ---------------------------------------------------------------------- MAJED

            SqlCommand cmdCurrentBalance = sqlConnection.CreateCommand();
            cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@id";
            cmdCurrentBalance.Parameters.AddWithValue("@id", int.Parse(comboBoxTransactionsUserID.Text));
            SqlDataReader reader1 = cmdCurrentBalance.ExecuteReader();

            while (reader1.Read())
            {
                textBoxTransactionsCurrentBalance.Text = reader1[0].ToString();
            }

            reader1.Close();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
