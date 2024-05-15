using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52100416_NguyenHuyHung_lab7
{
    public partial class KQ : Form
    {
        BUS_SV_DT bSVDT;
        public KQ()
        {
            InitializeComponent();
            bSVDT = new BUS_SV_DT();
        }

        private bool isHavePlaces = false;

        private void KQ_Load(object sender, EventArgs e)
        {
            // Vô hiệu controls thông tin kết quả thực tập
            DisableControls();

            // Danh sách nơi thực tập
            Places();

            // Hiện danh sách kết quả thực tập
            LoadResultData();

            // Chọn dòng trong gridView
            datagridKQ.SelectionChanged += dataGridView_SelectionChanged;
        }

        public void DisableControls()
        {
            this.btnDeleteKQ.Enabled = false;
            this.btnEditKQ.Enabled = false;
            this.btnSaveKQ.Enabled = false;

            this.idSV_KQ.Enabled = false;
            this.placeKQ.Enabled = false;
            this.idDT_KQ.Enabled = false;
            this.distanceKQ.Enabled = false;
            this.resultKQ.Enabled = false;
        }
        public void EnableControls()
        {
            this.idSV_KQ.Enabled = true;
            this.placeKQ.Enabled = true;
            this.idDT_KQ.Enabled = true;
            this.distanceKQ.Enabled = true;
            this.resultKQ.Enabled = true;
        }
        public void ClearTextBoxes()
        {
            this.idSV_KQ.Clear();
            this.idDT_KQ.Clear();
            this.distanceKQ.Clear();
            this.resultKQ.Clear();

        }
        public void Places()
        {
            if (!isHavePlaces)
            {
                this.placeKQ.Items.AddRange(new object[] { "Sài Gòn",
                "Bình Dương",
                "Vũng Tàu",
                "Long An",
                "Nha Trang",
                "Tiền Giang",
                "Kiên Giang"});

                isHavePlaces = true;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridKQ.SelectedRows.Count > 0)
            {
                // Dòng đang chọn
                DataGridViewRow rows = datagridKQ.SelectedRows[0];

                idSV_KQ.Text = rows.Cells["MaSoSinhVien"].Value.ToString();
                idDT_KQ.Text = rows.Cells["MaSoDeTai"].Value.ToString();
                placeKQ.Text = rows.Cells["NoiThucTap"].Value.ToString();
                distanceKQ.Text = rows.Cells["QuangDuong"].Value.ToString();
                resultKQ.Text = rows.Cells["KetQua"].Value.ToString();

                DisableControls();
                btnEditKQ.Enabled = true;
                btnDeleteKQ.Enabled = true;
            }
            else
            {
                ClearTextBoxes();
            }
        }

        public void LoadResultData()
        {
            datagridKQ.DataSource = bSVDT.hienKQ();
        }

        private void distance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập ký tự số");
            }
        }
        private void result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập ký tự số");
            }
        }

        public void SaveResultData()
        {
            var idSV = idSV_KQ.Text;
            var idDT = idDT_KQ.Text;
            var place = placeKQ.Text;
            var dis = distanceKQ.Text;
            var res = resultKQ.Text;

            if (string.IsNullOrWhiteSpace(idSV) || string.IsNullOrWhiteSpace(idDT) || string.IsNullOrWhiteSpace(place) 
                || string.IsNullOrWhiteSpace(dis) || string.IsNullOrWhiteSpace(res) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (bSVDT.KiemTraMaTonTai(idSV,idDT) && !idSV_KQ.Enabled && !idDT_KQ.Enabled)
            {
                // Nếu đã tồn tại, thực hiện được cập nhật thông tin sinh viên
                bSVDT.suaKQ(idSV,idDT,place,dis,res);
            }
            else
            {
                // Nếu chưa tồn tại, thực hiện thêm sinh viên mới
                AddResult();
            }

        }

        public void AddResult()
        {
            var idSV = idSV_KQ.Text;
            var idDT = idDT_KQ.Text;
            var place = placeKQ.Text;
            var dis = distanceKQ.Text;
            var res = resultKQ.Text;

            if (bSVDT.KiemTraMaTonTai(idSV,idDT))
            {
                MessageBox.Show("Mã sinh viên và đề tài đã tồn tại");
                return;
            }
            
            bSVDT.themKQ(idSV, idDT, place, dis, res);
        }

        public void DeleteResult()
        {
            var idSV = idSV_KQ.Text;
            var idDT = idDT_KQ.Text;
            bSVDT.xoaKQ(idSV, idDT);
        }

        private void btnAddKQ_Click(object sender, EventArgs e)
        {
            // Kích hoạt controls thông tin kết quả thực tập
            EnableControls();

            // Làm sạch các textboxes
            ClearTextBoxes();

            this.idSV_KQ.Focus();
            this.btnSaveKQ.Enabled = true;
            this.btnDeleteKQ.Enabled = false;
            this.btnEditKQ.Enabled = false;
        }
        private void btnDeleteKQ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Xóa kết quả thực tập của sinh viên khỏi danh sách
                DeleteResult();

                // Hiển thị lại danh sách kết quả hiện tại
                LoadResultData();

                ClearTextBoxes();
            }
        }
        private void btnEditKQ_Click(object sender, EventArgs e)
        {
            this.btnSaveKQ.Enabled = true;
            EnableControls();
            this.idSV_KQ.Enabled = false;
            this.idDT_KQ.Enabled = false;
            this.placeKQ.Focus();
        }
        private void btnSaveKQ_Click(object sender, EventArgs e)
        {
            // Kiểm tra thực hiện thao tác lưu "Thêm" hay "Sửa"
            SaveResultData();

            // Cập nhật lại danh sách hiển thị
            LoadResultData();

            // Trở lại trạng thái ban đầu
            DisableControls();
            ClearTextBoxes();
        }
        private void btnCancelKQ_Click(object sender, EventArgs e)
        {
            KQ_Load(null,null);
        }


        // In danh sách kết quả thực tập
        Bitmap bitmap;
        private void btnPrintKQ_Click(object sender, EventArgs e)
        {
            printPreviewDialog3.Document = printDocument3;
            printPreviewDialog3.PrintPreviewControl.Zoom = 1;
            printPreviewDialog3.ShowDialog();
        }
        private void printDocument3_PrintPage(object sender, PrintPageEventArgs e)
        {
            datagridKQ.Height = (int)(datagridKQ.RowCount * datagridKQ.RowTemplate.Height * 1.2);
            bitmap = new Bitmap(datagridKQ.Width, datagridKQ.Height);
            datagridKQ.DrawToBitmap(bitmap, new Rectangle(0, 0, datagridKQ.Width, datagridKQ.Height));
            e.Graphics.DrawImage(bitmap, 100, 30);
        }

        private void backDT_Click(object sender, EventArgs e)
        {
            DT d = new DT();
            d.Show();
            this.Hide();
        }
    }
}
