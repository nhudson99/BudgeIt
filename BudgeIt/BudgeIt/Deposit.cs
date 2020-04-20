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
    public partial class Deposit : Form
    {
        public SqlConnection sqlConnection1 = new SqlConnection();
        public int userID;
        public string Fname;
        public float bal;

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

            /* to load all the user ID ------------------------------------------------------------------ MAJED

            SqlCommand cmdLoad = sqlConnection1.CreateCommand();
            cmdLoad.CommandText = "Select UserId from Users";
            SqlDataReader reader = cmdLoad.ExecuteReader();

            while (reader.Read())
            {
                comboBoxDepositUserID.Items.Add(reader[0].ToString());
            }

            reader.Close();
            */

            SqlCommand cmdCurrentBalance = sqlConnection1.CreateCommand();
            cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@bal";
            cmdCurrentBalance.Parameters.AddWithValue("@bal", userID);
            SqlDataReader reader = cmdCurrentBalance.ExecuteReader();

            if (reader.Read())
            {
                textBoxDepositCurrentBalance.Text = String.Format("{0:$##.00}", reader[0]);
                textBoxDepositNewBalance.Text = "0.0";
                bal = float.Parse(reader[0].ToString());
            }

            reader.Close();

            //lblName.Text = Fname;
        }

        private void comboBoxDepositUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // To load the amount from the DB ---------------------------------------------------------- MAJED

            SqlCommand cmdCurrentBalance = sqlConnection1.CreateCommand();
            cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@bal";
            cmdCurrentBalance.Parameters.AddWithValue("@bal", userID);
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
            try
            {
                String Type = "Deposit";
                DateTime Date = DateTime.Now;
                decimal Amt = decimal.Parse(textBoxDepositAmount.Text);
                

                //decimal CurrentBalance = decimal.Parse(textBoxDepositCurrentBalance.Text);

                if (Amt <= 0)
                {
                    MessageBox.Show("Amount must be > 0", "Deposit");
                    return;
                }

                // Get transaction IDCount
                int IDcount = 0;
                SqlCommand cmdGet = sqlConnection1.CreateCommand();
                cmdGet.CommandText = "SELECT Count(*) FROM TRANSACTIONS";
                SqlDataReader reader = cmdGet.ExecuteReader();
                if (reader.Read())
                {
                    //MessageBox.Show(reader[0].ToString());
                    IDcount = (int)(reader[0]);
                    reader.Close();

                }

                // sending a deposit value to the ( Stored Procedure ) to apply it on the database --------- MAJED

                SqlCommand cmdNewDeposit = sqlConnection1.CreateCommand();
                cmdNewDeposit.CommandText = "NewTransaction";
                cmdNewDeposit.CommandType = CommandType.StoredProcedure;

                cmdNewDeposit.Parameters.AddWithValue("@tID", IDcount + 1);
                cmdNewDeposit.Parameters.AddWithValue("@Type", Type);
                cmdNewDeposit.Parameters.AddWithValue("@Date", Date);
                cmdNewDeposit.Parameters.AddWithValue("@Amt", Amt);
                cmdNewDeposit.Parameters.AddWithValue("@UserId", userID);

                cmdNewDeposit.ExecuteNonQuery();

                MessageBox.Show("The amount has been deposited");

                //Clear your parameters to make another operation if you want ------------------------------ MAJED
                cmdNewDeposit.Parameters.Clear();

                textBoxDepositNewBalance.Text = String.Format("{0:$##.00}", (bal + float.Parse(Amt.ToString())));

                textBoxDepositCurrentBalance.Text = textBoxDepositNewBalance.Text;

                textBoxDepositAmount.Text = "0.0";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonGoToWithdraw_Click(object sender, EventArgs e)
        {
            // Making connection link to connect ( Deposit ) with ( Withdraw ) ------------------------------ MAJED

            //Withdraw W = new Withdraw();
            //W.ShowDialog();
        }

        private void buttonAllTransaction_Click(object sender, EventArgs e)
        {
            // Making connection link to connect ( Deposit ) with ( Transactions ) ------------------------------ MAJED

            //UserTransactions U = new UserTransactions();
           // U.ShowDialog();
        }

        private void buttonGotoBills_Click(object sender, EventArgs e)
        {
            // Making connection link to connect ( Deposit ) with ( Bills ) ------------------------------ MAJED

            //Bills B = new Bills();
            //B.ShowDialog();
        }

        private void buttonDepositBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
