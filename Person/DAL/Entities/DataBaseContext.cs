using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Services.Profile;
using Parcial2_NaturalPerson.DAL.Entities;

namespace Parcial2_NaturalPerson.DAL.Entities
{
    public class DataBaseContext :DbContext

    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options) : base(options)
        {
            
        }

        public DbSet<NaturalPerson> NaturalPerson { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelBuilder.Entity<NaturalPerson>().HasIndex(NaturalPerson => NaturalPerson.FullName).IsUniquue();

        }


    }
}
