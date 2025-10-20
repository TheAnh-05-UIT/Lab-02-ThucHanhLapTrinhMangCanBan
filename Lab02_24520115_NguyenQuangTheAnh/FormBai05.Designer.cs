namespace Lab02_24520115_NguyenQuangTheAnh
{
    partial class frm_Bai05
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
            this.cboMovies = new System.Windows.Forms.ComboBox();
            this.cboRooms = new System.Windows.Forms.ComboBox();
            this.clbSeats = new System.Windows.Forms.CheckedListBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.rtbBill = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExportStats = new System.Windows.Forms.Button();
            this.lbl_ChonPhim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboMovies
            // 
            this.cboMovies.FormattingEnabled = true;
            this.cboMovies.Location = new System.Drawing.Point(117, 32);
            this.cboMovies.Name = "cboMovies";
            this.cboMovies.Size = new System.Drawing.Size(121, 28);
            this.cboMovies.TabIndex = 0;
            this.cboMovies.SelectedIndexChanged += new System.EventHandler(this.cboMovies_SelectedIndexChanged);
            // 
            // cboRooms
            // 
            this.cboRooms.FormattingEnabled = true;
            this.cboRooms.Location = new System.Drawing.Point(411, 37);
            this.cboRooms.Name = "cboRooms";
            this.cboRooms.Size = new System.Drawing.Size(121, 28);
            this.cboRooms.TabIndex = 1;
            this.cboRooms.SelectedIndexChanged += new System.EventHandler(this.cboRooms_SelectedIndexChanged);
            // 
            // clbSeats
            // 
            this.clbSeats.FormattingEnabled = true;
            this.clbSeats.Location = new System.Drawing.Point(118, 140);
            this.clbSeats.Name = "clbSeats";
            this.clbSeats.Size = new System.Drawing.Size(120, 96);
            this.clbSeats.TabIndex = 2;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(29, 300);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(152, 56);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Đặt Vé";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // rtbBill
            // 
            this.rtbBill.Location = new System.Drawing.Point(312, 140);
            this.rtbBill.Name = "rtbBill";
            this.rtbBill.Size = new System.Drawing.Size(443, 356);
            this.rtbBill.TabIndex = 4;
            this.rtbBill.Text = "";
            this.rtbBill.TextChanged += new System.EventHandler(this.rtbBill_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(493, 513);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(262, 15);
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(489, 550);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Visible = false;
            // 
            // btnExportStats
            // 
            this.btnExportStats.Location = new System.Drawing.Point(312, 513);
            this.btnExportStats.Name = "btnExportStats";
            this.btnExportStats.Size = new System.Drawing.Size(132, 57);
            this.btnExportStats.TabIndex = 7;
            this.btnExportStats.Text = "Xuất Thống Kê";
            this.btnExportStats.UseVisualStyleBackColor = true;
            this.btnExportStats.Click += new System.EventHandler(this.btnExportStats_Click);
            // 
            // lbl_ChonPhim
            // 
            this.lbl_ChonPhim.AutoSize = true;
            this.lbl_ChonPhim.Location = new System.Drawing.Point(25, 35);
            this.lbl_ChonPhim.Name = "lbl_ChonPhim";
            this.lbl_ChonPhim.Size = new System.Drawing.Size(86, 20);
            this.lbl_ChonPhim.TabIndex = 8;
            this.lbl_ChonPhim.Text = "Chọn Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chọn Ghế";
            // 
            // frm_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ChonPhim);
            this.Controls.Add(this.btnExportStats);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.rtbBill);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.clbSeats);
            this.Controls.Add(this.cboRooms);
            this.Controls.Add(this.cboMovies);
            this.Name = "frm_Bai05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBai05";
            this.Load += new System.EventHandler(this.frm_Bai05_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMovies;
        private System.Windows.Forms.ComboBox cboRooms;
        private System.Windows.Forms.CheckedListBox clbSeats;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.RichTextBox rtbBill;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnExportStats;
        private System.Windows.Forms.Label lbl_ChonPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}