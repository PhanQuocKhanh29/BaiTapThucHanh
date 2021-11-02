using System.Data.Entity;

namespace BTL_MVC.Models
{
    public partial class QLDVDbContext : DbContext

    {       
        public QLDVDbContext() : base("name=QLDVDbContext")
        {
        }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
            .Property(e => e.PersonID)
            .IsUnicode(false);
            modelBuilder.Entity<SinhVien>()
            .Property(e => e.MaSV)
            .IsUnicode(false);
        }

    }

}