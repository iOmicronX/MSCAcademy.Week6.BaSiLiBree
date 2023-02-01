using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.Entities
{
    public class Iscritto
    {
        public Iscritto(Guid id, string nome, string cognome, DateOnly dataDiNascita)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
        }

        public Guid Id { get; set; }
        public string Nome { get;  }
        public string Cognome { get;  }
        public DateOnly DataDiNascita { get; }


    }
}
