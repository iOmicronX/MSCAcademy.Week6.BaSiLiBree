using MSCAcademy.Week6.BaSiLibree.Core.Entities;
using MSCAcademy.Week6.BaSiLibree.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.BusinessLogic
{
    public class MainBusinessLayer : IMainBusinessLogic
    {
        private IRepository<Iscritto> repoIscritto;
        private IRepository<Libro> repoLibro;
        private IRepository<Prestito> repoPres;
        public MainBusinessLayer(IRepository<Iscritto> repoIscritto, IRepository<Libro> repoLibro, IRepository<Prestito> repoPres)
        {
            this.repoIscritto = repoIscritto;
            this.repoLibro = repoLibro;
            this.repoPres = repoPres;
        }

        public void AggiornaIscr(Iscritto iscritto)
        {
            repoIscritto.Aggiorna(iscritto);
        }

        public void AggiornaLib(Libro libro)
        {
            repoLibro.Aggiorna(libro);
        }

        public void AggiornaPres(Prestito prestito)
        {
            repoPres.Aggiorna(prestito);
        }

        public void CancellaIdIscr(Guid id)
        {
            repoIscritto.CancellaDaId(id);
        }

        public void CancellaIdLib(Guid id)
        {
            repoLibro.CancellaDaId(id);
        }

        public void CancellaIdPres(Guid id)
        {
            repoPres.CancellaDaId(id);
        }

        public void CreaIscr(Iscritto iscritto)
        {
            repoIscritto.Crea(iscritto);
        }

        public void CreaLib(Libro libro)
        {
            repoLibro.Crea(libro);
        }

        public void CreaPres(Prestito prestito)
        {
            repoPres.Crea(prestito);
        }

        public List<Iscritto> ElencoInattivi(int n)
        {
            var utenti = repoIscritto.Fetch();
            var inattivi = utenti.Where(u => DateTime.Now.Month - u.DataUltimoAccesso.Month > n && DateTime.Now.Year != u.DataUltimoAccesso.Year);
            return (List<Iscritto>)inattivi;
        }

        public List<Prestito> ElencoRitardatari()
        {
            var tuttiUtenti = repoPres.Fetch();
            var utentiRitardatari = tuttiUtenti.Where(x => x.DataFine < DateTime.Now);
            return (List<Prestito>)utentiRitardatari;
        }

        public IEnumerable<Iscritto> FetchAllIscritto()
        {
            return repoIscritto.Fetch();
        }

        public IEnumerable<Libro> FetchAllLibri()
        {
            return repoLibro.Fetch();
        }

        public IEnumerable<Prestito> FetchAllPrestito()
        {
            return repoPres.Fetch();
        }

        public Iscritto OttieniDaIdIscr(Guid id)
        {
            return repoIscritto.OttieniDaId(id);
        }

        public Libro OttieniDaIdLib(Guid id)
        {
            return repoLibro.OttieniDaId(id);
        }

        public Prestito OttieniDaIdPres(Guid id)
        {
            return repoPres.OttieniDaId(id);
        }
    }
}
