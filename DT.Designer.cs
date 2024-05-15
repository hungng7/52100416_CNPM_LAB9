namespace _52100416_NguyenHuyHung_lab7
{
    partial class DT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.leaderDT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.costDT = new System.Windows.Forms.TextBox();
            this.idDT = new System.Windows.Forms.TextBox();
            this.nameDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrintDT = new System.Windows.Forms.Button();
            this.btnCancelDT = new System.Windows.Forms.Button();
            this.btnSaveDT = new System.Windows.Forms.Button();
            this.btnEditDT = new System.Windows.Forms.Button();
            this.btnDeleteDT = new System.Windows.Forms.Button();
            this.btnAddDT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datagridDT = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.toKQ = new System.Windows.Forms.Button();
            this.backSV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.leaderDT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.costDT);
            this.panel1.Controls.Add(this.idDT);
            this.panel1.Controls.Add(this.nameDT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 108);
            this.panel1.TabIndex = 5;
            // 
            // leaderDT
            // 
            this.leaderDT.FormattingEnabled = true;
            this.leaderDT.Location = new System.Drawing.Point(134, 68);
            this.leaderDT.Name = "leaderDT";
            this.leaderDT.Size = new System.Drawing.Size(170, 24);
            this.leaderDT.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin đề tài";
            // 
            // costDT
            // 
            this.costDT.Location = new System.Drawing.Point(450, 70);
            this.costDT.Name = "costDT";
            this.costDT.Size = new System.Drawing.Size(273, 22);
            this.costDT.TabIndex = 8;
            this.costDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funding_KeyPress);
            // 
            // idDT
            // 
            this.idDT.Location = new System.Drawing.Point(134, 36);
            this.idDT.Name = "idDT";
            this.idDT.Size = new System.Drawing.Size(170, 22);
            this.idDT.TabIndex = 7;
            // 
            // nameDT
            // 
            this.nameDT.Location = new System.Drawing.Point(450, 36);
            this.nameDT.Name = "nameDT";
            this.nameDT.Size = new System.Drawing.Size(273, 22);
            this.nameDT.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kinh phí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên đề tài";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chủ nhiệm đề tài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số đề tài";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrintDT);
            this.panel2.Controls.Add(this.btnCancelDT);
            this.panel2.Controls.Add(this.btnSaveDT);
            this.panel2.Controls.Add(this.btnEditDT);
            this.panel2.Controls.Add(this.btnDeleteDT);
            this.panel2.Controls.Add(this.btnAddDT);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(23, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 56);
            this.panel2.TabIndex = 6;
            // 
            // btnPrintDT
            // 
            this.btnPrintDT.BackColor = System.Drawing.SystemColors.Window;
            this.btnPrintDT.Location = new System.Drawing.Point(619, 18);
            this.btnPrintDT.Name = "btnPrintDT";
            this.btnPrintDT.Size = new System.Drawing.Size(75, 23);
            this.btnPrintDT.TabIndex = 6;
            this.btnPrintDT.Text = "Xem in";
            this.btnPrintDT.UseVisualStyleBackColor = false;
            this.btnPrintDT.Click += new System.EventHandler(this.btnPrintDT_Click);
            // 
            // btnCancelDT
            // 
            this.btnCancelDT.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelDT.Location = new System.Drawing.Point(527, 18);
            this.btnCancelDT.Name = "btnCancelDT";
            this.btnCancelDT.Size = new System.Drawing.Size(75, 23);
            this.btnCancelDT.TabIndex = 5;
            this.btnCancelDT.Text = "Hủy";
            this.btnCancelDT.UseVisualStyleBackColor = false;
            this.btnCancelDT.Click += new System.EventHandler(this.btnCancelDT_Click);
            // 
            // btnSaveDT
            // 
            this.btnSaveDT.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaveDT.Location = new System.Drawing.Point(434, 18);
            this.btnSaveDT.Name = "btnSaveDT";
            this.btnSaveDT.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDT.TabIndex = 4;
            this.btnSaveDT.Text = "Lưu";
            this.btnSaveDT.UseVisualStyleBackColor = false;
            this.btnSaveDT.Click += new System.EventHandler(this.btnSaveDT_Click);
            // 
            // btnEditDT
            // 
            this.btnEditDT.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditDT.Location = new System.Drawing.Point(336, 18);
            this.btnEditDT.Name = "btnEditDT";
            this.btnEditDT.Size = new System.Drawing.Size(75, 23);
            this.btnEditDT.TabIndex = 3;
            this.btnEditDT.Text = "Sửa";
            this.btnEditDT.UseVisualStyleBackColor = false;
            this.btnEditDT.Click += new System.EventHandler(this.btnEditDT_Click);
            // 
            // btnDeleteDT
            // 
            this.btnDeleteDT.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeleteDT.Location = new System.Drawing.Point(243, 18);
            this.btnDeleteDT.Name = "btnDeleteDT";
            this.btnDeleteDT.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDT.TabIndex = 2;
            this.btnDeleteDT.Text = "Xóa";
            this.btnDeleteDT.UseVisualStyleBackColor = false;
            this.btnDeleteDT.Click += new System.EventHandler(this.btnDeleteDT_Click);
            // 
            // btnAddDT
            // 
            this.btnAddDT.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddDT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddDT.FlatAppearance.BorderSize = 3;
            this.btnAddDT.Location = new System.Drawing.Point(144, 18);
            this.btnAddDT.Name = "btnAddDT";
            this.btnAddDT.Size = new System.Drawing.Size(75, 23);
            this.btnAddDT.TabIndex = 1;
            this.btnAddDT.Text = "Thêm";
            this.btnAddDT.UseVisualStyleBackColor = false;
            this.btnAddDT.Click += new System.EventHandler(this.btnAddDT_Click);
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
            this.panel3.Controls.Add(this.datagridDT);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(23, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 256);
            this.panel3.TabIndex = 7;
            // 
            // datagridDT
            // 
            this.datagridDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDT.Location = new System.Drawing.Point(23, 29);
            this.datagridDT.Name = "datagridDT";
            this.datagridDT.RowHeadersWidth = 51;
            this.datagridDT.RowTemplate.Height = 24;
            this.datagridDT.Size = new System.Drawing.Size(700, 211);
            this.datagridDT.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Danh sách đề tài";
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.printDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // toKQ
            // 
            this.toKQ.BackColor = System.Drawing.SystemColors.Window;
            this.toKQ.Location = new System.Drawing.Point(596, 487);
            this.toKQ.Name = "toKQ";
            this.toKQ.Size = new System.Drawing.Size(168, 38);
            this.toKQ.TabIndex = 8;
            this.toKQ.Text = "Chuyển đến Kết quả";
            this.toKQ.UseVisualStyleBackColor = false;
            this.toKQ.Click += new System.EventHandler(this.toKQ_Click);
            // 
            // backSV
            // 
            this.backSV.BackColor = System.Drawing.SystemColors.Window;
            this.backSV.Location = new System.Drawing.Point(23, 487);
            this.backSV.Name = "backSV";
            this.backSV.Size = new System.Drawing.Size(137, 38);
            this.backSV.TabIndex = 9;
            this.backSV.Text = "Quay lại";
            this.backSV.UseVisualStyleBackColor = false;
            this.backSV.Click += new System.EventHandler(this.backSV_Click);
            // 
            // DT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.backSV);
            this.Controls.Add(this.toKQ);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DT";
            this.Text = "Quản lý đề tài";
            this.Load += new System.EventHandler(this.DT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox leaderDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costDT;
        private System.Windows.Forms.TextBox idDT;
        private System.Windows.Forms.TextBox nameDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrintDT;
        private System.Windows.Forms.Button btnCancelDT;
        private System.Windows.Forms.Button btnSaveDT;
        private System.Windows.Forms.Button btnEditDT;
        private System.Windows.Forms.Button btnDeleteDT;
        private System.Windows.Forms.Button btnAddDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datagridDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.Button toKQ;
        private System.Windows.Forms.Button backSV;
    }
}