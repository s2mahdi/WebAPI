using Entities.Companies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{

    public class User : IdentityUser<int>, IEntity<int>
    {
        public User()
        {
            IsActive = true;
        }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Education { get; set; }
        public string Position { get; set; }
        public string UnitName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string CustomeId { get; set; }
        public string FCustomeName { get; set; }

        public DateTime? BirthDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int Age => BirthDate==null?0: DateTime.Now.Year - BirthDate.Value.Year;
        public GenderType Gender { get; set; }
        public bool IsActive { get; set; }
        public bool IsProfileCompleted { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }

        public Guid EmailVerifyer { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<Post> Posts { get; set; }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.UserName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.FirstName).IsRequired(false).HasMaxLength(50);
            builder.Property(p => p.LastName).HasMaxLength(50);
            builder.Property(p => p.Education).HasMaxLength(100);
            builder.Property(p => p.Position).HasMaxLength(100);
            builder.Property(p => p.UnitName).HasMaxLength(100);
            builder.Property(p => p.Address).HasMaxLength(500);
            builder.Ignore(c => c.Age);
        }
    }

    public enum GenderType
    {
        [Display(Name = "نامشخص")]
        Unknown = 0,
        [Display(Name = "مرد")]
        Male = 1,

        [Display(Name = "زن")]
        Female = 2
    }
}
