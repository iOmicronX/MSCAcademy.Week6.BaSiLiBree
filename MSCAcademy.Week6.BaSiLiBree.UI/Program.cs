namespace MSCAcademy.Week6.BaSiLiBree.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Benvenuto nel sistema di gestione della tua biblioteca***");
            Console.WriteLine("Seleziona la funzionalità desiderata");
            byte selezione = 0;
            do
            {
                Menu();
                selezione = byte.Parse(Console.ReadLine());
                //switch
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