namespace _52100416_NguyenHuyHung_lab7
{
    partial class KQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KQ));
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultKQ = new System.Windows.Forms.TextBox();
            this.placeKQ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idDT_KQ = new System.Windows.Forms.TextBox();
            this.idSV_KQ = new System.Windows.Forms.TextBox();
            this.distanceKQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrintKQ = new System.Windows.Forms.Button();
            this.btnCancelKQ = new System.Windows.Forms.Button();
            this.btnSaveKQ = new System.Windows.Forms.Button();
            this.btnEditKQ = new System.Windows.Forms.Button();
            this.btnDeleteKQ = new System.Windows.Forms.Button();
            this.btnAddKQ = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datagridKQ = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.printPreviewDialog3 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.backDT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridKQ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultKQ);
            this.panel1.Controls.Add(this.placeKQ);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.idDT_KQ);
            this.panel1.Controls.Add(this.idSV_KQ);
            this.panel1.Controls.Add(this.distanceKQ);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 127);
            this.panel1.TabIndex = 7;
            // 
            // resultKQ
            // 
            this.resultKQ.Location = new System.Drawing.Point(504, 66);
            this.resultKQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultKQ.Name = "resultKQ";
            this.resultKQ.Size = new System.Drawing.Size(217, 22);
            this.resultKQ.TabIndex = 10;
            this.resultKQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.result_KeyPress);
            // 
            // placeKQ
            // 
            this.placeKQ.FormattingEnabled = true;
            this.placeKQ.Location = new System.Drawing.Point(133, 95);
            this.placeKQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeKQ.Name = "placeKQ";
            this.placeKQ.Size = new System.Drawing.Size(169, 24);
            this.placeKQ.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin thực tập";
            // 
            // idDT_KQ
            // 
            this.idDT_KQ.Location = new System.Drawing.Point(133, 65);
            this.idDT_KQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idDT_KQ.Name = "idDT_KQ";
            this.idDT_KQ.Size = new System.Drawing.Size(169, 22);
            this.idDT_KQ.TabIndex = 8;
            // 
            // idSV_KQ
            // 
            this.idSV_KQ.Location = new System.Drawing.Point(133, 36);
            this.idSV_KQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idSV_KQ.Name = "idSV_KQ";
            this.idSV_KQ.Size = new System.Drawing.Size(169, 22);
            this.idSV_KQ.TabIndex = 7;
            // 
            // distanceKQ
            // 
            this.distanceKQ.Location = new System.Drawing.Point(504, 36);
            this.distanceKQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.distanceKQ.Name = "distanceKQ";
            this.distanceKQ.Size = new System.Drawing.Size(217, 22);
            this.distanceKQ.TabIndex = 6;
            this.distanceKQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.distance_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kết quả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quảng đường";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nơi thực tập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã số đề tài";
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
            this.panel2.Controls.Add(this.btnPrintKQ);
            this.panel2.Controls.Add(this.btnCancelKQ);
            this.panel2.Controls.Add(this.btnSaveKQ);
            this.panel2.Controls.Add(this.btnEditKQ);
            this.panel2.Controls.Add(this.btnDeleteKQ);
            this.panel2.Controls.Add(this.btnAddKQ);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(25, 153);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 57);
            this.panel2.TabIndex = 8;
            // 
            // btnPrintKQ
            // 
            this.btnPrintKQ.BackColor = System.Drawing.SystemColors.Window;
            this.btnPrintKQ.Location = new System.Drawing.Point(619, 18);
            this.btnPrintKQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintKQ.Name = "btnPrintKQ";
            this.btnPrintKQ.Size = new System.Drawing.Size(75, 23);
            this.btnPrintKQ.TabIndex = 6;
            this.btnPrintKQ.Text = "Xem in";
            this.btnPrintKQ.UseVisualStyleBackColor = false;
            this.btnPrintKQ.Click += new System.EventHandler(this.btnPrintKQ_Click);
            // 
            // btnCancelKQ
            // 
            this.btnCancelKQ.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelKQ.Location = new System.Drawing.Point(527, 18);
            this.btnCancelKQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelKQ.Name = "btnCancelKQ";
            this.btnCancelKQ.Size = new System.Drawing.Size(75, 23);
            this.btnCancelKQ.TabIndex = 5;
            this.btnCancelKQ.Text = "Hủy";
            this.btnCancelKQ.UseVisualStyleBackColor = false;
            this.btnCancelKQ.Click += new System.EventHandler(this.btnCancelKQ_Click);
            // 
            // btnSaveKQ
            // 
            this.btnSaveKQ.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaveKQ.Location = new System.Drawing.Point(435, 18);
            this.btnSaveKQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveKQ.Name = "btnSaveKQ";
            this.btnSaveKQ.Size = new System.Drawing.Size(75, 23);
            this.btnSaveKQ.TabIndex = 4;
            this.btnSaveKQ.Text = "Lưu";
            this.btnSaveKQ.UseVisualStyleBackColor = false;
            this.btnSaveKQ.Click += new System.EventHandler(this.btnSaveKQ_Click);
            // 
            // btnEditKQ
            // 
            this.btnEditKQ.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditKQ.Location = new System.Drawing.Point(336, 18);
            this.btnEditKQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditKQ.Name = "btnEditKQ";
            this.btnEditKQ.Size = new System.Drawing.Size(75, 23);
            this.btnEditKQ.TabIndex = 3;
            this.btnEditKQ.Text = "Sửa";
            this.btnEditKQ.UseVisualStyleBackColor = false;
            this.btnEditKQ.Click += new System.EventHandler(this.btnEditKQ_Click);
            // 
            // btnDeleteKQ
            // 
            this.btnDeleteKQ.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeleteKQ.Location = new System.Drawing.Point(243, 18);
            this.btnDeleteKQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteKQ.Name = "btnDeleteKQ";
            this.btnDeleteKQ.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteKQ.TabIndex = 2;
            this.btnDeleteKQ.Text = "Xóa";
            this.btnDeleteKQ.UseVisualStyleBackColor = false;
            this.btnDeleteKQ.Click += new System.EventHandler(this.btnDeleteKQ_Click);
            // 
            // btnAddKQ
            // 
            this.btnAddKQ.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddKQ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddKQ.FlatAppearance.BorderSize = 3;
            this.btnAddKQ.Location = new System.Drawing.Point(144, 18);
            this.btnAddKQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddKQ.Name = "btnAddKQ";
            this.btnAddKQ.Size = new System.Drawing.Size(75, 23);
            this.btnAddKQ.TabIndex = 1;
            this.btnAddKQ.Text = "Thêm";
            this.btnAddKQ.UseVisualStyleBackColor = false;
            this.btnAddKQ.Click += new System.EventHandler(this.btnAddKQ_Click);
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
            this.panel3.Controls.Add(this.datagridKQ);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(25, 228);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 256);
            this.panel3.TabIndex = 9;
            // 
            // datagridKQ
            // 
            this.datagridKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridKQ.Location = new System.Drawing.Point(23, 30);
            this.datagridKQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridKQ.Name = "datagridKQ";
            this.datagridKQ.RowHeadersWidth = 51;
            this.datagridKQ.RowTemplate.Height = 24;
            this.datagridKQ.Size = new System.Drawing.Size(700, 210);
            this.datagridKQ.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Danh sách kết quả thực tập";
            // 
            // printPreviewDialog3
            // 
            this.printPreviewDialog3.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog3.Document = this.printDocument3;
            this.printPreviewDialog3.Enabled = true;
            this.printPreviewDialog3.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog3.Icon")));
            this.printPreviewDialog3.Name = "printPreviewDialog1";
            this.printPreviewDialog3.Visible = false;
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // backDT
            // 
            this.backDT.BackColor = System.Drawing.SystemColors.Window;
            this.backDT.Location = new System.Drawing.Point(25, 489);
            this.backDT.Name = "backDT";
            this.backDT.Size = new System.Drawing.Size(137, 38);
            this.backDT.TabIndex = 10;
            this.backDT.Text = "Quay lại";
            this.backDT.UseVisualStyleBackColor = false;
            this.backDT.Click += new System.EventHandler(this.backDT_Click);
            // 
            // KQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.backDT);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "KQ";
            this.Text = "Quản lý kết quả thực tập";
            this.Load += new System.EventHandler(this.KQ_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridKQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox resultKQ;
        private System.Windows.Forms.ComboBox placeKQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idDT_KQ;
        private System.Windows.Forms.TextBox idSV_KQ;
        private System.Windows.Forms.TextBox distanceKQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrintKQ;
        private System.Windows.Forms.Button btnCancelKQ;
        private System.Windows.Forms.Button btnSaveKQ;
        private System.Windows.Forms.Button btnEditKQ;
        private System.Windows.Forms.Button btnDeleteKQ;
        private System.Windows.Forms.Button btnAddKQ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datagridKQ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog3;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private System.Windows.Forms.Button backDT;
    }
}