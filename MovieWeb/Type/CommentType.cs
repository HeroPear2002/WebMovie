namespace MovieWeb.Type
{
    public class CommentType
    {


        public int? MaPhim { get; set; }

        public int? MaTaiKhoan { get; set; }

        public string? NoiDung { get; set; }

        public DateTime? ThoiGianCmt { get; set; }
        public CommentType(int? maPhim, int? maTaiKhoan, string? noiDung, DateTime? thoiGianCmt)
        {
            MaPhim = maPhim;
            MaTaiKhoan = maTaiKhoan;
            NoiDung = noiDung;
            ThoiGianCmt = thoiGianCmt;
        }
    }
}
