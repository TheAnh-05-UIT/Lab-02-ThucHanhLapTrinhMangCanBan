using Spire.Doc;
using Spire.Pdf;
using Spire.Presentation;
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
    public partial class frm_Bai07 : Form
    {
        public frm_Bai07()
        {
            InitializeComponent();
        }

        private void frm_Bai07_Load(object sender, EventArgs e)
        {
            rtb_Content.Visible = false;
            pb_picture.Visible = false;
            LoadDrives();
        }

        private void LoadDrives()
        {
            tv_TreeDir.Nodes.Clear();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                if (drive.IsReady)
                {
                    TreeNode driveNode = new TreeNode(drive.Name);
                    driveNode.Tag = drive.RootDirectory.FullName; // Lưu đường dẫn đầy đủ vào Tag
                    driveNode.Nodes.Add("dummy"); // Thêm một node giả để hiển thị dấu '+'
                    tv_TreeDir.Nodes.Add(driveNode);
                }
            }
        }

        // Sự kiện xảy ra ngay TRƯỚC KHI một node được mở rộng (bấm vào dấu '+')
        private void tvExplorer_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Kiểm tra xem node đã được load hay chưa (dựa vào node giả "dummy")
            if (selectedNode.Nodes.Count == 1 && selectedNode.Nodes[0].Text == "dummy")
            {
                selectedNode.Nodes.Clear(); // Xóa node giả đi

                string fullPath = selectedNode.Tag.ToString();

                try
                {
                    // Lấy và thêm các thư mục con
                    string[] directories = Directory.GetDirectories(fullPath);
                    foreach (string dir in directories)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode dirNode = new TreeNode(di.Name);
                        dirNode.Tag = dir;
                        dirNode.Nodes.Add("dummy"); // Thêm node giả cho các thư mục con
                        selectedNode.Nodes.Add(dirNode);
                    }

                    // Lấy và thêm các file
                    string[] files = Directory.GetFiles(fullPath);
                    foreach (string file in files)
                    {
                        FileInfo fi = new FileInfo(file);
                        TreeNode fileNode = new TreeNode(fi.Name);
                        fileNode.Tag = file;
                        selectedNode.Nodes.Add(fileNode);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    selectedNode.Nodes.Add("Access Denied");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Sự kiện xảy ra SAU KHI một node được chọn (click chuột vào)
        private void tvExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Tag == null) return;

            string fullPath = selectedNode.Tag.ToString();

            // Kiểm tra nếu đường dẫn là một file
            if (File.Exists(fullPath))
            {
                DisplayFileContent(fullPath);
            }
            else // Nếu là thư mục thì xóa nội dung đang hiển thị
            {
                rtb_Content.Visible = false;
                pb_picture.Visible = false;
            }
        }

        // Hàm hiển thị nội dung file tùy theo định dạng
        private void DisplayFileContent(string filePath)
        {
            // Lấy phần mở rộng của file và chuyển thành chữ thường
            string extension = Path.GetExtension(filePath).ToLower();

            // Danh sách các định dạng hỗ trợ
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            string[] textExtensions = { ".txt", ".log", ".cs", ".xml", ".html", ".config" };
            string[] wordExtensions = { ".doc", ".docx" };
            string[] pdfExtensions = { ".pdf" };
            string[] pptExtensions = { ".ppt", ".pptx" };

            try
            {
                // Ẩn tất cả các control trước khi hiển thị
                pb_picture.Visible = false;
                rtb_Content.Visible = false;

                // Nếu là file ảnh
                if (Array.IndexOf(imageExtensions, extension) != -1)
                {
                    pb_picture.Image = Image.FromFile(filePath);
                    pb_picture.Visible = true;
                }
                // Nếu là file văn bản thuần túy
                else if (Array.IndexOf(textExtensions, extension) != -1)
                {
                    rtb_Content.Text = File.ReadAllText(filePath);
                    rtb_Content.Visible = true;
                }
                // Nếu là file Word
                else if (Array.IndexOf(wordExtensions, extension) != -1)
                {
                    Document document = new Document();
                    document.LoadFromFile(filePath);
                    rtb_Content.Text = document.GetText();
                    rtb_Content.Visible = true;
                }
                // NẾU LÀ FILE PDF
                else if (Array.IndexOf(pdfExtensions, extension) != -1)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.LoadFromFile(filePath);

                    // Dùng StringBuilder để nối text từ nhiều trang hiệu quả hơn
                    StringBuilder content = new StringBuilder();
                    foreach (PdfPageBase page in pdf.Pages)
                    {
                        content.Append(page.ExtractText());
                    }

                    rtb_Content.Text = content.ToString();
                    rtb_Content.Visible = true;
                }
                // NẾU LÀ FILE POWERPOINT
                else if (Array.IndexOf(pptExtensions, extension) != -1)
                {
                    Presentation presentation = new Presentation();
                    presentation.LoadFromFile(filePath);

                    StringBuilder content = new StringBuilder();
                    // Duyệt qua từng slide
                    foreach (ISlide slide in presentation.Slides)
                    {
                        // Duyệt qua từng đối tượng (shape) trong slide
                        foreach (IShape shape in slide.Shapes)
                        {
                            // Nếu đối tượng đó là một textbox hoặc có chứa text
                            if (shape is IAutoShape autoShape)
                            {
                                // Lấy nội dung text
                                content.AppendLine(autoShape.TextFrame.Text);
                            }
                        }
                        content.AppendLine("--- End of Slide ---"); // Thêm ngăn cách giữa các slide
                    }

                    rtb_Content.Text = content.ToString();
                    rtb_Content.Visible = true;
                }
                // Các loại file khác không xử lý
                else
                {
                    rtb_Content.Text = $"Định dạng file '{extension}' không được hỗ trợ.";
                    rtb_Content.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đọc file: " + ex.Message);
            }
        }
    }
}
