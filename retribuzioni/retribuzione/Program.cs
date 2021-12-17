using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retribuzione
{
    class Dipendente
    {
        int matricola;
        string nome;
        string cognome;
        double retribuzione;
        public Dipendente(int matricola, string nome, string cognome, double retribuzione)
        {
            this.matricola = matricola;
            this.nome = nome;
            this.cognome = cognome;
            this.retribuzione = retribuzione;
        }
        public virtual double calcolaRetribuzione(double retribuzione)
        {
            return retribuzione;
        }
        public void mostraRetribuzione()
        {
            Console.WriteLine(retribuzione);
        }
    }
    class Operaio : Dipendente
    {

        public Operaio(int matricola, string nome, string cognome, double retribuzione) : base(matricola, nome, cognome, retribuzione)
        {

        }
        public override double calcolaRetribuzione(double retribuzione)
        {
            retribuzione = 35;
            return retribuzione;
        }
    }
    class Impiegato : Dipendente
    {

        public Impiegato(int matricola, string nome, string cognome, double retribuzione) : base(matricola, nome, cognome, retribuzione)
        {

        }
        public override double calcolaRetribuzione(double retribuzione)
        {
            retribuzione = 35 + (35 * 0.3);
            return retribuzione;
        }
    }
    class Dirigente : Dipendente
    {

        public Dirigente(int matricola, string nome, string cognome, double retribuzione) : base(matricola, nome, cognome, retribuzione)
        {

        }
        public override double calcolaRetribuzione(double retribuzione)
        {
            retribuzione = 35 + (35 * 0.5);
            return retribuzione;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci 1 per aggiungere un operaio, 2 per un impiegato o 3 per un dirigente");
            string risposta = Console.ReadLine();
            switch (risposta)
            {
                case "1": creaOperaio(); break;
            }
        }
        static void creaOperaio()
        {
            Console.WriteLine("Inserisci la matricola: ");
            int matricola = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome: ");
            string cognome = Console.ReadLine();
        }
    }
}
