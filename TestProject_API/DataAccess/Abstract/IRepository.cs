using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject_API.Models.Abstract;
using TestProject_API.Models.Concrete;

namespace TestProject_API.Repository.Abstract
{
    public interface IRepository
    {
        IEnumerable<IEntity> Get();
        IEntity GetById(int id);
        void Create(Book book);
        void Update(IEntity book);
        void Delete(Book book);

        bool SaveChanges();
    }
}
