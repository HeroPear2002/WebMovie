using Microsoft.AspNetCore.Mvc;
using MovieWeb.Models;

namespace MovieWeb.Areas.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchAPIController : ControllerBase
    {
        MovieDbContext db = new MovieDbContext();
        [HttpGet]
        public List<TPhim> SearchMovie(int? page, string q)
        {
            int pageSize = 12;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstphim = db.TPhims.Where(x => x.TenPhim.Contains(q)).OrderBy(x => x.TenPhim);

            return lstphim.ToList();
        }
    }
}
