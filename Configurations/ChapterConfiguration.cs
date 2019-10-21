using EFHomework.Models;
using System.Data.Entity.ModelConfiguration;

namespace EFHomework.Configurations
{
    public class ChapterConfiguration : EntityTypeConfiguration<Chapter>
    {
        public ChapterConfiguration()
        {
            // Primary key
            HasKey(p => p.Id);

            Property(p => p.Name).HasMaxLength(50).HasColumnName("Title");
            Property(p => p.SerialNumber).IsRequired();
            Property(p => p.NumberOfPages).IsRequired();
            Property(p => p.VolumeId).IsRequired();
        }
    }
}
