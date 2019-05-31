using System;

namespace LibraryExample.DTOs
{
    public class ReservationDTO
    {
        public int Id { get; set; }

        public int Books_Id { get; set; }

        public int Clients_Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Loans_Id { get; set; }

        public bool IsDeleted { get; set; } = false;

        public virtual BookDTO Book { get; set; }

        public virtual ClientDTO Client { get; set; }

        public virtual LoanDTO Loan { get; set; }
    }
}