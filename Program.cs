using System;

namespace cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("==== Bem vindo ao Cronometro ====");
            Console.WriteLine("");
            Console.WriteLine("____________Instruções___________");
            Console.WriteLine("M = Minuto -> 1m = 1 Minuto");
            Console.WriteLine("S = Segundo -> 10s = 10 Segundos");
            Console.WriteLine("*********************************");
            Console.WriteLine("0 - Para sair da aplicação");
            Console.WriteLine("INSIRA O TEMPO DESEJADO: ");
            Console.WriteLine("*********************************");
            Console.WriteLine("");

            string data = Console.ReadLine().ToLower();
            char tipo = char.Parse(data.Substring(data.Length - 1, 1));
            int tempo = int.Parse(data.Substring(0, data.Length - 1));
            int multiplicador = 1;

            if (tipo == 'm')
                multiplicador = 60;

            if (tempo == 0)
                System.Environment.Exit(0);

            Aquecimento(tempo * multiplicador);
        }

        static void Aquecimento(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Prepara");
            Thread.Sleep(1000);
            Console.WriteLine("Começou");
            Thread.Sleep(1000);

            Inicio(tempo);
        }

        static void Inicio(int tempo)
        {
            int contador = 0;

            while (contador != tempo)
            {
                Console.Clear();
                contador++;
                Console.WriteLine(contador);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronometro Finalizado");
            Thread.Sleep(1000);
            Menu();
        }
    }
}