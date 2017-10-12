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
    public partial class UpdateTreeBill : Form
    {
        private Tree UPDATE_TREE;
        Func<int, bool> callBackTree = null;

        public UpdateTreeBill(Tree updateTree, int quantity, Func<int, bool> callback)
        {
            InitializeComponent();

            //  callback
            callBackTree = callback;

            //  assign
            UPDATE_TREE = updateTree;

            //  init data
            lbBillTreeId.Text = updateTree.TreeId.ToString();
            lbBillTreeName.Text = updateTree.TreeName;
            nudBillTreeQuantity.Maximum = (decimal)updateTree.Quantity;
            nudBillTreeQuantity.Value = quantity;
            lbBillTotalCostTree.Text = DbManager.convertToMoney((updateTree.Cost * quantity).ToString());
        }

        private void btnBillUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
            callBackTree((int)nudBillTreeQuantity.Value);
        }

        private void nudBillTreeQuantity_ValueChanged(object sender, EventArgs e)
        {
            lbBillTotalCostTree.Text = DbManager.convertToMoney((UPDATE_TREE.Cost * nudBillTreeQuantity.Value).ToString());
        }
    }
}
