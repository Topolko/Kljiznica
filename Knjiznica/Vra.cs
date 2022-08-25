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
    public partial class Vra : Form
    {
        public Vra()
        {
            InitializeComponent();
            
        }

        private void Vra_Load(object sender, EventArgs e)
        {
            KnjiznicaEntities context = new KnjiznicaEntities();
            var user = context.Korisniks.Where(a => a.username.Equals(LUser.uname)).FirstOrDefault();

            string mainconn = ConfigurationManager.ConnectionStrings["KnjiznicaConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            SqlCommand cmd = new SqlCommand("SELECT * from vraceno inner join [dbo].[books] on bookID = book_id inner join [dbo].[Korisnik] on vraceno.user_id = Korisnik.user_id WHERE vraceno.user_id = '" + user.user_id + "';", sqlconn);
            sqlconn.Open();

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(dt);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;

            sqlconn.Close();
        }
        int P_id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = dataGridView1.Rows[e.RowIndex].Cells["bookID"].FormattedValue.ToString();
            P_id = int.Parse(s);
        }
        private void btn_brisi_Click(object sender, EventArgs e)
        {

            KnjiznicaEntities context = new KnjiznicaEntities();
            var user = context.Korisniks.Where(a => a.username.Equals(LUser.uname)).FirstOrDefault();

            string mainconn = ConfigurationManager.ConnectionStrings["KnjiznicaConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            string sqlquery = ("DELETE from vraceno where book_id = '" + P_id + "' SELECT * from vraceno inner join[dbo].[books] on bookID = book_id inner join[dbo].[Korisnik] on vraceno.user_id = Korisnik.user_id");

            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);

            sqlcomm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlcomm);


            da.Fill(dt);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;

            

            sqlconn.Close();
            MessageBox.Show("zapis izbrisan!!");

        }

        private void btn_trazi_Click(object sender, EventArgs e)
        {
            
            string mainconn = ConfigurationManager.ConnectionStrings["KnjiznicaConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            sqlconn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from vraceno inner join[dbo].[books] on bookID = book_id inner join[dbo].[Korisnik] on Posudeno.user_id = Korisnik.user_id Where isbn = '" + tb_trazi.Text + "'", sqlconn);


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlconn.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm M = new MainForm();
            M.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l1 = new login();
            l1.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
