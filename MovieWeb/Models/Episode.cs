using System;
using System.Collections.Generic;

namespace MovieWeb.Models;

public partial class Episode
{
    public int MaTapPhim { get; set; }

    public int? MaPhim { get; set; }

    public int? SoTapPhim { get; set; }

    public string? Duonglink { get; set; }

    public int? LuotXem { get; set; }

    public virtual TPhim? MaPhimNavigation { get; set; }

    public virtual ICollection<ThoiLuongDaXem> ThoiLuongDaXems { get; set; } = new List<ThoiLuongDaXem>();
}
