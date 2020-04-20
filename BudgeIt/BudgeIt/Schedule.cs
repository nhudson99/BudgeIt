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
    public partial class Schedule : Form
    {
        public int userID;
        public string Fname;
        public SqlConnection sqlConnection = new SqlConnection();
        public Schedule()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            lblName.Text = Fname;

            sqlConnection.Open();

            DateTime d = DateTime.Now;

            SqlCommand cmdCurrentBalance = sqlConnection.CreateCommand();
            cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@id";
            cmdCurrentBalance.Parameters.AddWithValue("@id", userID);
            SqlDataReader reader1 = cmdCurrentBalance.ExecuteReader();

            while (reader1.Read())
            {
                txtBalance.Text = String.Format("{0:$##.00}", reader1[0]);
                //txtBalance.Text = String.Format("0:##.00",txtBalance.Text);
            }

            reader1.Close();

            SqlCommand cmdload = sqlConnection.CreateCommand();
            cmdload.CommandText = "Select * from [Bills] where uId= @id AND date > @date";
            cmdload.Parameters.AddWithValue("@id", userID);
            cmdload.Parameters.AddWithValue("@date", d);
            SqlDataReader reader = cmdload.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            table.Columns.RemoveAt(table.Columns.Count - 1);
            dataGridView1.DataSource = table;


            reader.Close();
        }

        private void rbtnUpcoming_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnUpcoming.Checked)
            {
                Reload(0);
            }
        }

        private void Reload(int choice)
        {
            if(choice == 0)
            {
                //MessageBox.Show("Upcoming");
                //sqlConnection.Open();

                DateTime d = DateTime.Now;

                SqlCommand cmdCurrentBalance = sqlConnection.CreateCommand();
                cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@id";
                cmdCurrentBalance.Parameters.AddWithValue("@id", userID);
                SqlDataReader reader1 = cmdCurrentBalance.ExecuteReader();

                while (reader1.Read())
                {
                    txtBalance.Text = String.Format("{0:$##.00}", reader1[0]);
                    //txtBalance.Text = String.Format("0:##.00",txtBalance.Text);
                }

                reader1.Close();

                SqlCommand cmdload = sqlConnection.CreateCommand();
                cmdload.CommandText = "Select * from [Bills] where uId= @id AND date > @date";
                cmdload.Parameters.AddWithValue("@id", userID);
                cmdload.Parameters.AddWithValue("@date", d);
                SqlDataReader reader = cmdload.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                table.Columns.RemoveAt(table.Columns.Count - 1);
                dataGridView1.DataSource = table;


                reader.Close();
            }
            else if(choice == 1)
            {
                //MessageBox.Show("All");
                //sqlConnection.Open();

                DateTime d = DateTime.Now;

                SqlCommand cmdCurrentBalance = sqlConnection.CreateCommand();
                cmdCurrentBalance.CommandText = "Select Bal from Users where UserId =@id";
                cmdCurrentBalance.Parameters.AddWithValue("@id", userID);
                SqlDataReader reader1 = cmdCurrentBalance.ExecuteReader();

                while (reader1.Read())
                {
                    txtBalance.Text = String.Format("{0:$##.00}", reader1[0]);
                    //txtBalance.Text = String.Format("0:##.00",txtBalance.Text);
                }

                reader1.Close();

                SqlCommand cmdload = sqlConnection.CreateCommand();
                cmdload.CommandText = "Select * from [Bills] where uId= @id";
                cmdload.Parameters.AddWithValue("@id", userID);
                //cmdload.Parameters.AddWithValue("@date", d);
                SqlDataReader reader = cmdload.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                table.Columns.RemoveAt(table.Columns.Count - 1);
                dataGridView1.DataSource = table;


                reader.Close();
            }
        }

        private void rBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnAll.Checked)
            {
                Reload(1);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(numID.Value.ToString());

            SqlCommand cmdRemoveBill = sqlConnection.CreateCommand();
            cmdRemoveBill.CommandText = "DELETE FROM BILLS WHERE billId = @num";
            cmdRemoveBill.Parameters.AddWithValue("@num", id);

            cmdRemoveBill.ExecuteNonQuery();

            if (rbtnUpcoming.Checked)
            {
                Reload(0);
            }
            else if(rBtnAll.Checked)
            {
                Reload(1);
            }
        }
    }
}
