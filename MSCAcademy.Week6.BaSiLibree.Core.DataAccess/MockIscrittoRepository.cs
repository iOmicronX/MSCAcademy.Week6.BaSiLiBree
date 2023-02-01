using MSCAcademy.Week6.BaSiLibree.Core.Entities;
using MSCAcademy.Week6.BaSiLibree.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.DataAccess
{
    public class MockIscrittoRepository : IRepository<Iscritto>
    {
        private static readonly List<Iscritto> _iscritti = new List<Iscritto>();
        public void Aggiorna(Iscritto aggiornaOggetto)
        {
            var iscritto = OttieniDaId(aggiornaOggetto.Id);
            if (iscritto == null)
            {
                throw new NullReferenceException("Iscritto non trovato");
            }
            else
            {

                CancellaDaId(iscritto.Id);
                Crea(aggiornaOggetto);
            }

        }

        public void CancellaDaId(Guid id)
        {
            //Guardia
            if (id == Guid.Empty)
                throw new ArgumentNullException("Id non trovato");
            _iscritti.Remove(OttieniDaId(id));
        }

        public void Crea(Iscritto nuovoOggetto)
        {
            _iscritti.Add(nuovoOggetto);
        }

        public IEnumerable<Iscritto> Fetch()
        {
            return _iscritti;
        }

        public Iscritto OttieniDaId(Guid id)
        {
            //Guardia
            if (id == Guid.Empty)
                throw new ArgumentNullException("Id non trovato");
            var found = _iscritti.FirstOrDefault(t => t.Id == id);
            if (found == null)
            {
                throw new ArgumentNullException("Libro null");
            }
            else
                return found;

        }
    }
}
