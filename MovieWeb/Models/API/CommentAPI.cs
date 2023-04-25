namespace MovieWeb.Models.API
{
    public class CommentAPI
    {
        private int maComment;
        private int maTaiKhoan;
        private string? tenTaiKhoan;
        private string? Anh;
        private string? noiDung;
        private DateTime? thoiGianCmt;

        public CommentAPI(int maComment, int maTaiKhoan, string? tenTaiKhoan, string? anh, string? noiDung, DateTime? thoiGianCmt)
        {
            this.maComment = maComment;
            this.maTaiKhoan = maTaiKhoan;
            this.tenTaiKhoan = tenTaiKhoan;
            Anh = anh;
            this.noiDung = noiDung;
            this.thoiGianCmt = thoiGianCmt;
        }

        public int MaComment { get => maComment; set => maComment = value; }
        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string? TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string? Anh1 { get => Anh; set => Anh = value; }
        public string? NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime? ThoiGianCmt { get => thoiGianCmt; set => thoiGianCmt = value; }
    }
}
