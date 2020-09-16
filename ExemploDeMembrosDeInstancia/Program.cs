using ExemploDeMembrosDeInstancia;
using System;
using System.Globalization;

namespace ExemploDeMembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine();
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CI));
            Console.WriteLine("Volume: " + volume.ToString("F2", CI));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CI));
        }
    }
}

/*Neste exemplo foi utilizado os membros de INSTÂNCIA com a crianção de uma nova
 CLASSE chamada Calculadora para realiza os cálculos separadamente do programa principal.
Utilizando depois membro estáticos para conseguir chamar os métodos diretamento pelo nome da classe
ao invés de instânciar um objeto para utiliza-lo em sua chamada*/