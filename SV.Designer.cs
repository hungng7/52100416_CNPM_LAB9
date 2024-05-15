namespace _52100416_NguyenHuyHung_lab7
{
    partial class SV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.birthSV = new System.Windows.Forms.DateTimePicker();
            this.provincesSV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rankingSV = new System.Windows.Forms.TextBox();
            this.idSV = new System.Windows.Forms.TextBox();
            this.nameSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrintSV = new System.Windows.Forms.Button();
            this.btnCancelSV = new System.Windows.Forms.Button();
            this.btnSaveSV = new System.Windows.Forms.Button();
            this.btnEditSV = new System.Windows.Forms.Button();
            this.btnDeleteSV = new System.Windows.Forms.Button();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datagridSV = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toDT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.birthSV);
            this.panel1.Controls.Add(this.provincesSV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rankingSV);
            this.panel1.Controls.Add(this.idSV);
            this.panel1.Controls.Add(this.nameSV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 127);
            this.panel1.TabIndex = 2;
            // 
            // birthSV
            // 
            this.birthSV.Location = new System.Drawing.Point(450, 65);
            this.birthSV.Name = "birthSV";
            this.birthSV.Size = new System.Drawing.Size(273, 22);
            this.birthSV.TabIndex = 10;
            // 
            // provincesSV
            // 
            this.provincesSV.FormattingEnabled = true;
            this.provincesSV.Location = new System.Drawing.Point(134, 64);
            this.provincesSV.Name = "provincesSV";
            this.provincesSV.Size = new System.Drawing.Size(170, 24);
            this.provincesSV.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // rankingSV
            // 
            this.rankingSV.Location = new System.Drawing.Point(134, 95);
            this.rankingSV.Name = "rankingSV";
            this.rankingSV.Size = new System.Drawing.Size(170, 22);
            this.rankingSV.TabIndex = 8;
            this.rankingSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ranking_KeyPress);
            // 
            // idSV
            // 
            this.idSV.Location = new System.Drawing.Point(134, 36);
            this.idSV.Name = "idSV";
            this.idSV.Size = new System.Drawing.Size(170, 22);
            this.idSV.TabIndex = 7;
            // 
            // nameSV
            // 
            this.nameSV.Location = new System.Drawing.Point(450, 36);
            this.nameSV.Name = "nameSV";
            this.nameSV.Size = new System.Drawing.Size(273, 22);
            this.nameSV.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Học lực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quê quán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số sinh viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrintSV);
            this.panel2.Controls.Add(this.btnCancelSV);
            this.panel2.Controls.Add(this.btnSaveSV);
            this.panel2.Controls.Add(this.btnEditSV);
            this.panel2.Controls.Add(this.btnDeleteSV);
            this.panel2.Controls.Add(this.btnAddSV);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(22, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 56);
            this.panel2.TabIndex = 3;
            // 
            // btnPrintSV
            // 
            this.btnPrintSV.BackColor = System.Drawing.SystemColors.Window;
            this.btnPrintSV.Location = new System.Drawing.Point(619, 18);
            this.btnPrintSV.Name = "btnPrintSV";
            this.btnPrintSV.Size = new System.Drawing.Size(75, 23);
            this.btnPrintSV.TabIndex = 6;
            this.btnPrintSV.Text = "Xem in";
            this.btnPrintSV.UseVisualStyleBackColor = false;
            this.btnPrintSV.Click += new System.EventHandler(this.btnPrintSV_Click);
            // 
            // btnCancelSV
            // 
            this.btnCancelSV.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelSV.Location = new System.Drawing.Point(527, 18);
            this.btnCancelSV.Name = "btnCancelSV";
            this.btnCancelSV.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSV.TabIndex = 5;
            this.btnCancelSV.Text = "Hủy";
            this.btnCancelSV.UseVisualStyleBackColor = false;
            this.btnCancelSV.Click += new System.EventHandler(this.btnCancelSV_Click);
            // 
            // btnSaveSV
            // 
            this.btnSaveSV.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaveSV.Location = new System.Drawing.Point(434, 18);
            this.btnSaveSV.Name = "btnSaveSV";
            this.btnSaveSV.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSV.TabIndex = 4;
            this.btnSaveSV.Text = "Lưu";
            this.btnSaveSV.UseVisualStyleBackColor = false;
            this.btnSaveSV.Click += new System.EventHandler(this.btnSaveSV_Click);
            // 
            // btnEditSV
            // 
            this.btnEditSV.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditSV.Location = new System.Drawing.Point(336, 18);
            this.btnEditSV.Name = "btnEditSV";
            this.btnEditSV.Size = new System.Drawing.Size(75, 23);
            this.btnEditSV.TabIndex = 3;
            this.btnEditSV.Text = "Sửa";
            this.btnEditSV.UseVisualStyleBackColor = false;
            this.btnEditSV.Click += new System.EventHandler(this.btnEditSV_Click);
            // 
            // btnDeleteSV
            // 
            this.btnDeleteSV.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeleteSV.Location = new System.Drawing.Point(243, 18);
            this.btnDeleteSV.Name = "btnDeleteSV";
            this.btnDeleteSV.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSV.TabIndex = 2;
            this.btnDeleteSV.Text = "Xóa";
            this.btnDeleteSV.UseVisualStyleBackColor = false;
            this.btnDeleteSV.Click += new System.EventHandler(this.btnDeleteSV_Click);
            // 
            // btnAddSV
            // 
            this.btnAddSV.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddSV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddSV.FlatAppearance.BorderSize = 3;
            this.btnAddSV.Location = new System.Drawing.Point(144, 18);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(75, 23);
            this.btnAddSV.TabIndex = 1;
            this.btnAddSV.Text = "Thêm";
            this.btnAddSV.UseVisualStyleBackColor = false;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chức năng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.datagridSV);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(22, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 232);
            this.panel3.TabIndex = 4;
            // 
            // datagridSV
            // 
            this.datagridSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSV.Location = new System.Drawing.Point(23, 29);
            this.datagridSV.Name = "datagridSV";
            this.datagridSV.RowHeadersWidth = 51;
            this.datagridSV.RowTemplate.Height = 24;
            this.datagridSV.Size = new System.Drawing.Size(700, 200);
            this.datagridSV.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Danh sách sinh viên";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // toDT
            // 
            this.toDT.BackColor = System.Drawing.SystemColors.Window;
            this.toDT.Location = new System.Drawing.Point(616, 510);
            this.toDT.Name = "toDT";
            this.toDT.Size = new System.Drawing.Size(147, 38);
            this.toDT.TabIndex = 5;
            this.toDT.Text = "Chuyển đến Đề tài";
            this.toDT.UseVisualStyleBackColor = false;
            this.toDT.Click += new System.EventHandler(this.toDT_Click);
            // 
            // SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.toDT);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SV";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.SV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker birthSV;
        private System.Windows.Forms.ComboBox provincesSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rankingSV;
        private System.Windows.Forms.TextBox idSV;
        private System.Windows.Forms.TextBox nameSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrintSV;
        private System.Windows.Forms.Button btnCancelSV;
        private System.Windows.Forms.Button btnSaveSV;
        private System.Windows.Forms.Button btnEditSV;
        private System.Windows.Forms.Button btnDeleteSV;
        private System.Windows.Forms.Button btnAddSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datagridSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button toDT;
    }
}

