using MSCAcademy.Week6.BaSiLibree.Core.Entities;
using MSCAcademy.Week6.BaSiLibree.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.BusinessLogic
{
    public class BusinessReportisticaInattivi : IBusinessReportisticaInattivi
    {
        private IRepository<Iscritto> _iscritti;

        public BusinessReportisticaInattivi(IRepository<Iscritto> iscritti)
        {
            _iscritti = iscritti;
        }
        public List<Iscritto> ElencoInattivi(int n)
        {
            var utenti = _iscritti.Fetch();
            var inattivi = utenti.Where(u => DateTime.Now.Month - u.DataUltimoAccesso.Month > n && DateTime.Now.Year != u.DataUltimoAccesso.Year);
            return (List<Iscritto>)inattivi;
        }
    }
}
