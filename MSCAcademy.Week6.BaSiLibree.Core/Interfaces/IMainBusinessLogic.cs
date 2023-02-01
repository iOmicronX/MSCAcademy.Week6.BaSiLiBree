using MSCAcademy.Week6.BaSiLibree.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.Interfaces
{
    public interface IMainBusinessLogic
    {
        public List<Iscritto> ElencoInattivi(int n);
        public List<Prestito> ElencoRitardatari();

        public Iscritto OttieniDaIdIscr(Guid id);
        public Libro OttieniDaIdLib(Guid id);
        public Prestito OttieniDaIdPres(Guid id);
        public void CreaIscr(Iscritto iscritto);
        public void CreaLib(Libro libro);
        public void CreaPres(Prestito prestito);
        public void AggiornaLib(Libro libro);
        public void AggiornaIscr(Iscritto iscritto);
        public void AggiornaPres(Prestito prestito);
        public void CancellaIdLib(Guid id);
        public void CancellaIdIscr(Guid id);
        public void CancellaIdPres(Guid id);

    }
}
