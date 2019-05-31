using System.Collections.Generic;

namespace LibraryExample.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public int Autors_Id { get; set; }
        public bool IsDeleted { get; set; } = false;

        public AutorDTO Autor { get; set; }

        public virtual ICollection<LoanDTO> Loans { get; set; }
        public virtual ICollection<ReservationDTO> Reservations { get; set; }

    }
}