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
                cfg.CreateMap<Autor, AutorDTO>();
                cfg.CreateMap<Book, BookDTO>().ForMember(dest => dest.Autor, opt => opt.Condition(src => !(src.Autor is null)));
                });
        }
    }
}
