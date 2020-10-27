using System;

namespace CalculadoraMadeInChina
{
    class Program
    {
        public static int ManageAddSubMenu(int Acumuled)
        {
            while (true)
            {
                UserInterface.PrintAddHeader();
                System.Console.WriteLine("LLevas acumulado: " + Acumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número ");
                Acumuled = Acumuled + number;
                System.Console.WriteLine("LLevas acumulado: " + Acumuled);
                UserInterface.PrintAddSubMenu();
                int option = UserInterface.ReadMenuOption();
                switch(option)
                {
                    case 0:
                        return 0;
                    case 1:
                        break;
                    case 2:
                        return 2;
                }
            }
        }

        public static void ManageAddMenu()
        {
            while(true)
            {
                UserInterface.PrintAddHeader();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer número: ");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo número: ");
                int result = number1 + number2;
                System.Console.WriteLine("El resultado es: " + result);
                UserInterface.PrintAddSubMenu();
                int option = UserInterface.ReadMenuOption();
                if (option == 0)
                {
                    //sirve tanto break como return
                    return;
                }
                else if (option == 2)
                {
                    System.Console.Clear();
                }
                else if (option == 1)
                {
                   int SubMenuOption = ManageAddSubMenu(result);
                    if (SubMenuOption == 0)
                    {
                        return;
                    }
                }
            }
        }

        public static void ManageMainMenu()

        {
            bool finished = false;

            while (finished == false)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadMenuOption();

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
