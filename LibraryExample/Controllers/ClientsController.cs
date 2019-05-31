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
        public ClientDTO Get(int id)
        {
            ClientDTO output;
            using (var db = new LibraryExampleEntities())
            {
                var client = db.Clients.FirstOrDefault(x => x.Id == id);
                output = Mapper.Map<ClientDTO>(client);
            }
            return output;
        }

        // POST api/values 
        public void Post([FromBody]ClientDTO value)
        {
            value.AccountCreationDate = DateTime.UtcNow;

            //foreach(var book in value.Clients) { book.Autor = value; }
            var insert = Mapper.Map<Client>(value);
            using (var db = new LibraryExampleEntities())
            {
                db.Clients.Add(insert);
                db.SaveChanges();
            }
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]ClientDTO value)
        {
            var insert = Mapper.Map<Client>(value);
            using (var db = new LibraryExampleEntities())
            {
                var toChange = db.Clients.FirstOrDefault(x => x.Id == id);
                toChange.Name = value.Name;
                toChange.Surname = value.Surname;
                toChange.PhoneNumber = value.PhoneNumber;
                db.SaveChanges();
            }
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
            using (var db = new LibraryExampleEntities())
            {
                var toChange = db.Clients.Remove(db.Clients.FirstOrDefault(x => x.Id == id));
                db.SaveChanges();
            }
        }
    }
}
