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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw with = new Withdraw();
            with.sqlConnection1 = sqlConnection;
            with.ShowDialog();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            Bills bill = new Bills();
            bill.sqlConnection = sqlConnection;
            bill.ShowDialog();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            Transactions t = new Transactions();
            t.sqlConnection = sqlConnection;
            t.ShowDialog();
        }
    }
}
