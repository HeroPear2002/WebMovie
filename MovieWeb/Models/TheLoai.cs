using System;
using System.Collections.Generic;

namespace MovieWeb.Models;

public partial class TheLoai
{
    public int MaTheLoai { get; set; }

    public string? TenTheLoai { get; set; }

    public virtual ICollection<TPhim> TPhims { get; set; } = new List<TPhim>();
}
