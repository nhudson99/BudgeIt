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
    public partial class Bills : Form
    {
        public SqlConnection sqlConnection = new SqlConnection();
        public int userID;
        public string Fname;

        public Bills()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            textBoxBillsCurrentBalance.Text = "0.0";
            textBoxBillsAmount.Text = "0.0";
            //textBoxBillsNewBalance.Text = "0.0";

            textBoxBillsCurrentBalance.Enabled = false;
            //textBoxBillsNewBalance.Enabled = false;

            lblName.Text = Fname;

            // Opening connection and check it ---------------------------------------------------------- Eliseo
            try
            {
                sqlConnection.Open();
                //MessageBox.Show("Welcome to the Bills Box");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // to load all the user ID ------------------------------------------------------------------ Eliseo

            SqlCommand cmdLoad = sqlConnection.CreateCommand();
            cmdLoad.CommandText = "Select UserId from Users";
            SqlDataReader reader = cmdLoad.ExecuteReader();

            while (reader.Read())
            {
                //comboBoxBillsUserID.Items.Add(reader[0].ToString());
            }

            reader.Close();

            try
            {
                // To load the amount from the DB ---------------------------------------------------------- Eliseo

                SqlCommand cmdCurrentBalance = sqlConnection.CreateCommand();
                cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@bal";
                cmdCurrentBalance.Parameters.AddWithValue("@bal", userID);
                reader = cmdCurrentBalance.ExecuteReader();

                if (reader.Read())
                {
                    textBoxBillsCurrentBalance.Text = reader[0].ToString();
                    //textBoxBillsNewBalance.Text = "0.0";
                }

                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxBillsUserID_SelectedIndexChanged(object sender, EventArgs e)
        {

            // To load the amount from the DB ---------------------------------------------------------- Eliseo

            SqlCommand cmdCurrentBalance = sqlConnection.CreateCommand();
            cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@bal";
            cmdCurrentBalance.Parameters.AddWithValue("@bal", userID);
            SqlDataReader reader = cmdCurrentBalance.ExecuteReader();

            if (reader.Read())
            {
                textBoxBillsCurrentBalance.Text = reader[0].ToString();
                //textBoxBillsNewBalance.Text = "0.0";
            }

            reader.Close();
        }

        private void buttonBillsPay_Click(object sender, EventArgs e)
        {
            String Type = "Bills";
            DateTime Date = DateTime.Now;
            decimal Amt = decimal.Parse(textBoxBillsAmount.Text);
            string Notes = (textBoxDescription.Text);

            decimal CurrentBalance = decimal.Parse(textBoxBillsCurrentBalance.Text);


            if (Amt <= 0)
            {
                MessageBox.Show("Amount must be > 0", "Bills");
                return;
            }

            // Get BILLS IDCount
            int IDcount = 0;
            SqlCommand cmdGet = sqlConnection.CreateCommand();
            cmdGet.CommandText = "SELECT Count(*) FROM BILLS";
            SqlDataReader reader = cmdGet.ExecuteReader();
            if (reader.Read())
            {
                //MessageBox.Show(reader[0].ToString());
                IDcount = (int)(reader[0]);
                reader.Close();

            }

            Date = DTPBillDate.Value;

            // sending a Bill value to the ( Stored Procedure ) to apply it on the database --------- NATE

            SqlCommand cmdNewBill = sqlConnection.CreateCommand();
            cmdNewBill.CommandText = "INSERT INTO BILLS(billId,name,amt,date,uId) VALUES(@tID,@Type,@Amt,@Date,@UserId)";
            //cmdNewBill.CommandType = CommandType.StoredProcedure;

            cmdNewBill.Parameters.AddWithValue("@tID", IDcount + 1);
            cmdNewBill.Parameters.AddWithValue("@Type", Type);
            cmdNewBill.Parameters.AddWithValue("@Date", Date);
            cmdNewBill.Parameters.AddWithValue("@Amt", Amt);
            cmdNewBill.Parameters.AddWithValue("@UserId", userID);

            cmdNewBill.ExecuteNonQuery();

            MessageBox.Show("The Bill has been scheduled");

            //Clear your parameters to make another operation if you want ------------------------------ Eliseo
            cmdNewBill.Parameters.Clear();

            //textBoxBillsNewBalance.Text = (CurrentBalance - Amt).ToString();

            //textBoxBillsCurrentBalance.Text = textBoxBillsNewBalance.Text;


            textBoxBillsAmount.Text = "0.0";

            textBoxDescription.Clear();
        }
        void ClearControls()
        {
            textBoxBillsCurrentBalance.Text = "0.0";
            textBoxBillsAmount.Text = "0.0";
            //textBoxBillsNewBalance.Text = "0.0";
        }

        private void buttonBillsDelete_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void buttonGoToWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void buttonGoToDeposit_Click(object sender, EventArgs e)
        {

        }

        private void buttonAllTransaction_Click(object sender, EventArgs e)
        {

        }
    }
}
