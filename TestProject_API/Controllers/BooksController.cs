using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProject_API.Dtos;
using TestProject_API.Models.Concrete;
using TestProject_API.Repository.Abstract;

namespace TestProject_API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public BooksController(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<IEnumerable<BookReadDto>> GetAll()
        {
            var model = _repository.Get();

            return Ok(_mapper.Map<IEnumerable<BookReadDto>>(model));
        }


        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<BookReadDto> GetById(int id)
        {
            var modelEntity = _repository.GetById(id);

            if (modelEntity!=null)
            {
                return Ok(_mapper.Map<BookReadDto>(modelEntity));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<BookCreateDto> CreateCommand(BookCreateDto bookCreateDto)
        {
            // We use Book model to map process as create a new source. The model called book supplies as all the property that we need to create a new source.
            Book modelEntity = _mapper.Map<Book>(bookCreateDto);
            _repository.Create(modelEntity);
            _repository.SaveChanges();

            // We need again mapping process to create a route for the "modelEntity" that we create just before. 
            // This time, we use "BookReadDto" to map process because we need only properties that we did supply to client.
            var bookReadDto = _mapper.Map<BookReadDto>(modelEntity);

            return CreatedAtRoute(nameof(GetById), new { Id = bookReadDto.Id }, bookReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, BookUpdateDto bookUpdateDto)
        {
            var commandModelFromRepo = _repository.GetById(id);
            if (commandModelFromRepo==null)
            {
                return NotFound();
            }

            _mapper.Map(bookUpdateDto, commandModelFromRepo);
            _repository.Update(commandModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}