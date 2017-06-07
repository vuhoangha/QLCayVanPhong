using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using KhoaLuan.DB;
using System.Text.RegularExpressions;

namespace KhoaLuan
{
    public partial class AddBill : Form
    {
        SelectTreeBill addTree;
        int? ID_TREE_SELECTED;
        DataGridViewRow ROW_SELECTED;

        public AddBill()
        {
            InitializeComponent();
        }

        private void AddBill_Load(object sender, EventArgs e)
        {
            #region Load data

            #region load combobox treename

            List<Tree> listTree = DbManager.GetAllTree();


            #endregion

            #endregion
        }

        private void btnBillAddTree_Click(object sender, EventArgs e)
        {
            addTree = new SelectTreeBill(addTreeCallBack);
            addTree.Show();
        }

        private bool updateTreeCallBack(int count)
        {
            Tree currTree = DbManager.GetTreeById((int)ID_TREE_SELECTED);
            ROW_SELECTED.Cells[2].Value = count;
            ROW_SELECTED.Cells[3].Value = (count * currTree.Cost).ToString();
            refreshDgvAddBill();
            calculateTotalCost();
            return true;
        }

        private void refreshDgvAddBill()
        {
            dgvAddBill.Refresh();
            if (dgvAddBill.RowCount >= 2)
            {
                dgvAddBill.Rows[0].Selected = true;
                DataGridViewRow row = dgvAddBill.Rows[0];
                ID_TREE_SELECTED = (int)row.Cells[0].Value;
                ROW_SELECTED = dgvAddBill.Rows[0];
            }
            else
            {
                ID_TREE_SELECTED = null;
                ROW_SELECTED = null;
            }
        }

