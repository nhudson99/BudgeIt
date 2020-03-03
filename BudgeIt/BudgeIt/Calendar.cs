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
            Word.Cell cell = this.table[1].Cell(1, 1);

            cell.Range.Text = "Mon";
            cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
        }
    }
}
