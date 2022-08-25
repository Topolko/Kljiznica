using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knjiznicaDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.knjiznicaDataSet.books);
            lb_Uname.Text = "Hello " + LUser.uname;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l1 = new login();
            l1.Show();
        }

        private void btn_trazi_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["KnjiznicaConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            SqlCommand cmd = new SqlCommand("SELECT * from books Where isbn = '" + tb_trazi.Text + "'", sqlconn);
            sqlconn.Open();

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlconn.Close();
        }
        int P_id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = dataGridView1.Rows[e.RowIndex].Cells["bookID"].FormattedValue.ToString();
            P_id = int.Parse(s);
        }
        

        private void btn_posudi_Click(object sender, EventArgs e)
        {
            KnjiznicaEntities context = new KnjiznicaEntities();
            var user = context.Korisniks.Where(a => a.username.Equals(LUser.uname)).FirstOrDefault();

            string mainconn = ConfigurationManager.ConnectionStrings["KnjiznicaConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            string sqlquery = ("INSERT INTO [dbo].[Posudeno] (book_id , user_id) VALUES (@book_id, @user_id); ");

            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            
            sqlcomm.Parameters.AddWithValue("@book_id", P_id);
            sqlcomm.Parameters.AddWithValue("@user_id", user.user_id);

            sqlcomm.ExecuteNonQuery();

            sqlconn.Close();
            MessageBox.Show("Knjiga posuđena!");

            sqlconn.Close();
        }

        private void btn_posudeno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pos P1 = new Pos();
            P1.Show();
        }

        private void btn_vraceno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vra V1 = new Vra();
            V1.Show();
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login l1 = new login();
            l1.Show();
        }
    }
}
