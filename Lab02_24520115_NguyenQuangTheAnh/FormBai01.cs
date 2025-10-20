using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_24520115_NguyenQuangTheAnh
{
    public partial class frm_Bai01 : Form
    {
        public frm_Bai01()
        {
            InitializeComponent();
        }

        private void btn_DocFile_Click(object sender, EventArgs e)
        {
            string filePath = "inputFormBai1.txt";
            try
            {
                string content = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(content))
                {
                    MessageBox.Show("File đang rỗng.");
                }
                using (StreamReader sr = new StreamReader(filePath))
                {
                    rtb_Content.Text = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file" + ex.Message);
            }
            
        }

        private void btn_GhiFile_Click(object sender, EventArgs e)
        {
            string contentToWrite = rtb_Content.Text;
            string filePath = "outputFormBai1.txt";
            if (!string.IsNullOrWhiteSpace(contentToWrite))
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.Write(contentToWrite.ToUpper());
                }
                MessageBox.Show("Ghi file thành công!");
            }
            else
            {
                MessageBox.Show("Không có nội dung để ghi!");
            }
        }

        private void rtb_Content_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
