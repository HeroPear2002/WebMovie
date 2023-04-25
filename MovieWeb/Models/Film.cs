namespace MovieWeb.Models
{
    public class Film
    {
        public int maphim;
        public string tenphim;
        public string quocgia;
        public int luotxem;
        public string image;

        public Film(int maphim, string tenphim, string quocgia, string image, int luotxem)
        {
            this.maphim = maphim;
            this.tenphim = tenphim;
            this.quocgia = quocgia;
            this.luotxem = luotxem;
            this.image = image;
        }
    }
}
