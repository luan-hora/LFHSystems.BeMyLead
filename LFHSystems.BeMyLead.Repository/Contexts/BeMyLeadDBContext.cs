using LFHSystems.BeMyLead.Model;
using Microsoft.EntityFrameworkCore;

namespace LFHSystems.BeMyLead.Repository.Contexts
{
    public class BeMyLeadDBContext : DbContext
    {
        public DbSet<LeadModel> Lead { get; set; }
        public DbSet<LanguageModel> Language { get; set; }
        public BeMyLeadDBContext(DbContextOptions<BeMyLeadDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<LeadModel>(e =>
            {
                e.ToTable("Tb_Lead").HasKey(k => k.ID);
                e.Property(p => p.ID).ValueGeneratedOnAdd();
            });
        }
    }
}
