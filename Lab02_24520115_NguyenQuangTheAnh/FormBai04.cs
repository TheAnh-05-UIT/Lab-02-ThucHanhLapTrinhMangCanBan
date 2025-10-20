using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_24520115_NguyenQuangTheAnh
{
    public partial class frm_Bai04 : Form
    {

        [Serializable] // Rất quan trọng!
        public class SinhVien
        {
            public string HoVaTen { get; set; }
            public int MSSV { get; set; }
            public string DienThoai { get; set; }
            public float DiemMon1 { get; set; }
            public float DiemMon2 { get; set; }
            public float DiemMon3 { get; set; }
            public float DiemTrungBinh { get; set; } // Sẽ được tính sau khi đọc file
        }
        public frm_Bai04()
        {
            InitializeComponent();
        }

        private List<SinhVien> studentsInMemory = new List<SinhVien>();

        // Danh sách để lưu sinh viên đọc từ file và hiển thị
        private List<SinhVien> studentsFromFile = new List<SinhVien>();
        private int currentIndex = -1; // Vị trí sinh viên đang được hiển thị

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out SinhVien sv))
            {
                return; // Dừng lại nếu dữ liệu không hợp lệ
            }

            // 2. Thêm sinh viên vào danh sách trong bộ nhớ
            studentsInMemory.Add(sv);

            // 3. Cập nhật ListBox để hiển thị
            listBoxStudents.Items.Add($"{sv.MSSV} - {sv.HoVaTen} | {sv.DiemMon1} | {sv.DiemMon2} | {sv.DiemMon3}");

            // 4. Xóa các ô input để chuẩn bị cho lần nhập tiếp theo
            ClearInputFields();
        }

        private void frm_Bai04_Load(object sender, EventArgs e)
        {

        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            if (studentsInMemory.Count == 0)
            {
                MessageBox.Show("Chưa có sinh viên nào để ghi xuống file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (FileStream fs = new FileStream("inputFormBai4.txt", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, studentsInMemory);
                }
                MessageBox.Show($"Đã ghi thành công {studentsInMemory.Count} sinh viên vào file 'input4.txt'.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            if (!File.Exists("inputFormBai4.txt"))
            {
                MessageBox.Show("Không tìm thấy file 'inputFormBai4.txt'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 1. Đọc mảng sinh viên từ file input4.txt
                using (FileStream fs = new FileStream("inputFormBai4.txt", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    studentsFromFile = (List<SinhVien>)formatter.Deserialize(fs);
                }

                // 2. Tính điểm trung bình cho từng sinh viên
                foreach (var sv in studentsFromFile)
                {
                    sv.DiemTrungBinh = (sv.DiemMon1 + sv.DiemMon2 + sv.DiemMon3) / 3;
                }

                // 3. Ghi mảng đã xử lý xuống file output4.txt
                using (FileStream fs = new FileStream("outputFormBai4.txt", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, studentsFromFile);
                }

                MessageBox.Show($"Đã đọc và xử lý {studentsFromFile.Count} sinh viên. \nKết quả đã được ghi vào 'output4.txt'.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Hiển thị sinh viên đầu tiên và cài đặt phân trang
                if (studentsFromFile.Count > 0)
                {
                    currentIndex = 0;
                    DisplayStudentAtIndex(currentIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc và xử lý file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (currentIndex < studentsFromFile.Count - 1)
            {
                currentIndex++;
                DisplayStudentAtIndex(currentIndex);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayStudentAtIndex(currentIndex);
            }
        }

        private bool ValidateInput(out SinhVien sv)
        {
            sv = new SinhVien();

            // Tên
            if (string.IsNullOrWhiteSpace(txt_WriteName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // MSSV: 8 chữ số
            if (!int.TryParse(txt_WriteId.Text, out int mssv) || txt_WriteId.Text.Length != 8)
            {
                MessageBox.Show("MSSV phải là một số có 8 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Điện thoại: 10 chữ số, bắt đầu bằng 0
            string phone = txt_WritePhone.Text;
            if (phone.Length != 10 || !phone.StartsWith("0") || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Điểm: từ 0 đến 10
            if (!float.TryParse(txt_WriteCourseOne.Text, out float c1) || c1 < 0 || c1 > 10 ||
                !float.TryParse(txt_WriteCourseTwo.Text, out float c2) || c2 < 0 || c2 > 10 ||
                !float.TryParse(txt_WriteCourseThree.Text, out float c3) || c3 < 0 || c3 > 10)
            {
                MessageBox.Show("Điểm của các môn học phải là số từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Nếu tất cả hợp lệ, tạo đối tượng SinhVien
            sv.HoVaTen = txt_WriteName.Text;
            sv.MSSV = mssv;
            sv.DienThoai = phone;
            sv.DiemMon1 = c1;
            sv.DiemMon2 = c2;
            sv.DiemMon3 = c3;

            return true;
        }

        private void DisplayStudentAtIndex(int index)
        {
            if (index < 0 || index >= studentsFromFile.Count) return;

            SinhVien sv = studentsFromFile[index];
            txt_ReadName.Text = sv.HoVaTen;
            txt_ReadId.Text = sv.MSSV.ToString();
            txt_ReadPhone.Text = sv.DienThoai;
            txt_ReadCourseOne.Text = sv.DiemMon1.ToString();
            txt_ReadCourseTwo.Text = sv.DiemMon2.ToString();
            txt_ReadCourseThree.Text = sv.DiemMon3.ToString();
            txt_ReadCourseAvg.Text = sv.DiemTrungBinh.ToString("F2"); // F2 để làm tròn 2 chữ số thập phân

            // Cập nhật thông tin phân trang
            lbl_Number.Text = $"{index + 1} / {studentsFromFile.Count}";
            btn_Back.Enabled = (index > 0);
            btn_Next.Enabled = (index < studentsFromFile.Count - 1);
        }

        private void ClearInputFields()
        {
            txt_WriteName.Clear();
            txt_WriteId.Clear();
            txt_WritePhone.Clear();
            txt_WriteCourseOne.Clear();
            txt_WriteCourseTwo.Clear();
            txt_WriteCourseThree.Clear();
            txt_WriteName.Focus();
        }
    }
}
