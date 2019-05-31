namespace LibraryExample.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Key]
        [Column("Books.Id", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Books_Id { get; set; }

        [Key]
        [Column("Clients.Id", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clients_Id { get; set; }

        [Column("Loans.Id")]
        public int? Loans_Id { get; set; }

        public virtual Book Book { get; set; }

        public virtual Client Client { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
