﻿using MSCAcademy.Week6.BaSiLibree.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.Interfaces
{
    public interface IBusinessReportisticaInattivi
    {
        public List<Iscritto> ElencoInattivi(int n);

    }
}
