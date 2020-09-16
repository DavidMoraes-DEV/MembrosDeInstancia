using System;
using System.Globalization;

namespace ExemploDeMembrosDeInstancia
{
    class Calculadora
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public static double Pi = 3.14; //Membro estárico

        public static double Circunferencia(double r) //Membro Estatico
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)  //Membro Estatico
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}