using MSCAcademy.Week6.BaSiLibree.Core.Entities;
using MSCAcademy.Week6.BaSiLibree.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.DataAccess
{

    public class MockPrestitoRepository : IRepository<Prestito>
    {
        private static readonly List<Prestito> _prestiti = new List<Prestito>();
        public void Aggiorna(Prestito aggiornaOggetto)
        {
            var prestito = OttieniDaId(aggiornaOggetto.Id);
            if (prestito == null)
            {
                throw new NullReferenceException("Iscritto non trovato");
            }
            else
            {

                CancellaDaId(prestito.Id);
                Crea(aggiornaOggetto);
            }
        }

        public void CancellaDaId(Guid id)
        {
            //Guardia
            if (id == Guid.Empty)
                throw new ArgumentNullException("Id non trovato");
            _prestiti.Remove(OttieniDaId(id));
        }

        public void Crea(Prestito nuovoOggetto)
        {
            _prestiti.Add(nuovoOggetto);
        }

        public IEnumerable<Prestito> Fetch()
        {
            return _prestiti;
        }

        public Prestito OttieniDaId(Guid id)
        {
            //Guardia
            if (id == Guid.Empty)
                throw new ArgumentNullException("Id non trovato");
            var found = _prestiti.FirstOrDefault(t => t.Id == id);
            if (found == null)
            {
                throw new ArgumentNullException("Prestito null");
            }
            else
                return found;
        }
    }
}
