namespace Lab02_24520115_NguyenQuangTheAnh
{
    partial class frm_Bai06
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
            this.lv_ListMon = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pb_PictureMon = new System.Windows.Forms.PictureBox();
            this.lbl_NguoiDongGop = new System.Windows.Forms.Label();
            this.lbl_TenMonAn = new System.Windows.Forms.Label();
            this.btn_Random = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureMon)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_ListMon
            // 
            this.lv_ListMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_TenMon});
            this.lv_ListMon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lv_ListMon.HideSelection = false;
            this.lv_ListMon.Location = new System.Drawing.Point(0, 0);
            this.lv_ListMon.Name = "lv_ListMon";
            this.lv_ListMon.Size = new System.Drawing.Size(220, 559);
            this.lv_ListMon.TabIndex = 0;
            this.lv_ListMon.UseCompatibleStateImageBehavior = false;
            this.lv_ListMon.View = System.Windows.Forms.View.Details;
            // 
            // col_id
            // 
            this.col_id.Text = "id";
            this.col_id.Width = 74;
            // 
            // col_TenMon
            // 
            this.col_TenMon.Text = "ten mon an";
            this.col_TenMon.Width = 156;
            // 
            // pb_PictureMon
            // 
            this.pb_PictureMon.Location = new System.Drawing.Point(220, 0);
            this.pb_PictureMon.Name = "pb_PictureMon";
            this.pb_PictureMon.Size = new System.Drawing.Size(654, 376);
            this.pb_PictureMon.TabIndex = 1;
            this.pb_PictureMon.TabStop = false;
            // 
            // lbl_NguoiDongGop
            // 
            this.lbl_NguoiDongGop.AutoSize = true;
            this.lbl_NguoiDongGop.Location = new System.Drawing.Point(547, 416);
            this.lbl_NguoiDongGop.Name = "lbl_NguoiDongGop";
            this.lbl_NguoiDongGop.Size = new System.Drawing.Size(51, 20);
            this.lbl_NguoiDongGop.TabIndex = 2;
            this.lbl_NguoiDongGop.Text = "label1";
            // 
            // lbl_TenMonAn
            // 
            this.lbl_TenMonAn.AutoSize = true;
            this.lbl_TenMonAn.Location = new System.Drawing.Point(226, 416);
            this.lbl_TenMonAn.Name = "lbl_TenMonAn";
            this.lbl_TenMonAn.Size = new System.Drawing.Size(51, 20);
            this.lbl_TenMonAn.TabIndex = 3;
            this.lbl_TenMonAn.Text = "label2";
            // 
            // btn_Random
            // 
            this.btn_Random.Location = new System.Drawing.Point(359, 471);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(192, 48);
            this.btn_Random.TabIndex = 4;
            this.btn_Random.Text = "Chọn Món";
            this.btn_Random.UseVisualStyleBackColor = true;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click_1);
            // 
            // frm_Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 559);
            this.Controls.Add(this.btn_Random);
            this.Controls.Add(this.lbl_TenMonAn);
            this.Controls.Add(this.lbl_NguoiDongGop);
            this.Controls.Add(this.pb_PictureMon);
            this.Controls.Add(this.lv_ListMon);
            this.Name = "frm_Bai06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBai06";
            this.Load += new System.EventHandler(this.FormBai06_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_ListMon;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_TenMon;
        private System.Windows.Forms.PictureBox pb_PictureMon;
        private System.Windows.Forms.Label lbl_NguoiDongGop;
        private System.Windows.Forms.Label lbl_TenMonAn;
        private System.Windows.Forms.Button btn_Random;
    }
}