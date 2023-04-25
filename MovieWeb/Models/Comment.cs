using System;
using System.Collections.Generic;

namespace MovieWeb.Models;

public partial class Comment
{
    public int MaComment { get; set; }

    public int? MaPhim { get; set; }

    public int? MaTaiKhoan { get; set; }

    public string? NoiDung { get; set; }

    public DateTime? ThoiGianCmt { get; set; }

    public virtual TPhim? MaPhimNavigation { get; set; }

    public virtual TaiKhoan? MaTaiKhoanNavigation { get; set; }
}
