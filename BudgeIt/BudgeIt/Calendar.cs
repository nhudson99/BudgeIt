using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BudgeIt
{
    public partial class Calendar : Form
    {
        public SqlConnection sqlConnection = new SqlConnection();
        public int userID;
        public string Fname;

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmdGetName = sqlConnection.CreateCommand();

                cmdGetName.CommandText = "SELECT Fname FROM USERS WHERE userId = @uID";
                cmdGetName.Parameters.AddWithValue("@uID", userID);


                SqlDataReader reader = cmdGetName.ExecuteReader();

                if (reader.Read())
                {
                    //MessageBox.Show("Worked");
                    LBLName.Text = reader[0].ToString();
                    Fname = reader[0].ToString();
                }
                reader.Close();

                SqlCommand cmdGetExpenses = sqlConnection.CreateCommand();
                cmdGetExpenses.CommandText = "SELECT SUM(amt) FROM BILLS WHERE uId = @uID";
                cmdGetExpenses.Parameters.AddWithValue("@uID", userID);

                reader = cmdGetExpenses.ExecuteReader();

                if(reader.Read())
                {
                    //MessageBox.Show(reader[0].ToString());
                    if(reader[0] != DBNull.Value)
                        Expenses.Text = reader[0].ToString();
                    else
                    {
                        Expenses.Text = "0";
                    }
                }
                reader.Close();

                SqlCommand cmdGetIncome = sqlConnection.CreateCommand();
                cmdGetIncome.CommandText = "SELECT Bal FROM USERS WHERE UserId = @uID";
                cmdGetIncome.Parameters.AddWithValue("@uID", userID);

                reader = cmdGetIncome.ExecuteReader();

                if (reader.Read())
                {
                    //MessageBox.Show(reader[0].ToString());
                    if (reader[0] != DBNull.Value)
                        Income.Text = reader[0].ToString();
                    else
                    {
                        Income.Text = "0";
                    }
                }
                reader.Close();

                Disposable.Text = (float.Parse(Income.Text) - float.Parse(Expenses.Text)).ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.sqlConnection1.ConnectionString = sqlConnection.ConnectionString;
            depo.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw with = new Withdraw();
            with.sqlConnection.ConnectionString = sqlConnection.ConnectionString;
            with.ShowDialog();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            Bills bill = new Bills();
            bill.sqlConnection.ConnectionString = sqlConnection.ConnectionString;
            bill.Fname = Fname;
            bill.userID = userID;
            bill.ShowDialog();
        }

        private void CalendarTable_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Expenses_TextChange(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("");
            con1.Open();

            SqlCommand cmd1 = new SqlCommand("", con1);
            cmd1.Parameters.AddWithValue("", int.Parse(Expenses.Text));
            SqlDataReader da1 = cmd1.ExecuteReader();

            con1.Close();
        }

        private void Disposable_TextChange(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("");
            con2.Open();

            SqlCommand cmd2 = new SqlCommand("", con2);
            cmd2.Parameters.AddWithValue("", int.Parse(Disposable.Text));
            SqlDataReader da2 = cmd2.ExecuteReader();

            con2.Close();
        }

        private void Income_TextChange(object sender, EventArgs e)
        {
            SqlConnection con3 = new SqlConnection("");
            con3.Open();

            SqlCommand cmd3 = new SqlCommand("", con3);
            cmd3.Parameters.AddWithValue("", int.Parse(Income.Text));
            SqlDataReader da3 = cmd3.ExecuteReader();

            con3.Close();
        }

        private void Name_TextChange(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection("");
            con4.Open();

            SqlCommand cmd4 = new SqlCommand("", con4);
            cmd4.Parameters.AddWithValue("", LBLName.Text);
            SqlDataReader da4 = cmd4.ExecuteReader();

            con4.Close();
        }

        private void btnTrans_Click_1(object sender, EventArgs e)
        {
            Transactions t = new Transactions();
            t.sqlConnection.ConnectionString = sqlConnection.ConnectionString;
            t.ShowDialog();
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            Transactions t = new Transactions();
            t.sqlConnection.ConnectionString = sqlConnection.ConnectionString;
            t.ShowDialog();
        }
    }
}
