using AutoMapper;
using LibraryExample.DB;
using LibraryExample.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace LibraryExample.Controllers
{
    public class AutorsController : ApiController
    {
        // GET api/values 
        public IEnumerable<AutorDTO> Get()
        {
            List<AutorDTO> output = new List<AutorDTO>();
            using (var db = new LibraryExampleEntities())
            {
                var autors = db.Autors.Where(x => true).ToList();
                output = Mapper.Map<List<Autor>, List<AutorDTO>>(autors);
            }
            return output;
        }

        // GET api/values/5 
        public AutorDTO Get(int id)
        {
            AutorDTO output;
            using (var db = new LibraryExampleEntities())
            {
                var autor = db.Autors.FirstOrDefault(x => x.Id == id);
                output = Mapper.Map<AutorDTO>(autor);
            }
            return output;
        }

        // POST api/values 
        public IHttpActionResult Post([FromBody]AutorDTO value)
        {
            //foreach(var book in value.Books) { book.Autor = value; }
            var insert = Mapper.Map<Autor>(value);
            using (var db = new LibraryExampleEntities())
            {
                db.Autors.Add(insert);
                db.SaveChanges();
            }
            return Ok(insert.Id);
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]AutorDTO value)
        {
            var insert = Mapper.Map<Autor>(value);
            using (var db = new LibraryExampleEntities())
            {
                var toChange = db.Autors.FirstOrDefault(x => x.Id == id);
                toChange.Name = value.Name;
                toChange.Surname = value.Surname;
                toChange.Description = value.Description;
                db.SaveChanges();
            }
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
            using (var db = new LibraryExampleEntities())
            {
                var toChange = db.Autors.Remove(db.Autors.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
            }
        }
    }
}
