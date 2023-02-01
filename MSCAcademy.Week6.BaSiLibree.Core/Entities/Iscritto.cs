using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSCAcademy.Week6.BaSiLibree.Core.Entities
{
    public class Iscritto
    {
        public Iscritto(Guid id, string nome, string cognome, DateOnly dataDiNascita, DateOnly dataUltimoAccesso)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            DataUltimoAccesso = dataUltimoAccesso;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateOnly DataDiNascita { get; set; }
        public DateOnly DataUltimoAccesso { get; set; }


    }
}
