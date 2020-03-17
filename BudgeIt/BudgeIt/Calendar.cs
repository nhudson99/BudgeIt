using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BudgeIt
{
    public partial class Calendar : Form
    {
        public SqlConnection sqlConnection = new SqlConnection();

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
                cmdGetName.Parameters.AddWithValue("@uID", 1);


                SqlDataReader reader = cmdGetName.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Worked");
                    LBLName.Text = reader[0].ToString();

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
            depo.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withd = new Withdraw();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //Word.Cell cell = this.table[1].Cell(1, 1);

            //cell.Range.Text = "Mon";
            //cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            
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
    }
}
