using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        

        private void login_Load(object sender, EventArgs e)
        {

        }

      

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            KnjiznicaEntities context = new KnjiznicaEntities();
            if (tb_username.Text != string.Empty || tb_password.Text != string.Empty)
            {
                var user = context.Korisniks.Where(a => a.username.Equals(tb_username.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.password == tb_password.Text)
                    {

                        LUser.uname = user.username;
                        LUser.id = user.user_id;
                        MainForm M = new MainForm();
                        M.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password incorect", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Username incorect", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Username and password required", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_register_Click_1(object sender, EventArgs e)
        {
            Register r1 = new Register();
            r1.Show();
            Hide();
        }
    }
}
