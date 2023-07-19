using Allup.DataAccessLayer.Entity;

namespace Allup.ViewModels
{
    public class ContactViewModel
    {
        public List<Contact> Contacts { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Banner> Banners { get; set; }
    }
}
