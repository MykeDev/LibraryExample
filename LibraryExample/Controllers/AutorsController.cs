using AutoMapper;
using LibraryExample.DB;
using LibraryExample.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public IHttpActionResult Get(int id)
        {
            AutorDTO output;
            using (var db = new LibraryExampleEntities())
            {
                var autor = db.Autors.FirstOrDefault(x => x.Id == id);
                if (autor is null)
                    return NotFound();

                output = Mapper.Map<AutorDTO>(autor);
            }
            return Ok(output);
        }

        // POST api/values 
        public IHttpActionResult Post([FromBody]AutorDTO value)
        {
            var insert = Mapper.Map<Autor>(value);
            using (var db = new LibraryExampleEntities())
            {
                db.Autors.Add(insert);
                db.SaveChanges();
            }
            return Created(Request.RequestUri.AbsoluteUri, insert.Id);
        }

        // PUT api/values/5 
        public IHttpActionResult Put(int id, [FromBody]AutorDTO value)
        {
            var insert = Mapper.Map<Autor>(value);
            using (var db = new LibraryExampleEntities())
            {
                var toChange = db.Autors.FirstOrDefault(x => x.Id == id);

                if (toChange is null)
                    return NotFound();

                toChange.Name = value.Name;
                toChange.Surname = value.Surname;
                toChange.Description = value.Description;
                db.SaveChanges();
            }
            return Ok(insert);
        }

        // DELETE api/values/5 
        public IHttpActionResult Delete(int id)
        {
            using (var db = new LibraryExampleEntities())
            {
                var toDelete = db.Autors.FirstOrDefault(x => x.Id == id);
                if (toDelete is null)
                    return NotFound();

                var toChange = db.Autors.Remove(toDelete);
                db.SaveChanges();
            }
            return ResponseMessage(new HttpResponseMessage(HttpStatusCode.NoContent));
        }
    }
}
