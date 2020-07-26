using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestProject_API.Models.Abstract;

namespace TestProject_API.Models.Concrete
{
    public class Book : IEntity
    {
        [Key]
        public int Id { get; set; }

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
