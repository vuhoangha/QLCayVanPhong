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
    public partial class updateUser : Form
    {
        Account UPDATE;

        public updateUser(Account updateUser)
        {
            InitializeComponent();

            UPDATE = updateUser;

            #region Load data

            lbUserName.Text = updateUser.UserName;
            txtPass.Text = updateUser.PassWord;
            txtFullName.Text = updateUser.FullName;
            txtCMT.Text = updateUser.IDNumber;
            txtAddress.Text = updateUser.Address;

            DateTime myDate;
            if (!DateTime.TryParse(updateUser.BirthDay, out myDate))
            {
                // handle parse failure
            }
            else
            {
                dtpBirth.Value = DateTime.Parse(updateUser.BirthDay);
            }

            #endregion
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  question yes no
            if (MessageBox.Show("Bạn có cập nhật người dùng?", "Cập nhật người dùng", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            #region Validate

            if (txtPass.Text == null || txtPass.Text.ToString() == ""
                || txtRePass.Text == null || txtRePass.Text.ToString() == ""
                || txtFullName.Text == null || txtFullName.Text.ToString() == ""
                || txtCMT.Text == null || txtCMT.Text.ToString() == ""
                || txtAddress.Text == null || txtAddress.Text.ToString() == ""
                || dtpBirth.Value == null)
            {
                MessageBox.Show("Cập nhật người dùng không thành công, bạn vui lòng nhập đủ thông tin.", "Cập nhật người dùng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPass.Text.ToString() != txtRePass.Text.ToString())
            {
                MessageBox.Show("Cập nhật người dùng không thành công, vui lòng nhập lại mật khẩu", "Cập nhật người dùng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            Account newUser = new Account();
            newUser.UserName = UPDATE.UserName;
            newUser.UserId = UPDATE.UserId;
            newUser.PassWord = txtPass.Text.ToString();
            newUser.FullName = txtFullName.Text.ToString();
            newUser.IDNumber = txtCMT.Text.ToString();
            newUser.Address = txtAddress.Text.ToString();
            newUser.BirthDay = dtpBirth.Value.ToShortDateString();
            newUser.Status = 1;

            bool isAdd = DbManager.updateUser(newUser);
            if (isAdd == false)
            {
                MessageBox.Show("Cập nhật người dùng không thành công, tên đăng nhập đã tồn tại trong hệ thống", "Cập nhật người dùng",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thành công", "Cập nhật người dùng", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }
    }
}
