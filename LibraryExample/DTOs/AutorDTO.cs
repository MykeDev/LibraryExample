﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample.DTOs
{
    public class AutorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<BookDTO> Books { get; set; }
    }
}
