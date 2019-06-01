using AutoMapper;
using LibraryExample.DB;
using LibraryExample.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    class AutomaperInitializer
    {
        public static void Init()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Autor, AutorDTO>().MaxDepth(1);
                cfg.CreateMap<Book, BookDTO>().MaxDepth(1);
                cfg.CreateMap<Client, ClientDTO>().MaxDepth(1);
                cfg.CreateMap<Loan, LoanDTO>().MaxDepth(1);
                cfg.CreateMap<Reservation, ReservationDTO>().MaxDepth(1);
                });
        }
    }
}
