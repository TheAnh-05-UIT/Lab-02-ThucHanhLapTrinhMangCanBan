namespace Lab02_24520115_NguyenQuangTheAnh
{
    partial class frm_Bai03
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
            this.btn_DocFile = new System.Windows.Forms.Button();
            this.btn_GhiFile = new System.Windows.Forms.Button();
            this.btn_KetQua = new System.Windows.Forms.Button();
            this.rtb_Content = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_DocFile
            // 
            this.btn_DocFile.Location = new System.Drawing.Point(79, 84);
            this.btn_DocFile.Name = "btn_DocFile";
            this.btn_DocFile.Size = new System.Drawing.Size(202, 54);
            this.btn_DocFile.TabIndex = 0;
            this.btn_DocFile.Text = "Đọc File";
            this.btn_DocFile.UseVisualStyleBackColor = true;
            this.btn_DocFile.Click += new System.EventHandler(this.btn_DocFile_Click);
            // 
            // btn_GhiFile
            // 
            this.btn_GhiFile.Location = new System.Drawing.Point(79, 197);
            this.btn_GhiFile.Name = "btn_GhiFile";
            this.btn_GhiFile.Size = new System.Drawing.Size(202, 54);
            this.btn_GhiFile.TabIndex = 1;
            this.btn_GhiFile.Text = "Ghi File";
            this.btn_GhiFile.UseVisualStyleBackColor = true;
            this.btn_GhiFile.Click += new System.EventHandler(this.btn_GhiFile_Click);
            // 
            // btn_KetQua
            // 
            this.btn_KetQua.Location = new System.Drawing.Point(79, 311);
            this.btn_KetQua.Name = "btn_KetQua";
            this.btn_KetQua.Size = new System.Drawing.Size(202, 54);
            this.btn_KetQua.TabIndex = 3;
            this.btn_KetQua.Text = "Kết Quả";
            this.btn_KetQua.UseVisualStyleBackColor = true;
            this.btn_KetQua.Click += new System.EventHandler(this.btn_KetQua_Click);
            // 
            // rtb_Content
            // 
            this.rtb_Content.Location = new System.Drawing.Point(357, 84);
            this.rtb_Content.Name = "rtb_Content";
            this.rtb_Content.Size = new System.Drawing.Size(381, 281);
            this.rtb_Content.TabIndex = 4;
            this.rtb_Content.Text = "";
            // 
            // frm_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_Content);
            this.Controls.Add(this.btn_KetQua);
            this.Controls.Add(this.btn_GhiFile);
            this.Controls.Add(this.btn_DocFile);
            this.Name = "frm_Bai03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBai03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DocFile;
        private System.Windows.Forms.Button btn_GhiFile;
        private System.Windows.Forms.Button btn_KetQua;
        private System.Windows.Forms.RichTextBox rtb_Content;
    }
}