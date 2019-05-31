namespace LibraryExample.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        public int Id { get; set; }

        [Column("Books.Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Books_Id { get; set; }

        [Column("Clients.Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clients_Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Column("Loans.Id")]
        public int? Loans_Id { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Book Book { get; set; }

        public virtual Client Client { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
