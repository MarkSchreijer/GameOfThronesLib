using GameOfThronesLib.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GameOfThronesLib.Models
{
    public class GoTLibContext : DbContext
    {
        public GoTLibContext() : base("GoTLib")
        {
        }

        public DbSet<Family> Families { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
