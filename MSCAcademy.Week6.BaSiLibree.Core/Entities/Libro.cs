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
        DateOnly DataPubblicazione { get; set; }
        decimal Prezzo { get; set; }
        int AnnoRistampa { get; set; }
        int NumeroPagine { get; set; }

        public Libro(string isbn, string titolo, string autore, DateOnly dataPubb, decimal prezzo, int annoRis, int numeroPag)
        {
            Id = Guid.NewGuid();
            ISBN = isbn;
            Titolo = titolo;
            Autore = autore;
            DataPubblicazione = dataPubb;
            Prezzo = prezzo;
            AnnoRistampa = annoRis;
            NumeroPagine = numeroPag;
        }


    }
}
