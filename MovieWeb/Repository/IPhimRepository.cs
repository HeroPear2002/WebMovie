using MovieWeb.Models;

namespace MovieWeb.Repository
{
    public interface IPhimRepository
    {
        TPhim Add(TPhim phim);
        TPhim Update(TPhim phim);
        TPhim Delete(String maPhim);
        TPhim GeTPhim(String maPhim);
        IEnumerable<TPhim> GetAllTPhim();
    }
}
