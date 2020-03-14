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
using System.Configuration;

namespace MoneySys
{
    public partial class UserTransactions : Form
    {
        public UserTransactions()
        {
            InitializeComponent();
        }

        private void UserTransactions_Load(object sender, EventArgs e)
        {
              // Opening connection and check it ---------------------------------------------------------------- MAJED
            try
            {
                sqlConnection1.Open();
                MessageBox.Show("Welcome to the Transactions Box");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // to load all the user ID --------------------------------------------------------------------------- MAJED

            SqlCommand cmdLoad = sqlConnection1.CreateCommand();
            cmdLoad.CommandText = "Select UserId from Users";
            SqlDataReader reader = cmdLoad.ExecuteReader();

            while (reader.Read())
            {
                comboBoxTransactionsUserID.Items.Add(reader[0].ToString());
                
            }

            reader.Close();


            textBoxTransactionsCurrentBalance.Enabled = false;
        }



        // to retrieve all the user Transactions ------------------------------------------------------------------- MAJED

             private void comboBoxWithdrawUserID_SelectedIndexChanged(object sender, EventArgs e)
         {

             SqlCommand cmdload = sqlConnection1.CreateCommand();
                    cmdload.CommandText = "Select * from [Transaction] where UserId= @id";
                    cmdload.Parameters.AddWithValue("@id", int.Parse(comboBoxTransactionsUserID.Text));
                    SqlDataReader reader = cmdload.ExecuteReader();
                 
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                    reader.Close();


                    // To load the amount from the DB ---------------------------------------------------------------------- MAJED

                    SqlCommand cmdCurrentBalance = sqlConnection1.CreateCommand();
                    cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@id";
                    cmdCurrentBalance.Parameters.AddWithValue("@id", int.Parse(comboBoxTransactionsUserID.Text));
                    SqlDataReader reader1 = cmdCurrentBalance.ExecuteReader();

                    while (reader1.Read())
                    {
                        textBoxTransactionsCurrentBalance.Text = reader1[0].ToString();
                    }

                    reader1.Close();
         }


             private void buttonGoToDeposit_Click(object sender, EventArgs e)
             {
                 // Making connection link to connect ( Tramsactions ) with ( Deposit ) ------------------------------ MAJED

                 Deposit D = new Deposit();
                 D.ShowDialog();
             }

             private void buttonGoToWithdraw_Click(object sender, EventArgs e)
             {
                 // Making connection link to connect ( Transactions ) with ( Withdraw ) ------------------------------ MAJED

                 Withdraw W = new Withdraw();
                 W.ShowDialog();
             }

             private void textBoxTransactionsCurrentBalance_TextChanged(object sender, EventArgs e)
             {

             }



    }
}
