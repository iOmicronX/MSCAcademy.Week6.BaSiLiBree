using MSCAcademy.Week6.BaSiLibree.Core.Entities;
using MSCAcademy.Week6.BaSiLibree.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.BusinessLogic
{
    public class BusinessReportisticaRitardatari : //IBusinessReportisticaRitardatari
    {
        private IRepository<Iscritto> dataAccess;
        public BusinessReportisticaRitardatari(IRepository<Iscritto> dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        /*public List<Iscritto> ElencoRitardatari()
        {
            this.dataAccess.
        }*/
    }
}
