using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMadeInChina
{
    class UserInterface
    {
        public static void PrintMainMenu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.DarkBlue;
            System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine(" Calculadora Made in China");
            System.Console.WriteLine("......................................");
            System.Console.ResetColor();
            System.Console.WriteLine("1) sunar una serie de números");
            System.Console.WriteLine("2) restar una serie de números");
            System.Console.WriteLine("3) multiplicar una serie de números");
            System.Console.WriteLine("4) Dividir una serie de números");
            System.Console.WriteLine("5) Realizar la reíz cuadrada de un número");
            System.Console.WriteLine("6) Inficar si un número es primo");
            System.Console.WriteLine("7) Realizar el sumatorio de una serie de números");
            System.Console.WriteLine("0) Salir de la aplicación");
        }
        public static void PrintAddHeader()
        {
            System.Console.WriteLine("Suma de números");
            System.Console.WriteLine(".......................");
        }

        public static void PrintAddSubMenu()
        {
            System.Console.WriteLine("0) Salir de la aplicación");
            System.Console.WriteLine("1) Sumar un nuevo número");
            System.Console.WriteLine("2) Comenzar una nueva suma");
        }


        public static int ReadMenuOption()
        {
            string option = System.Console.ReadLine();

            try
            {
                int result = System.Convert.ToInt32(option);
                return result;
            }
            catch (System.Exception e)
            {
                return -1;
            }
        }


        public static void ReadMenuOption( int Maxnumber, int Minnumber)
        {
            while (true)
            {
                int option = ReadMenuOption();
                if (Minnumber >= 0 && Maxnumber <= 2)
                    else
                    {

                    }

            }
        }
    }
}
