using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhoaLuan.DB;

namespace KhoaLuan
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  question yes no
            if (MessageBox.Show("Bạn có muốn thêm người dùng?", "Thêm người dùng", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            #region Validate
            
            if(txtUserName.Text == null || txtUserName.Text.ToString() == ""
                || txtPass.Text == null || txtPass.Text.ToString() == ""
                || txtRePass.Text == null || txtRePass.Text.ToString() == ""
                || txtFullName.Text == null || txtFullName.Text.ToString() == ""
                || txtCMT.Text == null || txtCMT.Text.ToString() == ""
                || txtAddress.Text == null || txtAddress.Text.ToString() == ""
                || dtpBirth.Value == null)
            {
                MessageBox.Show("Thêm người dùng không thành công, bạn vui lòng nhập đủ thông tin.", "Thêm người dùng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPass.Text.ToString() != txtRePass.Text.ToString())
            {
                MessageBox.Show("Thêm người dùng không thành công, vui lòng nhập lại mật khẩu", "Thêm người dùng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            Account newUser = new Account();
            newUser.UserName = txtUserName.Text.ToString();
            newUser.PassWord = txtPass.Text.ToString();
            newUser.FullName = txtFullName.Text.ToString();
            newUser.IDNumber = txtCMT.Text.ToString();
            newUser.Address = txtAddress.Text.ToString();
            newUser.BirthDay = dtpBirth.Value.ToShortDateString();
            newUser.Status = 1;

            bool isAdd = DbManager.addUser(newUser);
            if (isAdd == false)
            {
                MessageBox.Show("Thêm người dùng không thành công, tên đăng nhập đã tồn tại trong hệ thống", "Thêm người dùng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thành công", "Thêm người dùng", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }
    }
}
