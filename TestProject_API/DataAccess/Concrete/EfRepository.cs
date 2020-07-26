using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject_API.DataAccess.Context;
using TestProject_API.Models.Abstract;
using TestProject_API.Models.Concrete;
using TestProject_API.Repository.Abstract;

namespace TestProject_API.DataAccess.Concrete
{
    public class EfRepository : IRepository
    {
        private readonly BookStoreDbContext _context;

        public EfRepository(BookStoreDbContext context)
        {
            _context = context;
        }

        public void Create(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException();
            }

            _context.Books.Add(book);
        }

        public void Delete(Book book)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntity> Get()
        {
            var entities = _context.Books.ToList();
            return entities;
        }

        public IEntity GetById(int id)
        {
            var entity = _context.Books.FirstOrDefault(ent => ent.Id == id);
            return entity;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void Update(IEntity book)
        {
            // NOTHING
        }
    }
}
