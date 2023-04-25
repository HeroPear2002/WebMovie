using System;
using System.Collections.Generic;

namespace MovieWeb.Models;

public partial class ThoiLuongDaXem
{
    public int MaTaiKhoan { get; set; }

    public int MaTapPhim { get; set; }

    public int? ThoiGianDaXem { get; set; }

    public virtual TaiKhoan MaTaiKhoanNavigation { get; set; } = null!;

    public virtual Episode MaTapPhimNavigation { get; set; } = null!;
}
