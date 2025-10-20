namespace Lab02_24520115_NguyenQuangTheAnh
{
    partial class frm_Bai02
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
            this.btn_File = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.lbl_URL = new System.Windows.Forms.Label();
            this.lbl_LineCount = new System.Windows.Forms.Label();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.lbl_wordCount = new System.Windows.Forms.Label();
            this.lbl_CharacterCount = new System.Windows.Forms.Label();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.txt_LineCount = new System.Windows.Forms.TextBox();
            this.txt_WordCount = new System.Windows.Forms.TextBox();
            this.txt_CharacterCount = new System.Windows.Forms.TextBox();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.rtb_Content = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_File
            // 
            this.btn_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_File.Location = new System.Drawing.Point(42, 26);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(444, 56);
            this.btn_File.TabIndex = 0;
            this.btn_File.Text = "Read From File";
            this.btn_File.UseVisualStyleBackColor = true;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(42, 468);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(444, 56);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FileName.Location = new System.Drawing.Point(42, 102);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(112, 26);
            this.lbl_FileName.TabIndex = 2;
            this.lbl_FileName.Text = "File Name";
            this.lbl_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_URL
            // 
            this.lbl_URL.AutoSize = true;
            this.lbl_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_URL.Location = new System.Drawing.Point(42, 218);
            this.lbl_URL.Name = "lbl_URL";
            this.lbl_URL.Size = new System.Drawing.Size(56, 26);
            this.lbl_URL.TabIndex = 3;
            this.lbl_URL.Text = "URL";
            this.lbl_URL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LineCount
            // 
            this.lbl_LineCount.AutoSize = true;
            this.lbl_LineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LineCount.Location = new System.Drawing.Point(42, 274);
            this.lbl_LineCount.Name = "lbl_LineCount";
            this.lbl_LineCount.Size = new System.Drawing.Size(117, 26);
            this.lbl_LineCount.TabIndex = 4;
            this.lbl_LineCount.Text = "Line Count";
            this.lbl_LineCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.Location = new System.Drawing.Point(42, 155);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(55, 26);
            this.lbl_Size.TabIndex = 5;
            this.lbl_Size.Text = "Size";
            this.lbl_Size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_wordCount
            // 
            this.lbl_wordCount.AutoSize = true;
            this.lbl_wordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wordCount.Location = new System.Drawing.Point(42, 338);
            this.lbl_wordCount.Name = "lbl_wordCount";
            this.lbl_wordCount.Size = new System.Drawing.Size(139, 26);
            this.lbl_wordCount.TabIndex = 6;
            this.lbl_wordCount.Text = "Words Count";
            this.lbl_wordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CharacterCount
            // 
            this.lbl_CharacterCount.AutoSize = true;
            this.lbl_CharacterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CharacterCount.Location = new System.Drawing.Point(42, 401);
            this.lbl_CharacterCount.Name = "lbl_CharacterCount";
            this.lbl_CharacterCount.Size = new System.Drawing.Size(171, 26);
            this.lbl_CharacterCount.TabIndex = 7;
            this.lbl_CharacterCount.Text = "Character Count";
            this.lbl_CharacterCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_FileName
            // 
            this.txt_FileName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FileName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_FileName.Location = new System.Drawing.Point(240, 104);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.ReadOnly = true;
            this.txt_FileName.Size = new System.Drawing.Size(246, 30);
            this.txt_FileName.TabIndex = 8;
            // 
            // txt_Size
            // 
            this.txt_Size.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Size.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Size.Location = new System.Drawing.Point(240, 157);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.ReadOnly = true;
            this.txt_Size.Size = new System.Drawing.Size(246, 30);
            this.txt_Size.TabIndex = 9;
            // 
            // txt_LineCount
            // 
            this.txt_LineCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_LineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LineCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_LineCount.Location = new System.Drawing.Point(240, 276);
            this.txt_LineCount.Name = "txt_LineCount";
            this.txt_LineCount.ReadOnly = true;
            this.txt_LineCount.Size = new System.Drawing.Size(246, 30);
            this.txt_LineCount.TabIndex = 10;
            // 
            // txt_WordCount
            // 
            this.txt_WordCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_WordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_WordCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_WordCount.Location = new System.Drawing.Point(240, 340);
            this.txt_WordCount.Name = "txt_WordCount";
            this.txt_WordCount.ReadOnly = true;
            this.txt_WordCount.Size = new System.Drawing.Size(246, 30);
            this.txt_WordCount.TabIndex = 11;
            // 
            // txt_CharacterCount
            // 
            this.txt_CharacterCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_CharacterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CharacterCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_CharacterCount.Location = new System.Drawing.Point(240, 403);
            this.txt_CharacterCount.Name = "txt_CharacterCount";
            this.txt_CharacterCount.ReadOnly = true;
            this.txt_CharacterCount.Size = new System.Drawing.Size(246, 30);
            this.txt_CharacterCount.TabIndex = 12;
            // 
            // txt_URL
            // 
            this.txt_URL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_URL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_URL.Location = new System.Drawing.Point(240, 220);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.ReadOnly = true;
            this.txt_URL.Size = new System.Drawing.Size(246, 30);
            this.txt_URL.TabIndex = 13;
            // 
            // rtb_Content
            // 
            this.rtb_Content.Location = new System.Drawing.Point(548, 26);
            this.rtb_Content.Name = "rtb_Content";
            this.rtb_Content.ReadOnly = true;
            this.rtb_Content.Size = new System.Drawing.Size(494, 498);
            this.rtb_Content.TabIndex = 14;
            this.rtb_Content.Text = "";
            // 
            // frm_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 558);
            this.Controls.Add(this.rtb_Content);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.txt_CharacterCount);
            this.Controls.Add(this.txt_WordCount);
            this.Controls.Add(this.txt_LineCount);
            this.Controls.Add(this.txt_Size);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.lbl_CharacterCount);
            this.Controls.Add(this.lbl_wordCount);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.lbl_LineCount);
            this.Controls.Add(this.lbl_URL);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_File);
            this.Name = "frm_Bai02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.Label lbl_URL;
        private System.Windows.Forms.Label lbl_LineCount;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Label lbl_wordCount;
        private System.Windows.Forms.Label lbl_CharacterCount;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.TextBox txt_LineCount;
        private System.Windows.Forms.TextBox txt_WordCount;
        private System.Windows.Forms.TextBox txt_CharacterCount;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.RichTextBox rtb_Content;
    }
}