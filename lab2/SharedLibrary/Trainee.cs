using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class Trainee
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Too long Name!!")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public Gender Gender { get; set; }

        [Required]
        [EmailAddress( ErrorMessage = "Check your email!!")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone(ErrorMessage = "Check your phone nubmer!!")]
        public string MobileNo { get; set; } = string.Empty;

        [Required]
        public DateTime Birthdate { get; set; }

        public bool IsGraduated { get; set; }
    }
}
