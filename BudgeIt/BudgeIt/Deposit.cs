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
    public partial class Deposit : Form
    {
       
        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            textBoxDepositCurrentBalance.Text = "0.0";
            textBoxDepositAmount.Text = "0.0";
            textBoxDepositNewBalance.Text = "0.0";

            textBoxDepositCurrentBalance.Enabled = false;
            textBoxDepositNewBalance.Enabled = false;
            
            // Opening connection and check it ---------------------------------------------------------- MAJED
            try
            {
                sqlConnection1.Open();
                MessageBox.Show("Welcome to the Deposit Box");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // to load all the user ID ------------------------------------------------------------------ MAJED

            SqlCommand cmdLoad = sqlConnection1.CreateCommand();
            cmdLoad.CommandText = "Select UserId from Users";
            SqlDataReader reader = cmdLoad.ExecuteReader();

            while (reader.Read())
            {
                comboBoxDepositUserID.Items.Add(reader[0].ToString());
            }

            reader.Close();

        }

        private void buttonDepositLoad_Click(object sender, EventArgs e)
        {

        }

        
        private void comboBoxDepositUserID_SelectedIndexChanged(object sender, EventArgs e)
        {

            // To load the amount from the DB ---------------------------------------------------------- MAJED
            
            SqlCommand cmdCurrentBalance = sqlConnection1.CreateCommand();
            cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@bal";
            cmdCurrentBalance.Parameters.AddWithValue("@bal", decimal.Parse(comboBoxDepositUserID.Text));
            SqlDataReader reader = cmdCurrentBalance.ExecuteReader();

            if (reader.Read())
            {
                textBoxDepositCurrentBalance.Text = reader[0].ToString();
                textBoxDepositNewBalance.Text = "0.0";
            }

            reader.Close();
        }

            // To clear parameters because if we need to make another operation -------------------------- MAJED

        void ClearControls()
        {
            textBoxDepositCurrentBalance.Text = "0.0";
            textBoxDepositAmount.Text = "0.0";
            textBoxDepositNewBalance.Text = "0.0";
        }

          // To prevent writing or editing by the user --------------------------------------------------- MAJED

        void EnableControls(bool enable)
        {
            textBoxDepositCurrentBalance.ReadOnly = !enable;
            textBoxDepositAmount.ReadOnly = !enable;
            textBoxDepositNewBalance.ReadOnly = !enable;
       
        }

        private void buttonDepositDelete_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void buttonDepositDeposit_Click(object sender, EventArgs e)
        {

            String Type = "Deposit";
            DateTime Date = DateTime.Now;
            decimal Amt = decimal.Parse(textBoxDepositAmount.Text);
            int UserId = int.Parse(comboBoxDepositUserID.Text);
            string Notes = (textBoxDescription.Text);

            decimal CurrentBalance = decimal.Parse(textBoxDepositCurrentBalance.Text);
     
            if (Amt <= 0)
            {
                MessageBox.Show("Amount must be > 0", "Deposit");
                return;
            }

            // sending a deposit value to the ( Stored Procedure ) to apply it on the database --------- MAJED

            SqlCommand cmdNewDeposit = sqlConnection1.CreateCommand();
            cmdNewDeposit.CommandText = "NewTransaction";
            cmdNewDeposit.CommandType = CommandType.StoredProcedure;

            cmdNewDeposit.Parameters.AddWithValue("@Type", Type);
            cmdNewDeposit.Parameters.AddWithValue("@Date", Date);
            cmdNewDeposit.Parameters.AddWithValue("@Amt", Amt);
            cmdNewDeposit.Parameters.AddWithValue("@UserId", UserId);
            cmdNewDeposit.Parameters.AddWithValue("@notes", Notes);

            cmdNewDeposit.ExecuteNonQuery();

            MessageBox.Show("The amount has been deposited");

            //Clear your parameters to make another operation if you want ------------------------------ MAJED
            cmdNewDeposit.Parameters.Clear();

            textBoxDepositNewBalance.Text = ( CurrentBalance + Amt).ToString();

            textBoxDepositCurrentBalance.Text = textBoxDepositNewBalance.Text;

            textBoxDepositAmount.Text = "0.0";

            textBoxDescription.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Making connection link to connect ( Deposit ) with ( Withdraw ) ------------------------------ MAJED

             Withdraw W = new Withdraw();
             W.ShowDialog();
        }

        private void buttonAllTransaction_Click(object sender, EventArgs e)
        {
            // Making connection link to connect ( Deposit ) with ( Transactions ) ------------------------------ MAJED

            UserTransactions U = new UserTransactions();
            U.ShowDialog();
        }

        private void textBoxDepositCurrentBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGotoBills_Click(object sender, EventArgs e)
        {
            // Making connection link to connect ( Deposit ) with ( Bills ) ------------------------------ MAJED

            Bills B = new Bills();
            B.ShowDialog();
        } 


       
    }
}


