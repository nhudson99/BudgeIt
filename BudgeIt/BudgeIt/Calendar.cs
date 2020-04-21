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
                String d = monthCalendar1.SelectionRange.Start.ToShortDateString();
                SqlCommand cmdGetName = sqlConnection.CreateCommand();
                float income=0, disposable=0, expense=0;

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
                        expense = float.Parse(reader[0].ToString());
                    else
                    {
                        Expenses.Text = "$0";
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
                        income = float.Parse(reader[0].ToString());
                    else
                    {
                        Income.Text = "$0";
                    }
                }
                reader.Close();

                Disposable.Text = String.Format("{0:$##.00}", (income-expense));
                Income.Text = String.Format("{0:$##.00}", income);
                Expenses.Text = String.Format("{0:$##.00}", expense);


                SqlCommand cmdGetTrans = sqlConnection.CreateCommand();
                cmdGetTrans.CommandText = "SELECT type, amt FROM [Transactions] WHERE uId = @uID AND date = @d";
                cmdGetTrans.Parameters.AddWithValue("@uID", userID);
                cmdGetTrans.Parameters.AddWithValue("@d", d);

                reader = cmdGetTrans.ExecuteReader();

                while(reader.Read())
                {
                    
                    string s = String.Format("Type:{0}\tAmount:{1:$##.00}",reader["type"],reader["amt"]);
                    
                    LBTrans.Items.Add(s);

                }

                reader.Close();

                SqlCommand cmdGetBills = sqlConnection.CreateCommand();
                cmdGetBills.CommandText = "SELECT note, amt FROM [Bills] WHERE uId = @uID AND date = @d";
                cmdGetBills.Parameters.AddWithValue("@uID", userID);
                cmdGetBills.Parameters.AddWithValue("@d", d);

                reader = cmdGetBills.ExecuteReader();

                while (reader.Read())
                {

                    string s = String.Format("Note:{0}\tAmount:{1:$##.00}", reader["note"], reader["amt"]);

                    LBBills.Items.Add(s);

                }
                reader.Close();

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
            depo.userID = userID;
            depo.Fname = Fname;
            depo.ShowDialog();
            Reload();
            
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw with = new Withdraw();
            with.sqlConnection.ConnectionString = sqlConnection.ConnectionString;
            with.userID = userID;
            with.Fname = Fname;
            with.ShowDialog();
            Reload();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            Bills bill = new Bills();
            bill.sqlConnection.ConnectionString = sqlConnection.ConnectionString;
            bill.Fname = Fname;
            bill.userID = userID;
            bill.ShowDialog();
            Reload();
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
            t.Fname = Fname;
            t.userID = userID;
            t.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            LBTrans.Items.Clear();
            LBBills.Items.Clear();

            float income=0, expense = 0;
            SqlDataReader reader;
            String d = monthCalendar1.SelectionRange.Start.ToShortDateString();

            SqlCommand cmdGetExpenses = sqlConnection.CreateCommand();
            cmdGetExpenses.CommandText = "SELECT SUM(amt) FROM BILLS WHERE uId = @uID";
            cmdGetExpenses.Parameters.AddWithValue("@uID", userID);

            reader = cmdGetExpenses.ExecuteReader();

            if (reader.Read())
            {
                //MessageBox.Show(reader[0].ToString());
                if (reader[0] != DBNull.Value)
                    expense = float.Parse(reader[0].ToString());
                else
                {
                    Expenses.Text = "$0";
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
                    income = float.Parse(reader[0].ToString());
                else
                {
                    Income.Text = "$0";
                }
            }
            reader.Close();

            Disposable.Text = String.Format("{0:$##.00}", (income - expense));
            Income.Text = String.Format("{0:$##.00}", income);
            Expenses.Text = String.Format("{0:$##.00}", expense);

            SqlCommand cmdGetTrans = sqlConnection.CreateCommand();
            cmdGetTrans.CommandText = "SELECT type, amt FROM [Transactions] WHERE uId = @uID AND date = @d";
            cmdGetTrans.Parameters.AddWithValue("@uID", userID);
            cmdGetTrans.Parameters.AddWithValue("@d", d);

            reader = cmdGetTrans.ExecuteReader();

            while (reader.Read())
            {

                string s = String.Format("Type:{0}\tAmount:{1:$##.00}", reader["type"], reader["amt"]);

                LBTrans.Items.Add(s);

            }

            reader.Close();

            SqlCommand cmdGetBills = sqlConnection.CreateCommand();
            cmdGetBills.CommandText = "SELECT note, amt FROM [Bills] WHERE uId = @uID AND date = @d";
            cmdGetBills.Parameters.AddWithValue("@uID", userID);
            cmdGetBills.Parameters.AddWithValue("@d", d);

            reader = cmdGetBills.ExecuteReader();

            while (reader.Read())
            {

                string s = String.Format("Note:{0}\tAmount:{1:$##.00}", reader["note"], reader["amt"]);

                LBBills.Items.Add(s);

            }
            reader.Close();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule s = new Schedule();
            s.sqlConnection.ConnectionString = sqlConnection.ConnectionString;
            s.Fname = Fname;
            s.userID = userID;
            s.ShowDialog();
            Reload();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {


            Reload();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Disposable_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Expenses_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
