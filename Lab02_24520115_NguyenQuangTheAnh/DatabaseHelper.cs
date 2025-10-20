using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System.IO;

public static class DatabaseHelper
{
    private static string dbFile = "QLMonA.sqlite";

    // Hàm khởi tạo, sẽ tạo DB, table và chèn dữ liệu nếu file DB không tồn tại
    public static void InitializeDatabase()
    {
        if (!File.Exists(dbFile))
        {
            SQLiteConnection.CreateFile(dbFile);

            using (var connection = new SQLiteConnection($"Data Source={dbFile};Version=3;"))
            {
                connection.Open();

                // Câu lệnh tạo bảng NguoiDung
                string sqlNguoiDung = @"
                CREATE TABLE NguoiDung (
                    IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                    HoVaTen TEXT NOT NULL,
                    QuyenHan TEXT
                )";
                using (var command = new SQLiteCommand(sqlNguoiDung, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Câu lệnh tạo bảng MonAn
                string sqlMonAn = @"
                CREATE TABLE MonAn (
                    IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                    TenMonAn TEXT NOT NULL,
                    HinhAnh TEXT,
                    IDNCC INTEGER,
                    FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC)
                )";
                using (var command = new SQLiteCommand(sqlMonAn, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Chèn dữ liệu mẫu
                InsertInitialData(connection);
            }
        }
    }

    private static void InsertInitialData(SQLiteConnection connection)
    {
        string sql = @"
        INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES 
            ('Nguyễn Quang Thế Anh', 'Admin'), 
            ('Trần Thị Minh Anh', 'User'),
            ('Võ Trần Đức', 'User');

        INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES
            ('Phở Bò', 'Images\\Pho.jpg', 1),
            ('Bún Chả', 'Images\\Bun.jpg', 1),
            ('Cơm Tấm', 'Images\\Com.jpg', 2),
            ('Mì Tôm', 'Images\\Mi.jpg', 2),
            ('Hủ Tiếu', 'Images\\HuTieu.jpg', 3),
            ('Cháo', 'Images\\Chao.jpg', 3);
        ";

        using (var command = new SQLiteCommand(sql, connection))
        {
            command.ExecuteNonQuery();
        }
    }

    public static SQLiteConnection GetConnection()
    {
        return new SQLiteConnection($"Data Source={dbFile};Version=3;");
    }
}