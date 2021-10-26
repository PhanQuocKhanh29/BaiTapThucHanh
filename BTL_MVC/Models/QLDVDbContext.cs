using System.Data.Entity;

namespace BTL_MVC.Models
{
    public partial class QLDVDbContext : DbContext

    {       
        public QLDVDbContext() : base("name=QLDVDbContext")
        {
        }
        public virtual DbSet<Person> People { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
            .Property(e => e.PersonID)
            .IsUnicode(false);
        }
    }

}