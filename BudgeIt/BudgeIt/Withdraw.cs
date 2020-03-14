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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            textBoxWithdrawCurrentBalance.Text = "0.0";
            textBoxWithdrawAmount.Text = "0.0";
            textBoxWithdrawNewBalance.Text = "0.0";


            textBoxWithdrawCurrentBalance.Enabled = false;
            textBoxWithdrawNewBalance.Enabled = false;


            // Opening connection and check it ---------------------------------------------------------- MAJED
            try
            {
                sqlConnection1.Open();
                MessageBox.Show("Welcome to the Withdraw Box");
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
                comboBoxWithdrawUserID.Items.Add(reader[0].ToString());
            }

            reader.Close();
        }



        private void comboBoxWithdrawUserID_SelectedIndexChanged(object sender, EventArgs e)
        {

            // To load the amount from the DB ---------------------------------------------------------- MAJED
            
            SqlCommand cmdCurrentBalance = sqlConnection1.CreateCommand();
            cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@bal";
            cmdCurrentBalance.Parameters.AddWithValue("@bal", decimal.Parse(comboBoxWithdrawUserID.Text));
            SqlDataReader reader = cmdCurrentBalance.ExecuteReader();

            if (reader.Read())
            {
                textBoxWithdrawCurrentBalance.Text = reader[0].ToString();
                textBoxWithdrawNewBalance.Text = "0.0";
            }

            reader.Close();
        }

            // To clear parameters because if we need to make another operation -------------------------- MAJED

        void ClearControls()
        {
            textBoxWithdrawCurrentBalance.Text = "0.0";
            textBoxWithdrawAmount.Text = "0.0";
            textBoxWithdrawNewBalance.Text = "0.0";
        }

          // To prevent writing or editing by the user --------------------------------------------------- MAJED

        void EnableControls(bool enable)
        {
            textBoxWithdrawCurrentBalance.ReadOnly = !enable;
            textBoxWithdrawAmount.ReadOnly = !enable;
            textBoxWithdrawNewBalance.ReadOnly = !enable;
       
        }

        private void buttonWithdrawDelete_Click(object sender, EventArgs e)
        {
            ClearControls();
        }


        private void buttonWithdrawWithdraw_Click(object sender, EventArgs e)
        {
            String Type = "Withdraw";
            DateTime Date = DateTime.Now;
            decimal Amt = decimal.Parse(textBoxWithdrawAmount.Text);
            int UserId = int.Parse(comboBoxWithdrawUserID.Text);
            string Notes = (textBoxDescription.Text);

            decimal CurrentBalance = decimal.Parse(textBoxWithdrawCurrentBalance.Text);


            if (Amt <= 0)
            {
                MessageBox.Show("Amount must be > 0", "Withdraw");
                return;
            }

            // sending a Withdraw value to the ( Stored Procedure ) to apply it on the database --------- MAJED

            SqlCommand cmdNewWithdraw = sqlConnection1.CreateCommand();
            cmdNewWithdraw.CommandText = "NewTransaction";
            cmdNewWithdraw.CommandType = CommandType.StoredProcedure;

            cmdNewWithdraw.Parameters.AddWithValue("@Type", Type);
            cmdNewWithdraw.Parameters.AddWithValue("@Date", Date);
            cmdNewWithdraw.Parameters.AddWithValue("@Amt", Amt);
            cmdNewWithdraw.Parameters.AddWithValue("@UserId", UserId);
            cmdNewWithdraw.Parameters.AddWithValue("@notes", Notes);

            cmdNewWithdraw.ExecuteNonQuery();

            MessageBox.Show("The amount has been Withdrawn");

            //Clear your parameters to make another operation if you want ------------------------------ MAJED
            cmdNewWithdraw.Parameters.Clear();

            textBoxWithdrawNewBalance.Text = (CurrentBalance - Amt).ToString();

            textBoxWithdrawCurrentBalance.Text = textBoxWithdrawNewBalance.Text;


            textBoxWithdrawAmount.Text = "0.0";

            textBoxDescription.Clear();
        }

        private void buttonGoToDeposit_Click(object sender, EventArgs e)
        {
            // Making connection link to connect ( Withdraw ) with ( Deposit ) ------------------------------ MAJED

            Deposit D = new Deposit();
            D.ShowDialog();
        }

        private void buttonAllTransaction_Click(object sender, EventArgs e)
        {
            // Making connection link to connect ( Withdraw ) with ( Transactions ) ------------------------------ MAJED

            UserTransactions U = new UserTransactions();
            U.ShowDialog();

        }

        private void textBoxWithdrawAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWithdrawNewBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

    }
}
