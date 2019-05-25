using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Data.Entity;
using LibraryExample.DB;

namespace LibraryExample.Controllers
{
    public class BooksController : ApiController
    {
        // GET api/values 
        public IEnumerable<Book> Get()
        {
            List<Book> output = new List<Book>();
            using (var db = new LibraryExampleEntities())
            {
                output = db.Books.Include(b => b.Autor).ToList();
            }
            return output;
        }

        // GET api/values/5 
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}
