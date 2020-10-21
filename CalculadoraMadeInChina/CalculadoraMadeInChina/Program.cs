using System;

namespace CalculadoraMadeInChina
{
    class Program
    {
        public static void ManageAddMenu()
        {
            while(true)
            {
                UserInterface.PrintAddMenu();

            }
        }

        public static void ManageMainMenu()

        {
            bool finished = false;

            while (finished == false)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadOption();

                switch (option)
                {
                    case -1:
                        System.Console.Clear();
                        System.Console.WriteLine("opción no valida");
                        break;
                    case 0:
                        finished = true;
                        break;
                    case 1:
                        ManageAddMenu();

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                }



                
            }
            System.Console.WriteLine("Fin del meenú principal");
        }

        static void Main(string[] args)
        {
            ManageMainMenu();
        }
    }
}
