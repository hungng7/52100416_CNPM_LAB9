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
using System.Xml.Linq;

namespace _52100416_NguyenHuyHung_lab7
{
    public partial class DT : Form
    {
        BUS_DeTai bDT;
        public DT()
        {
            InitializeComponent();
            bDT = new BUS_DeTai();
        }

        private bool isHaveLeaders = false;

        private void DT_Load(object sender, EventArgs e)
        {
            // Vô hiệu hóa controls thông tin đề tài
            DisableControls();

            // Hiện danh sách đề tài
            LoadProjectData();

            // Các chủ nhiệm đề tài
            LeadersOfProject();

            // Chọn dòng trong gridView
            datagridDT.SelectionChanged += dataGridView_SelectionChanged;
        }
        private void btnAddDT_Click(object sender, EventArgs e)
        {
            // Kích hoạt controls thông tin đề tài
            EnableControls();

            // Làm sạch các textboxes
            ClearTextBoxes();

            this.idDT.Focus();
            this.btnSaveDT.Enabled = true;
            this.btnDeleteDT.Enabled = false;
            this.btnEditDT.Enabled = false;
        }
        private void btnCancelDT_Click(object sender, EventArgs e)
        {
            DT_Load(null, null);
        }

        private void btnDeleteDT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Xóa đề tài trong bảng
                deleteProject();

                // Hiển thị danh sách hiện tại
                LoadProjectData();

                ClearTextBoxes();
            }
        }
        private void btnEditDT_Click(object sender, EventArgs e)
        {
            this.btnSaveDT.Enabled = true;
            EnableControls();
            this.idDT.Enabled = false;
            this.nameDT.Focus();
        }
        private void btnSaveDT_Click(object sender, EventArgs e)
        {
            // Kiểm tra thực hiện thao tác lưu "Thêm" hay "Sửa"
            SaveProjectData();

            // Cập nhật lại danh sách hiển thị
            LoadProjectData();

            // Trở lại trạng thái ban đầu
            DisableControls();
            ClearTextBoxes();
        }


        public void DisableControls()
        {
            this.btnDeleteDT.Enabled = false;
            this.btnEditDT.Enabled = false;
            this.btnSaveDT.Enabled = false;

            this.idDT.Enabled = false;
            this.leaderDT.Enabled = false;
            this.nameDT.Enabled = false;
            this.costDT.Enabled = false;
        }

        public void EnableControls()
        {
            this.idDT.Enabled = true;
            this.leaderDT.Enabled = true;
            this.nameDT.Enabled = true;
            this.costDT.Enabled = true;
        }
        public void LeadersOfProject()
        {
            if (!isHaveLeaders)
            {
                this.leaderDT.Items.AddRange(new object[] { "Nguyễn Thế Hữu",
                "Trần Trung Hiếu",
                "Nguyễn Công Tâm",
                "Đặng Đức Trung",
                "Trịnh Thanh Duy",
                "Lê Viết Thanh",
                "Võ Văn Thành"});

                isHaveLeaders = true;
            }
        }
        public void ClearTextBoxes()
        {
            this.idDT.Clear();
            this.nameDT.Clear();
            this.costDT.Clear();
        }
        public void LoadProjectData()
        {
            datagridDT.DataSource = bDT.hienDT();
        }

        public void SaveProjectData()
        {
            var id = idDT.Text;
            var PName = nameDT.Text;
            var leader = leaderDT.Text;
            var fund = costDT.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(PName) ||
            string.IsNullOrWhiteSpace(leader) || string.IsNullOrWhiteSpace(fund))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            // Kiểm tra xem mã đề tài đã tồn tại hay chưa
            if (bDT.KiemTraMaTonTai(id) && !idDT.Enabled)
            {
                // Nếu đã tồn tại, thực hiện được cập nhật thông tin đề tài
                bDT.suaDT(id, PName, leader, fund);
            }
            else
            {
                // Nếu chưa tồn tại, thực hiện thêm đề tài mới
                NewProject();
            }
        }

        private void funding_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập ký tự số");
            }
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridDT.SelectedRows.Count > 0)
            {
                // Dòng đang chọn
                DataGridViewRow rows = datagridDT.SelectedRows[0];

                idDT.Text = rows.Cells["MaSoDeTai"].Value.ToString();
                nameDT.Text = rows.Cells["TenDeTai"].Value.ToString();
                leaderDT.Text = rows.Cells["ChuNhiemDeTai"].Value.ToString();
                costDT.Text = rows.Cells["KinhPhi"].Value.ToString();

                DisableControls();
                btnEditDT.Enabled = true;
                btnDeleteDT.Enabled = true;
            }
            else
            {
                ClearTextBoxes();
            }
        }
        // Thêm đề tài vào bảng 
        private void NewProject()
        {
            var id = idDT.Text;
            var PName = nameDT.Text;
            var leader = leaderDT.Text;
            var fund = costDT.Text;

            if (bDT.KiemTraMaTonTai(id))
            {
                MessageBox.Show("Mã đề tài đã tồn tại");
            }
            bDT.themDT(id, PName, leader, fund);
        }
        // Xóa đề tài trong bảng
        private void deleteProject()
        {
            var id = idDT.Text;
            bDT.xoaDT(id);
        }

        // In danh sách đề tài hiện tại
        Bitmap bitmap;
        private void btnPrintDT_Click(object sender, EventArgs e)
        {
            // Xem trước danh sách hiện tại hiển thị trước khi in
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.PrintPreviewControl.Zoom = 1;
            printPreviewDialog2.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            datagridDT.Height = (int)(datagridDT.RowCount * datagridDT.RowTemplate.Height * 1.2);
            bitmap = new Bitmap(datagridDT.Width, datagridDT.Height);
            datagridDT.DrawToBitmap(bitmap, new Rectangle(0, 0, datagridDT.Width, datagridDT.Height));
            e.Graphics.DrawImage(bitmap, 100, 30);
        }

        private void toKQ_Click(object sender, EventArgs e)
        {
            KQ kq = new KQ();
            kq.Show();
            this.Hide();
        }

        private void backSV_Click(object sender, EventArgs e)
        {
            SV sv = new SV();
            sv.Show();
            this.Hide();
        }
    }
}