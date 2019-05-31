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
    public class LoansController : ApiController
    {
        // GET api/values 
        public IEnumerable<LoanDTO> Get()
        {
            List<LoanDTO> output = new List<LoanDTO>();
            using (var db = new LibraryExampleEntities())
            {
                var clients = db.Loans.Where(x => true).ToList();
                output = Mapper.Map<List<Loan>, List<LoanDTO>>(clients);
            }
            return output;
        }

        // GET api/values/5 
        public LoanDTO Get(int id)
        {
            LoanDTO output;
            using (var db = new LibraryExampleEntities())
            {
                var client = db.Loans.FirstOrDefault(x => x.Id == id);
                output = Mapper.Map<LoanDTO>(client);
            }
            return output;
        }

        // POST api/values 
        public IHttpActionResult CreateNew([FromBody]LoanDTO value)
        {
            //foreach(var book in value.Loans) { book.Autor = value; }
            value.StartDate = DateTime.UtcNow;
            var insert = Mapper.Map<Loan>(value);
            using (var db = new LibraryExampleEntities())
            {
                db.Loans.Add(insert);
                db.SaveChanges();
            }
            return Ok(insert.Id);
        }

        // PUT api/values/5 
        [HttpGet]
        public IHttpActionResult CloseLoan([FromUri]int id)
        {
            using (var db = new LibraryExampleEntities())
            {
                var toChange = db.Loans.FirstOrDefault(x => x.Id == id);
                toChange.EndDate = DateTime.UtcNow;
                db.SaveChanges();
            }
            return Ok();
        }

        // DELETE api/values/5 
        public IHttpActionResult Delete(int id)
        {
            using (var db = new LibraryExampleEntities())
            {
                var toDelete = db.Loans.FirstOrDefault(x => x.Id == id);
                if (toDelete is null)
                    return BadRequest("Object doesn't exist");

                db.Loans.Remove(toDelete);
                db.SaveChanges();
            }
            return Ok();
        }
    }
}
