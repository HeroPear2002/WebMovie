using MovieWeb.Models;
namespace MovieWeb.Repository
{
    public class PhimRepository : IPhimRepository
    {
        private readonly MovieDbContext _context;
        public PhimRepository(MovieDbContext context)
        {
            _context = context;
        }
        public TPhim Add(TPhim phim)
        {
            _context.TPhims.Add(phim);
            _context.SaveChanges();
            return phim;
        }

        public TPhim Update(TPhim phim)
        {
            _context.TPhims.Update(phim);
            _context.SaveChanges();
            return phim;
        }

        public TPhim Delete(string maPhim)
        {
            throw new NotImplementedException();
        }

        public TPhim GeTPhim(string maPhim)
        {
            return _context.TPhims.Find(maPhim);
        }
        public TPhim GetTPhim(string maPhim)
        {
            return _context.TPhims.Find(maPhim);
        }
        public IEnumerable<TPhim> GetAllTPhim()
        {
            return _context.TPhims;
        }
    }
}
