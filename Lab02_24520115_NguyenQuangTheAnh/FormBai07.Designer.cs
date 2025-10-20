namespace Lab02_24520115_NguyenQuangTheAnh
{
    partial class frm_Bai07
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tv_TreeDir = new System.Windows.Forms.TreeView();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.rtb_Content = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv_TreeDir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtb_Content);
            this.splitContainer1.Panel2.Controls.Add(this.pb_picture);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // tv_TreeDir
            // 
            this.tv_TreeDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_TreeDir.Location = new System.Drawing.Point(0, 0);
            this.tv_TreeDir.Name = "tv_TreeDir";
            this.tv_TreeDir.Size = new System.Drawing.Size(266, 450);
            this.tv_TreeDir.TabIndex = 0;
            this.tv_TreeDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvExplorer_BeforeExpand);
            this.tv_TreeDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvExplorer_AfterSelect);
            // 
            // pb_picture
            // 
            this.pb_picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_picture.Location = new System.Drawing.Point(0, 0);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(530, 450);
            this.pb_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_picture.TabIndex = 0;
            this.pb_picture.TabStop = false;
            // 
            // rtb_Content
            // 
            this.rtb_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Content.Location = new System.Drawing.Point(0, 0);
            this.rtb_Content.Name = "rtb_Content";
            this.rtb_Content.Size = new System.Drawing.Size(530, 450);
            this.rtb_Content.TabIndex = 1;
            this.rtb_Content.Text = "";
            // 
            // frm_Bai07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_Bai07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBai07";
            this.Load += new System.EventHandler(this.frm_Bai07_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tv_TreeDir;
        private System.Windows.Forms.RichTextBox rtb_Content;
        private System.Windows.Forms.PictureBox pb_picture;
    }
}