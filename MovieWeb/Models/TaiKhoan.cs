using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Models;

public partial class TaiKhoan
{
    public int MaTaiKhoan { get; set; }

    public string? TenTaiKhoan { get; set; }

    [Required(ErrorMessage = "Mật khẩu không để trống")]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$",
        ErrorMessage = "mat khau phai co it nhat 1 chu thuong ,chu hoa,chu so va do dai tren 7 ki tu")]
    public string? PassWord { get; set; }

    public string? Email { get; set; }

    public string? SoDt { get; set; }

    public string? Anh { get; set; }

    public DateTime? DateUpdate { get; set; }

    public int? PhanQuyen { get; set; }

    public int? IsDeleted { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<DanhGiaChung> DanhGiaChungs { get; set; } = new List<DanhGiaChung>();

    public virtual ICollection<ThoiLuongDaXem> ThoiLuongDaXems { get; set; } = new List<ThoiLuongDaXem>();
}
