using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Knjiznica
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
 
        private void btn_submit_Click_1(object sender, EventArgs e)
        {
            bool AU = true;
            KnjiznicaEntities context = new KnjiznicaEntities();

            if (tb_username.Text != string.Empty || tb_password.Text != string.Empty)
            {
                var user = context.Korisniks.Where(a => a.username.Equals(tb_username.Text)).FirstOrDefault();
                while (user != null)
                {
                    if (user.username == tb_username.Text)
                    {
                        MessageBox.Show("username already in use");
                        AU = false;
                        break;
                    }
                    



                }
                if (AU == true)
                {

                    string mainconn = ConfigurationManager.ConnectionStrings["KnjiznicaConnectionString"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery = "insert into [dbo].[Korisnik] values (@username,@password) ";
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                    sqlcomm.Parameters.AddWithValue("@username", tb_username.Text);
                    sqlcomm.Parameters.AddWithValue("@password", tb_password.Text);

                    sqlcomm.ExecuteNonQuery();
                    MessageBox.Show("user is succesfuly saved");
                    sqlconn.Close();
                    this.Hide();
                    login l1 = new login();
                    l1.Show();
                }




            }
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
