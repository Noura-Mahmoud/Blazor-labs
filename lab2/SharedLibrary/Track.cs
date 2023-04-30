using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class Track
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage = "Too long Name!!")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(250, ErrorMessage = "Too long Description!!")]
        public string Description { get; set; }= string.Empty;
    }
}
