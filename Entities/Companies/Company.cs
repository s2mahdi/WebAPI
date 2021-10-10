using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Entities.Companies
{
    public class Company : BaseEntity
    {
        public string FCustomeName { get; set; }
        public string NationalId { get; set; }
        public string EconomicCode { get; set; }
        public string RegistrationCode { get; set; }
        public string TellNumber { get; set; }
        public string FaxNumber { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string PersonId { get; set; }
        public ICollection<User> Users { get; set; }

    }

    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(p => p.FCustomeName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.NationalId).IsRequired().HasMaxLength(20);
            builder.Property(p => p.EconomicCode).IsRequired().HasMaxLength(20);
            builder.Property(p => p.RegistrationCode).IsRequired().HasMaxLength(20);
            builder.Property(p => p.TellNumber).IsRequired().HasMaxLength(30);
            builder.Property(p => p.FaxNumber).IsRequired().HasMaxLength(30);
            builder.Property(p => p.ZipCode).IsRequired().HasMaxLength(30);
            builder.Property(p => p.Address).IsRequired().HasMaxLength(100);
            builder.Property(p => p.PersonId).IsRequired().HasMaxLength(100);
            builder.HasMany(p => p.Users).WithOne(c=>c.Company)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

}
