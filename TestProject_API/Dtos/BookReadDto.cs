using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject_API.Dtos
{
    public class BookReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }


        // We don't expose that property to the client.
        public string TotalPageNumber { get; set; }
    }
}
