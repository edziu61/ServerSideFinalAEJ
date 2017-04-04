using ServerSideFinalAEJ.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace ServerSideFinalAEJ.DAL
{
    public class BusContext : DbContext
    {
        public BusContext() : base("BusContext")
        {
        }
        public DbSet<Order> Orders { get; set; }
        //need DbSet for other classes
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}