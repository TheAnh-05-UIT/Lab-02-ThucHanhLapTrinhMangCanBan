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
    public partial class frm_Bai02 : Form
    {
        public frm_Bai02()
        {
            InitializeComponent();
        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFile.FileName;
                    string content;
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        content = sr.ReadToEnd();
                    }

                    rtb_Content.Text = content;
                    FileInfo fileInfo = new FileInfo(filePath);
                    txt_FileName.Text = openFile.SafeFileName;
                    txt_URL.Text = filePath;
                    txt_Size.Text = fileInfo.Length.ToString() + " bytes";
                    txt_CharacterCount.Text = content.Length.ToString();
                    string[] lines = File.ReadAllLines(filePath);
                    txt_LineCount.Text = lines.Length.ToString();
                    string[] words = content.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    txt_WordCount.Text = words.Length.ToString();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
