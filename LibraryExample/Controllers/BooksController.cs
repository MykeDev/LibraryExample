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
using System.Net;
using System.Net.Http;

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
        public IHttpActionResult Get(int id)
        {
            BookDTO output;
            using (var db = new LibraryExampleEntities())
            {
                var book = db.Books.FirstOrDefault(x => x.Id == id);
                if (book is null)
                    return NotFound();
                output = Mapper.Map<BookDTO>(book);
            }
            return Ok(output);
        }

        // POST api/values 
        public IHttpActionResult Post([FromBody]BookDTO value)
        {
            var insert = Mapper.Map<Book>(value);
            using (var db = new LibraryExampleEntities())
            {
                db.Books.Add(insert);
                db.SaveChanges();
            }
            return Created(new Uri(Request.RequestUri.AbsoluteUri), insert.Id);
        }

        // PUT api/values/5 
        public IHttpActionResult Put(int id, [FromBody]BookDTO value)
        {
            var insert = Mapper.Map<Book>(value);
            using (var db = new LibraryExampleEntities())
            {
                var toChange = db.Books.FirstOrDefault(x => x.Id == id);

                if (toChange is null)
                    return NotFound();

                toChange.Title = value.Title;
                toChange.Year = value.Year;
                toChange.Autors_Id = value.Autors_Id;
                db.SaveChanges();
            }
            return Ok(insert);
        }

        // DELETE api/values/5 
        public IHttpActionResult Delete(int id)
        {
            using (var db = new LibraryExampleEntities())
            {
                var toDelete = db.Books.FirstOrDefault(x => x.Id == id);
                if (toDelete is null)
                    return NotFound();

                var toChange = db.Books.Remove(toDelete);
                db.SaveChanges();
            }
            return ResponseMessage(new HttpResponseMessage(HttpStatusCode.NoContent));
        }
    }
}
