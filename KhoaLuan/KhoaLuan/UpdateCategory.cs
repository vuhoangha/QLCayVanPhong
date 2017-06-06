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
    public partial class UpdateCategory : Form
    {
        Category CAT_UPDATE;

        public UpdateCategory(Category update)
        {
            InitializeComponent();
            CAT_UPDATE = update;

            //  load data
            txtTypeName.Text = CAT_UPDATE.CatName;
        }

        private void btnImportAddTree_Click(object sender, EventArgs e)
        {
            //  question yes no
            if (MessageBox.Show("Bạn có muốn cập nhật nhóm cây?", "Cập nhật nhóm cây", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            //  check validate
            if (txtTypeName.Text == string.Empty)
            {
                MessageBox.Show("Cập nhật loại cây không thành công, bạn vui lòng nhập đủ thông tin.", "Cập nhật loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check id is valid ?
            Category catById = DbManager.GetCategoryById(CAT_UPDATE.CatId);
            if (catById == null)
            {
                MessageBox.Show("Cập nhật loại cây không thành công, loại cây bạn muốn cập nhật không tồn tại trong hệ thống.", "Cập nhật loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  check name is valid ?
            Category catTemp = DbManager.GetCatByNameNotId(CAT_UPDATE.CatId, txtTypeName.Text.ToUpper());
            if (catTemp != null)
            {
                MessageBox.Show("Cập nhật loại cây không thành công, loại cây bạn muốn thêm đã tồn tại trong hệ thống.", "Cập nhật loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Category updateCat = new Category();
            //  cat id
            updateCat.CatId = CAT_UPDATE.CatId;
            //  cat name
            updateCat.CatName = txtTypeName.Text.ToUpper();

            //  add to db
            if (DbManager.updateCat(updateCat, CAT_UPDATE.CatId))
            {
                this.Close();
                MessageBox.Show("Thành công", "Cập nhật loại cây", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Cập nhật loại cây không thành công, bạn vui lòng chỉnh sửa lại thông tin loại cây muốn cập nhật.", "Cập nhật loại cây",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
