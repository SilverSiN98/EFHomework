using System.Data.Entity;
using EFHomework.Configurations;
using EFHomework.Models;

namespace EFHomework.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Volume> Volumes { get; set; }
        public DbSet<Chapter> Chapters { get; set; }

        static ApplicationContext()
        {
            Database.SetInitializer(new ApplicationContextInitializer());
        }

        public ApplicationContext() : base("DbConnection")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VolumeConfiguration());
            modelBuilder.Configurations.Add(new ChapterConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
