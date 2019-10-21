using EFHomework.Models;
using System.Data.Entity.ModelConfiguration;

namespace EFHomework.Configurations
{
    public class VolumeConfiguration : EntityTypeConfiguration<Volume>
    {
        public VolumeConfiguration()
        {
            // One-to-many relationship
            HasMany(p => p.Chapters).WithRequired(p => p.Volume).HasForeignKey(p => p.VolumeId);

            // Primary key
            HasKey(p => p.Id);

            Property(p => p.SerialNumber).IsRequired();
            Property(p => p.Name).HasMaxLength(50).IsRequired().HasColumnName("Title");
        }
    }
}
