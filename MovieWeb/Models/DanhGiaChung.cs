using System.ComponentModel.DataAnnotations.Schema;

namespace MovieWeb.Models;

public partial class DanhGiaChung
{
    [NotMapped]
    public int MaTaiKhoan { get; set; }
    [NotMapped]
    public int MaPhim { get; set; }

    public int? DanhGia { get; set; }

    public virtual TPhim MaPhimNavigation { get; set; } = null!;

    public virtual TaiKhoan MaTaiKhoanNavigation { get; set; } = null!;
}
