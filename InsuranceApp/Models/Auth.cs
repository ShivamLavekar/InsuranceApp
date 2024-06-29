using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class Auth
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }

    public class OtpLog
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Otp { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsUsed { get; set; }
    }
}
