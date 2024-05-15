using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52100416_NguyenHuyHung_lab7
{
    public partial class SV : Form
    {
        BUS_SinhVien bSV;
        public SV()
        {
            InitializeComponent();
            bSV = new BUS_SinhVien();
        }

        private bool isHaveProvinces = false;

        private void SV_Load(object sender, EventArgs e)
        {
            // Vô hiệu hóa controls thông tin sinh viên
            DisableControls();

            // Hiện danh sách sinh viên
            LoadStudentData();

            // Các tỉnh trong quê quán
            PopulateProvincesComboBox();

            // Chọn dòng trong gridView
            datagridSV.SelectionChanged += dataGridView_SelectionChanged;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridSV.SelectedRows.Count > 0)
            {
                // Dòng đang chọn
                DataGridViewRow rows = datagridSV.SelectedRows[0];

                idSV.Text = rows.Cells["MaSoSinhVien"].Value.ToString();
                nameSV.Text = rows.Cells["HoTen"].Value.ToString();
                provincesSV.Text = rows.Cells["QueQuan"].Value.ToString();

                string date = rows.Cells["NgaySinh"].Value.ToString();
                DateTime parsedDate;
                if (DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    birthSV.Text = parsedDate.ToString("dddd, MMMM d, yyyy");
                }

                rankingSV.Text = rows.Cells["HocLuc"].Value.ToString();

                DisableControls();
                btnEditSV.Enabled = true;
                btnDeleteSV.Enabled = true;
            }
            else
            {
                ClearTextBoxes();
            }
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            // Kích hoạt controls thông tin sinh viên
            EnableControls();

            // Làm sạch các textboxes
            ClearTextBoxes();

            this.idSV.Focus();
            this.btnSaveSV.Enabled = true;
            this.btnDeleteSV.Enabled = false;
            this.btnEditSV.Enabled = false;
        }

        private void btnEditSV_Click(object sender, EventArgs e)
        {
            this.btnSaveSV.Enabled = true;
            EnableControls();
            this.idSV.Enabled = false;
            this.nameSV.Focus();
        }


        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Xóa sinh viên khỏi danh sách
                DeleteStudent();

                // Hiển thị lại danh sách hiện tại
                LoadStudentData();

                ClearTextBoxes();
            }
        }

        private void btnSaveSV_Click(object sender, EventArgs e)
        {
            // Kiểm tra thực hiện thao tác lưu "Thêm" hay "Sửa"
            SaveStudentData();

            // Cập nhật lại danh sách hiển thị
            LoadStudentData();

            // Trở lại trạng thái ban đầu
            DisableControls();
            ClearTextBoxes();
        }


        private void btnCancelSV_Click(object sender, EventArgs e)
        {
            SV_Load(null, null);
        }

        public void DisableControls()
        {
            this.btnDeleteSV.Enabled = false;
            this.btnEditSV.Enabled = false;
            this.btnSaveSV.Enabled = false;

            this.idSV.Enabled = false;
            this.provincesSV.Enabled = false;
            this.rankingSV.Enabled = false;
            this.nameSV.Enabled = false;
            this.birthSV.Enabled = false;
        }

        public void PopulateProvincesComboBox()
        {
            if (!isHaveProvinces)
            {
                this.provincesSV.Items.AddRange(new object[] { "Sài Gòn",
                "Thanh Hóa",
                "Nghệ An",
                "Long An",
                "Quảng Ngãi",
                "Tiền Giang",
                "Kiên Giang"});

                isHaveProvinces = true;
            }

        }

        public void LoadStudentData()
        {
            datagridSV.DataSource = bSV.hienSV();
        }


        public void SaveStudentData()
        {
            var id = idSV.Text;
            var fName = nameSV.Text;
            var hometown = provincesSV.Text;
            var birth = birthSV.Value;
            var rank = rankingSV.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(fName) ||
             string.IsNullOrWhiteSpace(hometown) || string.IsNullOrWhiteSpace(rank) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (bSV.KiemTraMaTonTai(id) && !idSV.Enabled)
            {
                // Nếu đã tồn tại, thực hiện được cập nhật thông tin sinh viên
                bSV.suaSV(id,fName,hometown,birth,rank);
            }
            else
            {
                // Nếu chưa tồn tại, thực hiện thêm sinh viên mới
                AddStudent();
            }
            
        }

        public void AddStudent()
        {
            var id = idSV.Text;
            var fName = nameSV.Text;
            var hometown = provincesSV.Text;
            var birth = birthSV.Value;
            var rank = rankingSV.Text;
            if (bSV.KiemTraMaTonTai(id))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại");
            }
            bSV.themSV(id, fName, hometown, birth, rank);
        }

        public void DeleteStudent()
        {
            var id = idSV.Text;
            bSV.xoaSV(id);
        }
       
        public void EnableControls()
        {
            this.idSV.Enabled = true;
            this.provincesSV.Enabled = true;
            this.rankingSV.Enabled = true;
            this.nameSV.Enabled = true;
            this.birthSV.Enabled = true;
        }

        public void ClearTextBoxes()
        {
            this.idSV.Clear();
            this.rankingSV.Clear();
            this.nameSV.Clear();
            this.birthSV.Value = DateTime.Today;

        }

        private void ranking_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập ký tự số");
            }
        }


        // In danh sách sinh viên hiện tại
        Bitmap bitmap;
        private void btnPrintSV_Click(object sender, EventArgs e)
        {
            // Xem trước danh sách hiện tại hiển thị trước khi in
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            datagridSV.Height = (int)(datagridSV.RowCount * datagridSV.RowTemplate.Height * 1.2);
            bitmap = new Bitmap(datagridSV.Width, datagridSV.Height);
            datagridSV.DrawToBitmap(bitmap, new Rectangle(0, 0, datagridSV.Width, datagridSV.Height));
            e.Graphics.DrawImage(bitmap, 100, 30);
        }

        private void toDT_Click(object sender, EventArgs e)
        {
            DT d = new DT();
            d.Show();
            this.Hide();
        }
    }
}
