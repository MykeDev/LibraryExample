using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample.DTOs
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? AccountCreationDate { get; set; }

        public ICollection<LoanDTO> Loans { get; set; }
        public ICollection<ReservationDTO> Reservations { get; set; }
    }
}
