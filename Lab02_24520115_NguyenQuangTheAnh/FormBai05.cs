using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_24520115_NguyenQuangTheAnh
{
    public partial class frm_Bai05 : Form
    {
        public frm_Bai05()
        {
            InitializeComponent();
        }

        private void frm_Bai05_Load(object sender, EventArgs e)
        {
            InitializeSeatData();
            LoadMoviesFromFile();
            PopulateMovieComboBox();
        }
        public class Movie
        {
            public string Name { get; set; }
            public decimal StandardPrice { get; set; }
            public List<int> AvailableRooms { get; set; }

            // --- Thuộc tính mới để theo dõi thống kê ---
            public int TicketsSold { get; set; } = 0; // Khởi tạo bằng 0
            public decimal Revenue { get; set; } = 0; // Khởi tạo bằng 0
        }

        Dictionary<string, Movie> movies = new Dictionary<string, Movie>();
        Dictionary<string, decimal> seatTierMultipliers = new Dictionary<string, decimal>();
        Dictionary<int, List<string>> bookedSeats = new Dictionary<int, List<string>>();
        List<string> allSeatCodes = new List<string>();
        private string inputFile = "inputFormBai5.txt";
        private string outputFile = "outputFormBai5.txt";

        // --- LOGIC ĐỌC/GHI FILE VÀ THỐNG KÊ ---

        private void LoadMoviesFromFile()
        {
            if (!File.Exists(inputFile))
            {
                MessageBox.Show($"File '{inputFile}' không tồn tại. Vui lòng tạo file và khởi động lại ứng dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(inputFile);
                int i = 0;
                int movieCount = int.Parse(lines[i++]);

                for (int j = 0; j < movieCount; j++)
                {
                    Movie movie = new Movie();
                    movie.Name = lines[i++];
                    movie.StandardPrice = decimal.Parse(lines[i++]);
                    movie.AvailableRooms = lines[i++].Split(' ').Select(int.Parse).ToList();

                    movies.Add(movie.Name, movie);

                    // Khởi tạo danh sách ghế trống cho các phòng của phim này
                    foreach (var room in movie.AvailableRooms)
                    {
                        if (!bookedSeats.ContainsKey(room))
                        {
                            bookedSeats.Add(room, new List<string>());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file input: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportStats_Click(object sender, EventArgs e)
        {
            // 1. Chuẩn bị UI cho việc xuất file
            lblStatus.Text = "Đang chuẩn bị xuất file...";
            lblStatus.Visible = true;
            progressBar.Visible = true;
            progressBar.Value = 0;
            progressBar.Maximum = movies.Count;
            progressBar.Step = 1;

            // 2. Sắp xếp phim theo doanh thu giảm dần để xếp hạng
            var sortedMovies = movies.Values.OrderByDescending(m => m.Revenue).ToList();

            // 3. Ghi ra file
            try
            {
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine("--- BÁO CÁO DOANH THU PHÒNG VÉ ---");
                    writer.WriteLine($"Ngày xuất: {DateTime.Now}");
                    writer.WriteLine("======================================");

                    for (int i = 0; i < sortedMovies.Count; i++)
                    {
                        Movie movie = sortedMovies[i];
                        int rank = i + 1;

                        // Tính toán các chỉ số thống kê
                        int totalSeats = movie.AvailableRooms.Count * 15; // Mỗi phòng có 15 ghế
                        int ticketsRemaining = totalSeats - movie.TicketsSold;
                        double soldRate = (totalSeats > 0) ? ((double)movie.TicketsSold / totalSeats) : 0;

                        // Cập nhật UI
                        lblStatus.Text = $"Đang xử lý phim: {movie.Name}...";
                        Application.DoEvents(); // Bắt buộc để UI cập nhật

                        // Ghi thông tin vào file
                        writer.WriteLine($"Hạng {rank}: {movie.Name}");
                        writer.WriteLine($"\t- Doanh thu: {movie.Revenue:N0}đ");
                        writer.WriteLine($"\t- Vé bán ra: {movie.TicketsSold}");
                        writer.WriteLine($"\t- Vé tồn: {ticketsRemaining}");
                        writer.WriteLine($"\t- Tỉ lệ lấp đầy: {soldRate:P2}"); // P2 là định dạng %
                        writer.WriteLine("--------------------------------------");

                        Thread.Sleep(300); // Giả lập công việc đang xử lý để thấy ProgressBar chạy
                        progressBar.PerformStep();
                    }
                }
                lblStatus.Text = "Xuất file thành công!";
                MessageBox.Show($"Đã xuất file thống kê '{outputFile}' thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file output: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // --- LOGIC ĐẶT VÉ (Tương tự bài trước) ---

        private void cboMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboRooms.Items.Clear();
            cboRooms.Text = "";
            clbSeats.Items.Clear();
            string selectedMovieName = cboMovies.SelectedItem.ToString();
            Movie selectedMovie = movies[selectedMovieName];
            foreach (int roomNumber in selectedMovie.AvailableRooms)
            {
                cboRooms.Items.Add(roomNumber);
            }
            cboRooms.Enabled = true;
        }

        private void cboRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbSeats.Items.Clear();
            if (cboRooms.SelectedItem == null) return;
            int selectedRoom = (int)cboRooms.SelectedItem;
            List<string> currentlyBooked = bookedSeats[selectedRoom];
            foreach (string seatCode in allSeatCodes)
            {
                if (!currentlyBooked.Contains(seatCode))
                {
                    clbSeats.Items.Add(seatCode);
                }
            }
            clbSeats.Enabled = true;
            btnBook.Enabled = true;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cboMovies.SelectedItem == null || cboRooms.SelectedItem == null || clbSeats.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phim, phòng và ít nhất một ghế.");
                return;
            }

            string selectedMovieName = cboMovies.SelectedItem.ToString();
            Movie selectedMovie = movies[selectedMovieName];
            int selectedRoom = (int)cboRooms.SelectedItem;
            decimal totalAmount = 0;

            StringBuilder bill = new StringBuilder();
            bill.AppendLine($"--- HÓA ĐƠN: {selectedMovieName} ---");

            foreach (object item in clbSeats.CheckedItems)
            {
                string seatCode = item.ToString();
                decimal ticketPrice = selectedMovie.StandardPrice * seatTierMultipliers[seatCode];
                totalAmount += ticketPrice;
                bill.AppendLine($"- Ghế {seatCode}: {ticketPrice:N0}đ");
                bookedSeats[selectedRoom].Add(seatCode);
            }

            // CẬP NHẬT THỐNG KÊ SAU KHI ĐẶT VÉ
            selectedMovie.TicketsSold += clbSeats.CheckedItems.Count;
            selectedMovie.Revenue += totalAmount;

            bill.AppendLine("--------------------------");
            bill.AppendLine($"TỔNG TIỀN: {totalAmount:N0}đ");
            rtbBill.Text = bill.ToString();
            cboRooms_SelectedIndexChanged(null, null); // Cập nhật lại danh sách ghế
        }

        // --- HÀM KHỞI TẠO DỮ LIỆU ---

        private void InitializeSeatData()
        {
            string[] rows = { "A", "B", "C" };
            for (int i = 1; i <= 5; i++)
            {
                foreach (var row in rows) allSeatCodes.Add($"{row}{i}");
            }
            seatTierMultipliers.Add("A1", 0.25m); seatTierMultipliers.Add("A5", 0.25m);
            seatTierMultipliers.Add("C1", 0.25m); seatTierMultipliers.Add("C5", 0.25m);
            seatTierMultipliers.Add("B2", 2m); seatTierMultipliers.Add("B3", 2m); seatTierMultipliers.Add("B4", 2m);
            foreach (var seat in allSeatCodes)
            {
                if (!seatTierMultipliers.ContainsKey(seat)) seatTierMultipliers.Add(seat, 1m);
            }
        }

        private void PopulateMovieComboBox()
        {
            foreach (string movieName in movies.Keys)
            {
                cboMovies.Items.Add(movieName);
            }
        }

        private void rtbBill_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
