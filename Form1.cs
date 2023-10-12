using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "rolly")
            {
                if (TxtPassword.Text == "12345")
                {
                    MessageBox.Show("Anda berhasil login");
                }
                else
                {
                    TxtPasswordError.Text = TxtPassword.Text;
                    TxtPasswordError.Visible = true;
                    TxtPassword.Visible = false;
                    
                }

            }else
            {
                TxtUsernameError.Text = TxtUsername.Text;
                TxtUsernameError.Visible = true;
                TxtUsername.Visible = false;
            }
        }

        private void LblDaftar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buat akun");
        }

        private void ChBShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ChBShowPassword.Checked==true) 
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar=true;

            }
        }
    }
}
