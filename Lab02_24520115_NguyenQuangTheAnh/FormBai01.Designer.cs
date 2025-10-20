namespace Lab02_24520115_NguyenQuangTheAnh
{
    partial class frm_Bai01
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
            this.rtb_Content = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_DocFile
            // 
            this.btn_DocFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DocFile.Location = new System.Drawing.Point(57, 95);
            this.btn_DocFile.Name = "btn_DocFile";
            this.btn_DocFile.Size = new System.Drawing.Size(193, 59);
            this.btn_DocFile.TabIndex = 0;
            this.btn_DocFile.Text = "Đọc File";
            this.btn_DocFile.UseVisualStyleBackColor = true;
            this.btn_DocFile.Click += new System.EventHandler(this.btn_DocFile_Click);
            // 
            // btn_GhiFile
            // 
            this.btn_GhiFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GhiFile.Location = new System.Drawing.Point(57, 236);
            this.btn_GhiFile.Name = "btn_GhiFile";
            this.btn_GhiFile.Size = new System.Drawing.Size(193, 59);
            this.btn_GhiFile.TabIndex = 1;
            this.btn_GhiFile.Text = "Ghi File";
            this.btn_GhiFile.UseVisualStyleBackColor = true;
            this.btn_GhiFile.Click += new System.EventHandler(this.btn_GhiFile_Click);
            // 
            // rtb_Content
            // 
            this.rtb_Content.Location = new System.Drawing.Point(308, 95);
            this.rtb_Content.Name = "rtb_Content";
            this.rtb_Content.Size = new System.Drawing.Size(437, 302);
            this.rtb_Content.TabIndex = 2;
            this.rtb_Content.Text = "";
            this.rtb_Content.TextChanged += new System.EventHandler(this.rtb_Content_TextChanged);
            // 
            // frm_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_Content);
            this.Controls.Add(this.btn_GhiFile);
            this.Controls.Add(this.btn_DocFile);
            this.Name = "frm_Bai01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBai01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DocFile;
        private System.Windows.Forms.Button btn_GhiFile;
        private System.Windows.Forms.RichTextBox rtb_Content;
    }
}