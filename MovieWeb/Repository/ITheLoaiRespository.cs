using MovieWeb.Models;

namespace MovieWeb.Repository
{
	public interface ITheLoaiRespository
	{
		TheLoai Add(TheLoai theLoai);
		TheLoai Update(TheLoai theLoai);
		TheLoai Delete(String maTheLoai);
		TheLoai GetLoaiSp(String maTheLoai);
		IEnumerable<TheLoai> GetAllTheLoai();
	}
}
