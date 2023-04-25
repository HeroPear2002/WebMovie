using System;
using System.Collections.Generic;

namespace MovieWeb.Models;

public partial class HinhThuc
{
    public int MaHinhThuc { get; set; }

    public string? TenHinhThuc { get; set; }

    public virtual ICollection<TPhim> TPhims { get; set; } = new List<TPhim>();
}