        private bool addTreeCallBack(Tree selected, int count)
        {
            try
            {
                Tree currTree = DbManager.GetTreeById(selected.TreeId);
                if (dgvAddBill.RowCount > 1)
                {
                    //  check tree duplicate
                    foreach (DataGridViewRow row in dgvAddBill.Rows)
                    {
                        if (row.Index >= 0 && row.Index < dgvAddBill.RowCount - 1 && (int)row.Cells[0].Value == selected.TreeId)
                        {
                            var totalTreeBuy = Int32.Parse(row.Cells[2].Value.ToString()) + count;
                            if (currTree.Quantity < totalTreeBuy)
                            {
                                MessageBox.Show("Thêm cây không thành công, cửa hàng chỉ còn " + currTree.Quantity + " cây", "Chọn cây",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            else
                            {
                                row.Cells[2].Value = totalTreeBuy;
                                row.Cells[3].Value = totalTreeBuy * currTree.Cost;
                                addTree.Close();
                            }
                            calculateTotalCost();
                            return true;
                        }
                    }
                }

                //  add new tree
                if (count > currTree.Quantity)
                {
                    MessageBox.Show("Thêm cây không thành công, cửa hàng chỉ còn " + currTree.Quantity + " cây", "Chọn cây",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgvAddBill);  // this line was missing
                newRow.Cells[0].Value = selected.TreeId;
                newRow.Cells[1].Value = selected.TreeName;
                newRow.Cells[2].Value = count;
                newRow.Cells[3].Value = selected.Cost * count;
                dgvAddBill.Rows.Add(newRow);
                refreshDgvAddBill();

                addTree.Close();
                calculateTotalCost();
                return true;
            }
            catch (Exception)
            {
                addTree.Close();
                return false;
                throw;
            }
        }

        private void dgvAddBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //  check row valid
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex > dgv.RowCount - 2)
            {
                ID_TREE_SELECTED = null;
                return;
            }

            DataGridViewRow row = dgvAddBill.Rows[e.RowIndex];
            ROW_SELECTED = dgvAddBill.Rows[e.RowIndex];
            ID_TREE_SELECTED = (int)row.Cells[0].Value;
        }

        private void calculateTotalCost()
        {
            var totalCost = 0;
            foreach (DataGridViewRow row in dgvAddBill.Rows)
            {
                if (row.Index >= 0 && row.Index < dgvAddBill.RowCount - 1)
                {
                    totalCost += Int32.Parse(row.Cells[3].Value.ToString());
                }
            }
            lbAddBillToTalBill.Text = totalCost.ToString();
        }

        private void btnBillDel_Click(object sender, EventArgs e)
        {
            //  question yes no
            if (MessageBox.Show("Bạn có muốn xóa cây khỏi hóa đơn?", "Tạo hóa đơn", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            dgvAddBill.Rows.RemoveAt(ROW_SELECTED.Index);
            refreshDgvAddBill();
            calculateTotalCost();
        }

        private void createBillPdf(Bill currBill)
        {

            #region Bill_Id

            DataGridViewRow billId = new DataGridViewRow();
            billId.CreateCells(dgvPdf);  // this line was missing
            billId.Cells[0].Value = ConvertToUnsign3("Mã hóa đơn");
            billId.Cells[1].Value = currBill.BillId;
            billId.Cells[2].Value = " ";
            billId.Cells[3].Value = " ";
            dgvPdf.Rows.Add(billId);

            #endregion

            #region time

            DataGridViewRow timeBill = new DataGridViewRow();
            timeBill.CreateCells(dgvPdf);  // this line was missing
            timeBill.Cells[0].Value = ConvertToUnsign3("Thời gian");
            timeBill.Cells[1].Value = currBill.TimeChanged;
            timeBill.Cells[2].Value = " ";
            timeBill.Cells[3].Value = " ";
            dgvPdf.Rows.Add(timeBill);

            #endregion

            #region Customer_Name

            DataGridViewRow cusName = new DataGridViewRow();
            cusName.CreateCells(dgvPdf);  // this line was missing
            cusName.Cells[0].Value = ConvertToUnsign3("Tên khách hàng");
            cusName.Cells[1].Value = ConvertToUnsign3(txtCustomerName.Text);
            cusName.Cells[2].Value = " ";
            cusName.Cells[3].Value = " ";
            dgvPdf.Rows.Add(cusName);

            #endregion

            #region Customer_ID

            DataGridViewRow cusId = new DataGridViewRow();
            cusId.CreateCells(dgvPdf);  // this line was missing
            cusId.Cells[0].Value = "CMT";
            cusId.Cells[1].Value = ConvertToUnsign3(txtCustomerId.Text);
            cusId.Cells[2].Value = " ";
            cusId.Cells[3].Value = " ";
            dgvPdf.Rows.Add(cusId);

            #endregion

            #region Customer_Address

            DataGridViewRow cusAdd = new DataGridViewRow();
            cusAdd.CreateCells(dgvPdf);  // this line was missing
            cusAdd.Cells[0].Value = ConvertToUnsign3("Địa chỉ");
            cusAdd.Cells[1].Value = ConvertToUnsign3(txtAddress.Text);
            cusAdd.Cells[2].Value = " ";
            cusAdd.Cells[3].Value = " ";
            dgvPdf.Rows.Add(cusAdd);

            #endregion

            #region Fake

            DataGridViewRow fake = new DataGridViewRow();
            fake.CreateCells(dgvPdf);
            fake.Cells[0].Value = " ";
            fake.Cells[1].Value = " ";
            fake.Cells[2].Value = " ";
            fake.Cells[3].Value = " ";
            dgvPdf.Rows.Add(fake);

            #endregion

            #region Add Header

            DataGridViewRow header = new DataGridViewRow();
            header.CreateCells(dgvPdf);  // this line was missing
            header.Cells[0].Value = ConvertToUnsign3("Mã cây");
            header.Cells[1].Value = ConvertToUnsign3("Tên cây");
            header.Cells[2].Value = ConvertToUnsign3("Số lượng");
            header.Cells[3].Value = ConvertToUnsign3("Thành tiền");
            dgvPdf.Rows.Add(header);

            #endregion

            #region addDetail

            foreach (DataGridViewRow row in dgvAddBill.Rows)
            {
                if (row.Index >= 0 && row.Index < dgvAddBill.RowCount - 1)
                {
                    DataGridViewRow detailRow = new DataGridViewRow();
                    detailRow.CreateCells(dgvPdf);  // this line was missing
                    detailRow.Cells[0].Value = ConvertToUnsign3(row.Cells[0].Value.ToString());
                    detailRow.Cells[1].Value = ConvertToUnsign3(row.Cells[1].Value.ToString());
                    detailRow.Cells[2].Value = ConvertToUnsign3(row.Cells[2].Value.ToString());
                    detailRow.Cells[3].Value = ConvertToUnsign3(row.Cells[3].Value.ToString());
                    dgvPdf.Rows.Add(detailRow);
                }
            }

            #endregion

            #region Fake1

            DataGridViewRow fake1 = new DataGridViewRow();
            fake1.CreateCells(dgvPdf);
            fake1.Cells[0].Value = " ";
            fake1.Cells[1].Value = " ";
            fake1.Cells[2].Value = " ";
            fake1.Cells[3].Value = " ";
            dgvPdf.Rows.Add(fake1);

            DataGridViewRow fake2 = new DataGridViewRow();
            fake2.CreateCells(dgvPdf);
            fake2.Cells[0].Value = " ";
            fake2.Cells[1].Value = " ";
            fake2.Cells[2].Value = " ";
            fake2.Cells[3].Value = " ";
            dgvPdf.Rows.Add(fake2);

            #endregion

            #region TotalCost

            DataGridViewRow totalCost = new DataGridViewRow();
            totalCost.CreateCells(dgvPdf);  // this line was missing
            totalCost.Cells[0].Value = " ";
            totalCost.Cells[1].Value = " ";
            totalCost.Cells[2].Value = ConvertToUnsign3("Tổng số tiền");
            totalCost.Cells[3].Value = lbAddBillToTalBill.Text;
            dgvPdf.Rows.Add(totalCost);

            #endregion

            dgvPdf.Refresh();
        }

        private void btnAddBillExport_Click(object sender, EventArgs e)
        {
            try
            {
                //  question yes no
                if (MessageBox.Show("Bạn có muốn xuất hóa đơn?", "Tạo hóa đơn", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                //  create new bill
                Bill newBill = new Bill();
                newBill.TimeChanged = DateTime.Now;
                newBill.TotalCost = Int32.Parse(lbAddBillToTalBill.Text);
                newBill.UserId = Login.USER_LOGIN.UserId;
                newBill.CustomerId = txtCustomerId.Text;
                newBill.CustomerName = txtCustomerName.Text;
                newBill.CustomerAddress = txtAddress.Text;

                //  add to db
                newBill = DbManager.addBill(newBill);

                //  add to bill detail
                List<BillDetail> listBillDetail = new List<BillDetail>();
                foreach (DataGridViewRow row in dgvAddBill.Rows)
                {
                    if (row.Index >= 0 && row.Index < dgvAddBill.RowCount - 1)
                    {
                        //  create bill detail
                        BillDetail billDetail = new BillDetail();
                        billDetail.BillId = newBill.BillId;
                        Tree currTree = DbManager.GetTreeById(Int32.Parse(row.Cells[0].Value.ToString()));
                        billDetail.TreeId = currTree.TreeId;
                        billDetail.Quantity = Int32.Parse(row.Cells[2].Value.ToString());
                        billDetail.Cost = currTree.Cost;

                        //  add bill detail to list
                        listBillDetail.Add(billDetail);
                    }
                }

                //  creat pdf
                createBillPdf(newBill);

                //  export pdf
                exportPdf();

                //  save to db
                DbManager.addListBillDetail(listBillDetail);

                this.Close();

                MessageBox.Show("Tạo hóa đơn thành công");
                return;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ConvertToUnsign3(string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty)
                        .Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        private void exportPdf()
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgvPdf.ColumnCount);
            pdfTable.DefaultCell.Padding = 5;
            pdfTable.WidthPercentage = 50;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 0;
            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 6, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);

            //Adding Header row
            foreach (DataGridViewColumn column in dgvPdf.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, times));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgvPdf.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null) continue;
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\Users\\vuhoa\\Desktop\\SQL\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }

        private void btnBillUpdateTree_Click(object sender, EventArgs e)
        {
            if (ID_TREE_SELECTED == null)
            {
                MessageBox.Show("Vui lòng chọn cây cần cập nhật", "Cập nhật cây",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  get current tree
            Tree currTree = DbManager.GetTreeById((int)ID_TREE_SELECTED);

            int quantity = Int32.Parse(ROW_SELECTED.Cells[2].Value.ToString());

            UpdateTreeBill newFrom = new UpdateTreeBill(currTree, quantity, updateTreeCallBack);
            newFrom.Show();
        }

    }
}
