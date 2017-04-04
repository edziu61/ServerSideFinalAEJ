using ServerSideFinalAEJ.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace ContosoUniversity.DAL
{
    public class BusContext : DbContext
    {
        public BusContext() : base("SchoolContext")
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