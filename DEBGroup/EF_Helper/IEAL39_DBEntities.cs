using System.Data.Entity;

namespace DEBGroup.EF
{
    public interface IEAL39_DBEntities
    {
        DbSet<Category> Category { get; set; }
        DbSet<CustomerInfo> CustomerInfo { get; set; }
        DbSet<Product> Product { get; set; }
        DbSet<Room> Room { get; set; }
        DbSet<SCPconnection> SCPconnection { get; set; }
        DbSet<Sector> Sector { get; set; }
    }
}