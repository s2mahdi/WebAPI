using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Assets
{
    /// <summary>
    /// قسمت های تحت پایش
    /// </summary>
    public class Part : BaseEntity
    {
        public string PartName { get; set; }
        public int PartKind { get; set; }
        public bool IsActive { get; set; }
    }
    public class PartConfiguration : IEntityTypeConfiguration<Part>
    {
        public void Configure(EntityTypeBuilder<Part> builder)
        {
            builder.Property(c => c.PartName)
                .HasMaxLength(100).IsRequired();
        }
    }
}




















