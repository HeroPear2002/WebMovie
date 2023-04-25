using System;
using System.Collections.Generic;

namespace MovieWeb.Models;

public partial class TPhim
{
    public int MaPhim { get; set; }

    public string? TenPhim { get; set; }

    public int? MaTheLoai { get; set; }

    public string? Anh { get; set; }

    public DateTime? NgayKhoiChieu { get; set; }

    public int? MaTrangThai { get; set; }

    public string? MoTa { get; set; }

    public string? QuocGia { get; set; }

    public int? MaHinhThuc { get; set; }

    public int? GioiHanDoTuoi { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<DanhGiaChung> DanhGiaChungs { get; set; } = new List<DanhGiaChung>();

    public virtual ICollection<Episode> Episodes { get; set; } = new List<Episode>();

    public virtual HinhThuc? MaHinhThucNavigation { get; set; }

    public virtual TheLoai? MaTheLoaiNavigation { get; set; }

    public virtual TrangThai? MaTrangThaiNavigation { get; set; }
}
