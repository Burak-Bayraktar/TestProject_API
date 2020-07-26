using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject_API.Dtos
{
    public class BookUpdateDto
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Author { get; set; }

        [Required]
        [MaxLength(150)]
        public string Publisher { get; set; }

        [Required]
        public string TotalPageNumber { get; set; }
    }
}
