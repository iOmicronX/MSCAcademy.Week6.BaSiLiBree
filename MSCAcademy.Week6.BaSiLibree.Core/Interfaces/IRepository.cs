using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> Fetch();
        T OttieniDaId(Guid id);
        void Crea(T nuovoOggetto);
        void Aggiorna(T aggiornaOggetto);
        void CancellaDaId(Guid id);

    }
}
