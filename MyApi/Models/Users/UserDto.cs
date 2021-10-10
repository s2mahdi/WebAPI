using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebFramework.Api;

namespace MyApi.Models
{
    public class UserProfileDto : BaseDto<UserProfileDto, User>, IValidatableObject
    {
        [Required]
        [StringLength(100)]
        public string Email { get; set; }



        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Education { get; set; }
        [Required]
        [StringLength(100)]
        public string Position { get; set; }
        [Required]
        [StringLength(100)]
        public string UnitName { get; set; }
        [Required]
        [StringLength(500)]
        public string Address { get; set; }
        [Required]
        public string FCustomeName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
    public class UserDto : BaseDto<UserDto, User>, IValidatableObject
    {
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        

        public DateTime BirthDate { get; set; }

        public GenderType Gender { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (UserName.Equals("test", StringComparison.OrdinalIgnoreCase))
                yield return new ValidationResult("نام کاربری نمیتواند Test باشد", new[] { nameof(UserName) });
            if (Password.Equals("123456"))
                yield return new ValidationResult("رمز عبور نمیتواند 123456 باشد", new[] { nameof(Password) });
            if (Gender == GenderType.Male && (DateTime.Now-BirthDate).TotalDays > 30*365)
                yield return new ValidationResult("آقایان بیشتر از 30 سال معتبر نیستند", new[] { nameof(Gender), nameof(BirthDate) });
        }
    }
}
