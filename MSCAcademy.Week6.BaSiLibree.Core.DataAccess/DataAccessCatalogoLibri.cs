using MSCAcademy.Week6.BaSiLibree.Core.Entities;
using MSCAcademy.Week6.BaSiLibree.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.DataAccess
{
    public class DataAccessCatalogoLibri : IRepository<Libro>
    {
        private static List<Libro> catalogoLibri;
        public DataAccessCatalogoLibri()
        {
            catalogoLibri = new List<Libro>();
        }
        public void Aggiorna(Libro aggiornaOggetto)
        {
            var libro = OttieniDaId(aggiornaOggetto.Id);
            if (libro == null)
            {
                throw new NullReferenceException("Libro non trovato");
            } else
            {

            CancellaDaId(libro.Id);
            Crea(aggiornaOggetto);
            }
        }

        public void CancellaDaId(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Id vuoto");
            }
            var libro = catalogoLibri.FirstOrDefault(x => x.Id == id);
            if (libro == null)
            {
                throw new Exception("Libro non trovato");
            }
            else
                catalogoLibri.Remove(libro);
        }

        public void Crea(Libro nuovoOggetto)
        {
            catalogoLibri.Add(nuovoOggetto);
        }

        public Libro OttieniDaId(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Id vuoto");
            }
            var libro = catalogoLibri.FirstOrDefault(x => x.Id == id);
            if (libro == null)
            {
                throw new Exception("Libro non trovato");
            }
            else
                return libro;
        }
    }
}
