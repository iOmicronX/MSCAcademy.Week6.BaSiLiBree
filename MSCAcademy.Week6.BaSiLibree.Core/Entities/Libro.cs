using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.Entities
{
    public class Libro
    {
        public Guid Id { get; }
        public string ISBN { get; }
        public string Titolo { get; }
        public string Autore { get; }
        DateOnly Data { get; set; }

        public Libro(string isbn, string titolo, string autore, DateOnly data)
        {
            Id= Guid.NewGuid();
            ISBN= isbn;
            Titolo= titolo;
            Autore= autore;
            Data = data;
        }


    }
}
