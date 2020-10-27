using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMadeInChina
{
    class UserInterface
    {
        public static void PrintMainMenu()
        {
            System.Console.Clear();
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
            System.Console.WriteLine("0) Volver al menú principal");
            System.Console.WriteLine("1) Seguir sumando números");
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


        public static int ReadMenuOption(int Minnumber, int Maxnumber)
        {
            while (true)
            {
                int option = ReadMenuOption();
                if (option >= Minnumber && option <= Maxnumber)
                {
                    return option;
                }
                else
                {
                    System.Console.WriteLine("Opción fuera de rango");
                }
            }
        }
        public static void PrintSubHeader()
        {
            System.Console.WriteLine("Resta de números");
            System.Console.WriteLine(".......................");
        }

        public static void PrintSubSubMenu()
        {
            System.Console.WriteLine("0) Volver al menú principal");
            System.Console.WriteLine("1) Seguir restando números");
            System.Console.WriteLine("2) Comenzar una nueva resta");
        }

    }
}
