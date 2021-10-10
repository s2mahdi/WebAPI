using System.ComponentModel.DataAnnotations;

namespace MyApi.Models
{
    public class VerifyEmailDto 
    {
        public string Token { get; set; }
    }
    public class ConfirmEmailDto 
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
    public class SmsLoginDto 
    {
        [Required]
        [MaxLength(12)]
        public string MobileNumber { get; set; }
    }
    public class VerifySmsLoginDto
    {
        [Required]
        [MaxLength(11)]
        public string MobileNumber { get; set; }
        [Required]
        public long Code { get; set; }
    }
}
