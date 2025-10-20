using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_24520115_NguyenQuangTheAnh
{
    public partial class frm_Bai06 : Form
    {
        public frm_Bai06()
        {
            InitializeComponent();
        }

        private void FormBai06_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();
            LoadDishesToListView();
        }

        private void LoadDishesToListView()
        {
            lv_ListMon.Items.Clear();

            string sql = "SELECT IDMA, TenMonAn FROM MonAn";

            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Tạo một hàng mới cho ListView
                            ListViewItem item = new ListViewItem(reader["IDMA"].ToString());
                            item.SubItems.Add(reader["TenMonAn"].ToString());
                            lv_ListMon.Items.Add(item);
                        }
                    }
                }
            }
        }

        // Sự kiện khi nhấn nút "Chọn Món Ngẫu Nhiên"

        private void btn_Random_Click_1(object sender, EventArgs e)
        {
            // Câu lệnh SQL JOIN 2 bảng, sắp xếp ngẫu nhiên và lấy ra 1 dòng đầu tiên
            string sql = @"
            SELECT T1.TenMonAn, T1.HinhAnh, T2.HoVaTen
            FROM MonAn AS T1
            JOIN NguoiDung AS T2 ON T1.IDNCC = T2.IDNCC
            ORDER BY RANDOM()
            LIMIT 1";

            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Cập nhật giao diện
                            lbl_TenMonAn.Text = "Tên Món Ăn: " + reader["TenMonAn"].ToString();
                            lbl_NguoiDongGop.Text = "Người Đóng Góp: " + reader["HoVaTen"].ToString();

                            string imagePath = reader["HinhAnh"].ToString();
                            if (File.Exists(imagePath))
                            {
                                pb_PictureMon.Image = Image.FromFile(imagePath);
                            }
                            else
                            {
                                pb_PictureMon.Image = null; // Xóa ảnh nếu không tìm thấy file
                                MessageBox.Show("Không tìm thấy file ảnh: " + imagePath);
                            }
                        }
                    }
                }
            }
        }
    }
}
