using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhoaLuan.DB;

namespace KhoaLuan
{
    public partial class Login : UserControl
    {

        Func<bool> LoginCabk = null;
        public static Account USER_LOGIN;

        public Login(Func<bool> _loginCabk)
        {
            LoginCabk = _loginCabk;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account user = DbManager.Login(txtUserName.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                USER_LOGIN = user;
                LoginCabk();
            }
        }
    }
}
