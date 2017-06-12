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
                                row.Cells[3].Value = DbManager.convertToMoney((totalTreeBuy * currTree.Cost).ToString());
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
                newRow.Cells[3].Value = DbManager.convertToMoney((selected.Cost * count).ToString());
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
                    totalCost += DbManager.convertMoneyToInt(row.Cells[3].Value.ToString());
                }
            }
            lbAddBillToTalBill.Text = DbManager.convertToMoney(totalCost.ToString());
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

        private void btnAddBillExport_Click(object sender, EventArgs e)
        {
            try
            {
                //  question yes no
                if (MessageBox.Show("Bạn có muốn xuất hóa đơn?", "Tạo hóa đơn", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }

                #region Validate

                if (txtAddress.Text == null
                    || txtAddress.Text.ToString() == ""
                    || txtCustomerId.Text == null
                    || txtCustomerId.Text.ToString() == ""
                    || txtCustomerName.Text == null
                    || txtCustomerName.Text.ToString() == "")
                {
                    MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin hóa đơn", "Thêm hóa đơn",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvAddBill.RowCount <= 1)
                {
                    MessageBox.Show("Bạn vui lòng nhập cây vào hóa đơn", "Thêm hóa đơn",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                #endregion

                //  create new bill
                Bill newBill = new Bill();
                newBill.TimeChanged = DateTime.Now;
                newBill.TotalCost = DbManager.convertMoneyToInt(lbAddBillToTalBill.Text);
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

                //  export pdf
                exportPdf(newBill);

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

        private void exportPdf(Bill newBill)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(5);
            pdfTable.DefaultCell.Padding = 4;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 0;
            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 9, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);

            ////Adding Header row
            //foreach (DataGridViewColumn column in dgvAddBill.Columns)
            //{
            //    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, times));
            //    cell.BackgroundColor = new BaseColor(240, 240, 240);
            //    pdfTable.AddCell(cell);
            //}

            #region Header

            iTextSharp.text.Font timesHeader = new iTextSharp.text.Font(bfTimes, 14, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            PdfPCell cellHeader = new PdfPCell(new Phrase("GREEN", timesHeader));
            cellHeader.HorizontalAlignment = Element.ALIGN_CENTER;
            cellHeader.Colspan = 5;
            cellHeader.BorderWidth = 0;
            pdfTable.AddCell(cellHeader);

            #endregion

            #region Row Empty 1

            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");

            #endregion

            #region Thong tin khach hang

            #region Ma Hoa Don

            PdfPCell cellBillTitle = new PdfPCell(new Phrase("Ma Hoa Don", times));
            cellBillTitle.Colspan = 2;
            cellBillTitle.BorderWidth = 0;
            pdfTable.AddCell(cellBillTitle);

            PdfPCell cellBill = new PdfPCell(new Phrase(ConvertToUnsign3(newBill.BillId.ToString()), times));
            cellBill.Colspan = 3;
            cellBill.BorderWidth = 0;
            pdfTable.AddCell(cellBill);

            #endregion

            #region Thoi gian

            PdfPCell cellTimeTitle = new PdfPCell(new Phrase("Thoi Gian", times));
            cellTimeTitle.Colspan = 2;
            cellTimeTitle.BorderWidth = 0;
            pdfTable.AddCell(cellTimeTitle);

            PdfPCell cellTime = new PdfPCell(new Phrase(ConvertToUnsign3(newBill.TimeChanged.ToString()), times));
            cellTime.Colspan = 3;
            cellTime.BorderWidth = 0;
            pdfTable.AddCell(cellTime);

            #endregion

            #region Ten khach hang

            PdfPCell cellCustomNameTitle = new PdfPCell(new Phrase("Ten Khach Hang", times));
            cellCustomNameTitle.Colspan = 2;
            cellCustomNameTitle.BorderWidth = 0;
            pdfTable.AddCell(cellCustomNameTitle);

            PdfPCell cellCustomName = new PdfPCell(new Phrase(ConvertToUnsign3(txtCustomerName.Text), times));
            cellCustomName.Colspan = 3;
            cellCustomName.BorderWidth = 0;
            pdfTable.AddCell(cellCustomName);

            #endregion

            #region CMT

            PdfPCell cellCustomAddressId = new PdfPCell(new Phrase("Chung Minh Thu", times));
            cellCustomAddressId.Colspan = 2;
            cellCustomAddressId.BorderWidth = 0;
            pdfTable.AddCell(cellCustomAddressId);

            PdfPCell cellCustomId = new PdfPCell(new Phrase(ConvertToUnsign3(txtCustomerId.Text), times));
            cellCustomId.Colspan = 3;
            cellCustomId.BorderWidth = 0;
            pdfTable.AddCell(cellCustomId);

            #endregion

            #region Dia chi

            PdfPCell cellCustomAddressTitle = new PdfPCell(new Phrase("Dia chi", times));
            cellCustomAddressTitle.Colspan = 2;
            cellCustomAddressTitle.BorderWidth = 0;
            pdfTable.AddCell(cellCustomAddressTitle);

            PdfPCell cellCustomAddress = new PdfPCell(new Phrase(ConvertToUnsign3(txtAddress.Text), times));
            cellCustomAddress.Colspan = 3;
            cellCustomAddress.BorderWidth = 0;
            pdfTable.AddCell(cellCustomAddress);

            #endregion

            #endregion

            #region Row Empty 2

            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");

            #endregion

            #region Phieu tinh tien

            iTextSharp.text.Font timesPhieuTinhtien = new iTextSharp.text.Font(bfTimes, 10, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            PdfPCell cellPtt = new PdfPCell(new Phrase("PHIEU TINH TIEN", timesPhieuTinhtien));
            cellPtt.HorizontalAlignment = Element.ALIGN_CENTER;
            cellPtt.BorderWidth = 0;
            cellPtt.Colspan = 5;
            pdfTable.AddCell(cellPtt);

            #endregion

            #region Row Empty

            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");

            #endregion

            #region HEADER DETAIL

            #region ID

            PdfPCell cellHeader1 = new PdfPCell(new Phrase("Ma Cay", times));
            cellHeader1.BorderWidth = 0;
            pdfTable.AddCell(cellHeader1);

            #endregion

            #region Name

            PdfPCell cellHeader2 = new PdfPCell(new Phrase("Ten Cay", times));
            cellHeader2.BorderWidth = 0;
            cellHeader2.Colspan = 2;
            pdfTable.AddCell(cellHeader2);

            #endregion

            #region Quantity

            PdfPCell cellHeader3 = new PdfPCell(new Phrase("So Luong", times));
            cellHeader3.BorderWidth = 0;
            pdfTable.AddCell(cellHeader3);

            #endregion

            #region Total Cost

            PdfPCell cellHeader4 = new PdfPCell(new Phrase("Thanh tien", times));
            cellHeader4.BorderWidth = 0;
            pdfTable.AddCell(cellHeader4);

            #endregion

            #endregion

            #region Database

            foreach (DataGridViewRow row in dgvAddBill.Rows)
            {
                if (row.Cells[0].Value == null) continue;

                #region ID

                PdfPCell cell1 = new PdfPCell(new Phrase(ConvertToUnsign3(row.Cells[0].Value.ToString()), times));
                cell1.BorderWidth = 0;
                pdfTable.AddCell(cell1);

                #endregion

                #region Name

                PdfPCell cell2 = new PdfPCell(new Phrase(ConvertToUnsign3(row.Cells[1].Value.ToString()), times));
                cell2.BorderWidth = 0;
                cell2.Colspan = 2;
                pdfTable.AddCell(cell2);

                #endregion

                #region Quantity

                PdfPCell cell3 = new PdfPCell(new Phrase(ConvertToUnsign3(row.Cells[2].Value.ToString()), times));
                cell3.BorderWidth = 0;
                pdfTable.AddCell(cell3);

                #endregion

                #region Total Cost

                PdfPCell cell4 = new PdfPCell(new Phrase(ConvertToUnsign3(DbManager.convertMoneyToInt(row.Cells[3].Value.ToString()).ToString()), times));
                cell4.BorderWidth = 0;
                pdfTable.AddCell(cell4);

                #endregion
            }

            #endregion

            #region Row Empty

            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");
            pdfTable.AddCell(" ");

            #endregion

            #region Thanh tien

            iTextSharp.text.Font timesTotalCost = new iTextSharp.text.Font(bfTimes, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            PdfPCell cellTotalCost = new PdfPCell(new Phrase("TONG CONG   " + lbAddBillToTalBill.Text.ToString() + " VND", timesTotalCost));
            cellTotalCost.BorderWidth = 0;
            cellTotalCost.Colspan = 5;
            cellTotalCost.HorizontalAlignment = Element.ALIGN_RIGHT;
            pdfTable.AddCell(cellTotalCost);

            #endregion

            #region Exporting to PDF

            string folderPath = "C:\\Users\\vuhoa\\Desktop\\SQL\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A6, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }

            #endregion
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
