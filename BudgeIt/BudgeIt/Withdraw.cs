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
    public partial class Withdraw : Form
    {
        public SqlConnection sqlConnection = new SqlConnection();

        public Withdraw()
        {
            InitializeComponent();
        }

        private void comboBoxWithdrawUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // To load the amount from the DB ---------------------------------------------------------- MAJED

            SqlCommand cmdCurrentBalance = sqlConnection.CreateCommand();
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
                sqlConnection.Open();
                MessageBox.Show("Welcome to the Withdraw Box");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // to load all the user ID ------------------------------------------------------------------ MAJED

            SqlCommand cmdLoad = sqlConnection.CreateCommand();
            cmdLoad.CommandText = "Select UserId from Users";
            SqlDataReader reader = cmdLoad.ExecuteReader();

            while (reader.Read())
            {
                comboBoxWithdrawUserID.Items.Add(reader[0].ToString());
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

        private void buttonWithdrawDelete_Click_1(object sender, EventArgs e)
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

            // Get transaction IDCount
            int IDcount = 0;
            SqlCommand cmdGet = sqlConnection.CreateCommand();
            cmdGet.CommandText = "SELECT Count(*) FROM TRANSACTIONS";
            SqlDataReader reader = cmdGet.ExecuteReader();
            if (reader.Read())
            {
                //MessageBox.Show(reader[0].ToString());
                IDcount = (int)(reader[0]);
                reader.Close();

            }

            // sending a Withdraw value to the ( Stored Procedure ) to apply it on the database --------- MAJED

            SqlCommand cmdNewWithdraw = sqlConnection.CreateCommand();
            cmdNewWithdraw.CommandText = "NewTransaction";
            cmdNewWithdraw.CommandType = CommandType.StoredProcedure;

            cmdNewWithdraw.Parameters.AddWithValue("@tID", IDcount + 1);
            cmdNewWithdraw.Parameters.AddWithValue("@Type", Type);
            cmdNewWithdraw.Parameters.AddWithValue("@Date", Date);
            cmdNewWithdraw.Parameters.AddWithValue("@Amt", Amt);
            cmdNewWithdraw.Parameters.AddWithValue("@UserId", UserId);

            cmdNewWithdraw.ExecuteNonQuery();

            MessageBox.Show("The amount has been Withdrawn");

            //Clear your parameters to make another operation if you want ------------------------------ MAJED
            cmdNewWithdraw.Parameters.Clear();

            textBoxWithdrawNewBalance.Text = (CurrentBalance - Amt).ToString();

            textBoxWithdrawCurrentBalance.Text = textBoxWithdrawNewBalance.Text;


            textBoxWithdrawAmount.Text = "0.0";

            textBoxDescription.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonGoToDeposit_Click(object sender, EventArgs e)
        {

        }
    }
}
