﻿using Microsoft.Extensions.DependencyInjection;
using MSCAcademy.Week6.BaSiLibree.Core.BusinessLogic;
using MSCAcademy.Week6.BaSiLibree.Core.DataAccess;
using MSCAcademy.Week6.BaSiLibree.Core.Entities;
using MSCAcademy.Week6.BaSiLibree.Core.Interfaces;
using System.Net.Sockets;
using System.Security.Authentication.ExtendedProtection;

namespace MSCAcademy.Week6.BaSiLiBree.UI

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IMainBusinessLogic, MainBusinessLayer>()
                .AddTransient<IRepository<Iscritto>, MockIscrittoRepository>()
                .AddTransient<IRepository<Libro>, DataAccessCatalogoLibri>()
                .AddTransient<IRepository<Prestito>, MockPrestitoRepository>()
                .BuildServiceProvider();

            IMainBusinessLogic mainBL = serviceProvider.GetService<IMainBusinessLogic>();

            
            var iscritto1 = new Iscritto(Guid.NewGuid(), "Andrea", "Vacca", new DateOnly(1995, 07, 29), new DateOnly(2023, 01, 29));
            mainBL.CreaIscr(iscritto1);
            Console.WriteLine("***Benvenuto nel sistema di gestione della tua biblioteca***");
            Console.WriteLine("Seleziona la funzionalità desiderata");
            byte selezione = 0;
            do
            {
                
                Menu();
                selezione = byte.Parse(Console.ReadLine());
                //switch
                switch (selezione)
                {
                    case 1: 
                        var iscritto2 = new Iscritto(Guid.NewGuid(), "Darius", "Tirla", new DateOnly(1999, 07, 29), new DateOnly(2022, 01, 29));
                        mainBL.CreaIscr(iscritto2);
                        break;
                    case 2:
                        var libro1 = new Libro("vcugyua", "Sos", "Melacta", new DateOnly);


                }
            } while (selezione != 9);
        }

        public static void Menu()
        {
            Console.WriteLine("Seleziona la funzionalità desiderata");
            Console.WriteLine("1) Inserire un nuovo utente nel sistema");
            Console.WriteLine("2) Inserire un nuovo libro nel sistema");
            Console.WriteLine("3) Inserire un nuovo prestito nel sistema");
            Console.WriteLine("4) Sostituire un libro con uno nuovo");
            Console.WriteLine("5) Eliminare un libro");
            Console.WriteLine("6) Eliminare un utente");
            Console.WriteLine("7) Stampa elenco ritardatari");
            Console.WriteLine("8) Stampa elenco inattivi");
            Console.WriteLine("9) Exit");
        }
    }
}