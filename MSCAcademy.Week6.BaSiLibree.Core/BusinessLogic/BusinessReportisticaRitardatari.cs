using MSCAcademy.Week6.BaSiLibree.Core.Entities;
using MSCAcademy.Week6.BaSiLibree.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.BusinessLogic
{
    public class BusinessReportisticaRitardatari : IBusinessReportisticaRitardatari
    {
        private IRepository<Prestito> dataAccess;
        public BusinessReportisticaRitardatari(IRepository<Prestito> dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public List<Prestito> ElencoRitardatari()
        {
            var tuttiUtenti=this.dataAccess.Fetch();
            var utentiRitardatari = tuttiUtenti.Where(x => x.DataFine < DateTime.Now);
            return (List<Prestito>)utentiRitardatari;
        }

        
    }
}
