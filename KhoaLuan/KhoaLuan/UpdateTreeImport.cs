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
    public partial class UpdateTreeImport : Form
    {
        Func<int, int, bool> callbackUpdate;
        Tree TREE_UPDATE;

        public UpdateTreeImport(Tree updateTree, int quantity, int cost, Func<int, int, bool> callback)
        {
            InitializeComponent();

            //  assign value
            lbImportTreeId.Text = updateTree.TreeId.ToString();
            lbImportTreeName.Text = updateTree.TreeName;
            nudImportTreeQuantity.Value = quantity;
            txtCost.Text = cost.ToString();
            lbTotalCost.Text = (nudImportTreeQuantity.Value * Int32.Parse(txtCost.Text)).ToString();

            //  assign tree
            TREE_UPDATE = updateTree;

            //  assign callback
            callbackUpdate = callback;
        }

        private void nudImportTreeQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (txtCost.Text == "" || txtCost.Text == null) return;
            lbTotalCost.Text = DbManager.convertToMoney((nudImportTreeQuantity.Value * Int32.Parse(txtCost.Text)).ToString());
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            if (txtCost.Text == "" || txtCost.Text == null) return;

            if (!txtCost.Text.All(char.IsDigit))
            {
                MessageBox.Show("Giá của cây phải là số", "Chỉnh sửa thông tin cây nhập vào",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbTotalCost.Text = DbManager.convertToMoney((nudImportTreeQuantity.Value * Int32.Parse(txtCost.Text)).ToString());
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (txtCost.Text == "" || txtCost.Text == null)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Chỉnh sửa thông tin cây nhập vào",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtCost.Text.All(char.IsDigit))
            {
                MessageBox.Show("Giá của cây phải là số", "Chỉnh sửa thông tin cây nhập vào",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Int32.Parse(txtCost.Text) <= 0)
            {
                MessageBox.Show("Giá của cây phải lớn hơn 0", "Chỉnh sửa thông tin cây nhập vào",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            callbackUpdate((int)nudImportTreeQuantity.Value, Int32.Parse(txtCost.Text));
            this.Close();
        }
    }
}
