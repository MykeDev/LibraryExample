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
    public class ClientsController : ApiController
    {
        // GET api/values 
        public IEnumerable<ClientDTO> Get()
        {
            List<ClientDTO> output = new List<ClientDTO>();
            using (var db = new LibraryExampleEntities())
            {
                var clients = db.Clients.Where(x => true).ToList();
                output = Mapper.Map<List<Client>, List<ClientDTO>>(clients);
            }
            return output;
        }

        // GET api/values/5 
        public IHttpActionResult Get(int id)
        {
            ClientDTO output;
            using (var db = new LibraryExampleEntities())
            {
                var client = db.Clients.FirstOrDefault(x => x.Id == id);
                if (client is null)
                    return NotFound();
                output = Mapper.Map<ClientDTO>(client);
            }
            return Ok(output);
        }

        // POST api/values 
        public IHttpActionResult Post([FromBody]ClientDTO value)
        {
            value.AccountCreationDate = DateTime.UtcNow;

            var insert = Mapper.Map<Client>(value);
            using (var db = new LibraryExampleEntities())
            {
                db.Clients.Add(insert);
                db.SaveChanges();
            }

            return Created(new Uri(Request.RequestUri.AbsoluteUri), insert.Id);
        }

        // PUT api/values/5 
        public IHttpActionResult Put(int id, [FromBody]ClientDTO value)
        {
            var insert = Mapper.Map<Client>(value);
            using (var db = new LibraryExampleEntities())
            {
                var toChange = db.Clients.FirstOrDefault(x => x.Id == id);

                if (toChange is null)
                    return NotFound();

                toChange.Name = value.Name;
                toChange.Surname = value.Surname;
                toChange.PhoneNumber = value.PhoneNumber;
                db.SaveChanges();
            }
            return Ok(insert);
        }

        // DELETE api/values/5 
        public IHttpActionResult Delete(int id)
        {
            using (var db = new LibraryExampleEntities())
            {
                var toDelete = db.Clients.FirstOrDefault(x => x.Id == id);
                if (toDelete is null)
                    return NotFound();

                var toChange = db.Clients.Remove(toDelete);
                db.SaveChanges();
            }
            return ResponseMessage(new HttpResponseMessage(HttpStatusCode.NoContent));
        }
    }
}
