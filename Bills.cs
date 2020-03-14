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
    public partial class Bills : Form
    {

        public Bills()
        {
            InitializeComponent();
        }

        private void comboBoxBillsUserID_SelectedIndexChanged(object sender, EventArgs e)
        {

            // To load the amount from the DB ---------------------------------------------------------- Eliseo

            SqlCommand cmdCurrentBalance = sqlConnection1.CreateCommand();
            cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@bal";
            cmdCurrentBalance.Parameters.AddWithValue("@bal", decimal.Parse(comboBoxBillsUserID.Text));
            SqlDataReader reader = cmdCurrentBalance.ExecuteReader();

            if (reader.Read())
            {
                textBoxBillsCurrentBalance.Text = reader[0].ToString();
                textBoxBillsNewBalance.Text = "0.0";
            }

            reader.Close();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            textBoxBillsCurrentBalance.Text = "0.0";
            textBoxBillsAmount.Text = "0.0";
            textBoxBillsNewBalance.Text = "0.0";

            textBoxBillsCurrentBalance.Enabled = false;
            textBoxBillsNewBalance.Enabled = false;

            // Opening connection and check it ---------------------------------------------------------- Eliseo
            try
            {
                sqlConnection1.Open();
                MessageBox.Show("Welcome to the Bills Box");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // to load all the user ID ------------------------------------------------------------------ Eliseo

            SqlCommand cmdLoad = sqlConnection1.CreateCommand();
            cmdLoad.CommandText = "Select UserId from Users";
            SqlDataReader reader = cmdLoad.ExecuteReader();

            while (reader.Read())
            {
                comboBoxBillsUserID.Items.Add(reader[0].ToString());
            }

            reader.Close();
        }

        private void textBoxBillsCurrentBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBillsPay_Click(object sender, EventArgs e)
        {
            String Type = "Bills";
            DateTime Date = DateTime.Now;
            decimal Amt = decimal.Parse(textBoxBillsAmount.Text);
            int UserId = int.Parse(comboBoxBillsUserID.Text);
            string Notes = (textBoxDescription.Text);

            decimal CurrentBalance = decimal.Parse(textBoxBillsCurrentBalance.Text);


            if (Amt <= 0)
            {
                MessageBox.Show("Amount must be > 0", "Bills");
                return;
            }

            // sending a Bill value to the ( Stored Procedure ) to apply it on the database --------- Eliseo

            SqlCommand cmdNewBill = sqlConnection1.CreateCommand();
            cmdNewBill.CommandText = "NewTransaction";
            cmdNewBill.CommandType = CommandType.StoredProcedure;

            cmdNewBill.Parameters.AddWithValue("@Type", Type);
            cmdNewBill.Parameters.AddWithValue("@Date", Date);
            cmdNewBill.Parameters.AddWithValue("@Amt", Amt);
            cmdNewBill.Parameters.AddWithValue("@UserId", UserId);
            cmdNewBill.Parameters.AddWithValue("@notes", Notes);

            cmdNewBill.ExecuteNonQuery();

            MessageBox.Show("The Bill has been paid");

            //Clear your parameters to make another operation if you want ------------------------------ Eliseo
            cmdNewBill.Parameters.Clear();

            textBoxBillsNewBalance.Text = (CurrentBalance - Amt).ToString();

            textBoxBillsCurrentBalance.Text = textBoxBillsNewBalance.Text;


            textBoxBillsAmount.Text = "0.0";

            textBoxDescription.Clear();
        }


        // To clear parameters because if we need to make another operation -------------------------- Eliseo

        void ClearControls()
        {
            textBoxBillsCurrentBalance.Text = "0.0";
            textBoxBillsAmount.Text = "0.0";
            textBoxBillsNewBalance.Text = "0.0";
        }

        private void buttonBillsDelete_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void buttonGoToDeposit_Click(object sender, EventArgs e)
        {
            // Making connection link to connect ( Bills ) with ( Deposit ) ------------------------------ Eliseo

            Deposit B = new Deposit();
            B.ShowDialog();
        }

        private void buttonGoToWithdraw_Click(object sender, EventArgs e)
        {
            // Making connection link to connect ( Bills ) with ( Withdraw ) ------------------------------ Eliseo

            Withdraw B = new Withdraw();
           B.ShowDialog();
        }

        private void buttonAllTransaction_Click(object sender, EventArgs e)
        {
            // Making connection link to connect ( Bills ) with ( Transactions ) ------------------------------ Eliseo

            UserTransactions B = new UserTransactions();
            B.ShowDialog();
        }


    }
}
