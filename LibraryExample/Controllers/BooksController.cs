using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Data.Entity;
using LibraryExample.DB;
using LibraryExample.DTOs;
using AutoMapper;

namespace LibraryExample.Controllers
{
    public class BooksController : ApiController
    {
        // GET api/values 
        public IEnumerable<BookDTO> Get()
        {
            List<BookDTO> output = new List<BookDTO>();
            using (var db = new LibraryExampleEntities())
            {
                var books = db.Books.Where(x => true).ToList();
                output = Mapper.Map<List<Book>, List<BookDTO>>(books);
            }
            return output;
        }

        // GET api/values/5 
        public BookDTO Get(int id)
        {
            BookDTO output;
            using (var db = new LibraryExampleEntities())
            {
                var book = db.Books.FirstOrDefault(x => x.Id == id);
                output = Mapper.Map<BookDTO>(book);
            }
            return output;
        }

        // POST api/values 
        public IHttpActionResult Post([FromBody]BookDTO value)
        {
            //foreach(var book in value.Books) { book.Autor = value; }
            var insert = Mapper.Map<Book>(value);
            using (var db = new LibraryExampleEntities())
            {
                db.Books.Add(insert);
                db.SaveChanges();
            }
            return Ok(insert.Id);
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]BookDTO value)
        {
            var insert = Mapper.Map<Book>(value);
            using (var db = new LibraryExampleEntities())
            {
                var toChange = db.Books.FirstOrDefault(x => x.Id == id);
                toChange.Title = value.Title;
                toChange.Year = value.Year;
                toChange.Autors_Id = value.Autors_Id;
                db.SaveChanges();
            }
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
            using (var db = new LibraryExampleEntities())
            {
                var toChange = db.Books.Remove(db.Books.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
            }
        }
    }
}
