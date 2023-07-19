using Allup.DataAccessLayer.Entity;

namespace Allup.ViewModels
{
    public class ShopViewModel
    {
        public List<Product> Products { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Banner> Banners { get; set; }
    }
}
