using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMadeInChina
{
    class ManageUtils
    {
        public static int ReadInteger(string message)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine(message);
                    string line = System.Console.ReadLine();
                    int number = System.Convert.ToInt32(line);
                    return number;
                }
                catch
                {
                    System.Console.WriteLine("Número no válido ");
                }
            }
        }
    }
}
