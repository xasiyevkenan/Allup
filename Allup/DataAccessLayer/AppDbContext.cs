using Allup.DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace Allup.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<MyAccount> MyAccounts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Header> Header { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
