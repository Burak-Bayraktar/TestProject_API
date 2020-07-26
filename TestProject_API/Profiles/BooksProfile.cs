using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject_API.Dtos;
using TestProject_API.Models.Concrete;

namespace TestProject_API.Profiles
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            //Booktan bilgi gelecek BookReadDto'ya atayacağız. Çünkü kullanıcıya BookReadDto'yu göstermek istiyoruz.
            CreateMap<Book, BookReadDto>();

            // BookCreateDto'dan bilgi gelecek, Book'a atacağız. Çünkü veri tabanımız Book nesnesi ve oraya bilgi aktarmak zorundayız.
            CreateMap<BookCreateDto, Book>();

            // BookUpdateDto'dan bilgi gelecek, Book'a atacağız. Çünkü veri tabanımız Book nesnesi ve oraya bilgi aktarmak zorundayız.
            CreateMap<BookUpdateDto, Book>();
        }
    }

}
