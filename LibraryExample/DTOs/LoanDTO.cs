using System;
using System.Collections.Generic;

namespace LibraryExample.DTOs
{
    public class LoanDTO
    {
        public int Id { get; set; }
        public System.DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Books_Id { get; set; }
        public int Clients_Id { get; set; }
        public bool IsDeleted { get; set; } = false;

        public BookDTO Book { get; set; }
        public ClientDTO Client { get; set; }
        public ICollection<ReservationDTO> Reservations { get; set; }
    }
}