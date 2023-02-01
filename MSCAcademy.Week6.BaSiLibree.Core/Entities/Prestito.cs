using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.Entities
{
    public class Prestito
    {
        public Prestito(Guid id, Iscritto iscritto, Libro libro, DateTime dataInizio, DateTime dataFine)
        {
            Id = id;
            _Iscritto = iscritto;
            _Libro = libro;
            DataInizio = dataInizio;
            DataFine = dataFine;
        }

        public Guid Id { get; set; }
        public Iscritto _Iscritto { get; set; }
        public Libro _Libro { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
    }
}
