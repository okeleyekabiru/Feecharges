using System;
using System.Collections.Generic;
using System.Text;
using FeeCharges.infrastructure;


namespace FeeCharges.UiConsole
{
   public class UiConsole
    {
       
        public static void Run()
        {
            bool isValid = false;
            int input;
            do
            {
                Console.Clear();

                Console.WriteLine("====================================================================");
            Console.WriteLine("                 welcome to parkway bank                             ");
            Console.WriteLine();
            Console.WriteLine("          please select  the bank you would like to transfer too    ");
            Console.WriteLine();
            Console.WriteLine("====================================================================");
            Console.WriteLine("====================================================================");
            Console.WriteLine("                           1, first bank                            ");
            Console.WriteLine();
            Console.WriteLine("                           2, union Bank                             ");
            Console.WriteLine();
            Console.WriteLine("                           3, access Bank                            ");
            Console.WriteLine();
            Console.WriteLine("====================================================================");
            isValid = int.TryParse(Console.ReadLine(), out input) && (input == 1 || input == 2 || input == 3);
            } while (!isValid);
            Console.Clear();
            AmountToSend();
           
        }

      
       private  static  void AmountToSend()
        {
            double input;
            bool isValid;
            do
            {
           
                Console.WriteLine("====================================================================");
                Console.WriteLine("              please provide the amount you want to send            ");
                Console.WriteLine();
                Console.WriteLine("====================================================================");
                isValid = double.TryParse(Console.ReadLine(), out input);
                // check for value below one
                if (input < 1)
                {
                    Console.WriteLine("please provide a valid amount");
                }
            } while (!isValid || input < 1);

            DisplayCharge(input);




        }

        private static void DisplayCharge(double amount)
        {
            Console.Clear();
            Console.WriteLine($"the charge fee for this transfer is {ApplyCharges.AmountToPay(  Configuration.GetFeeSection(),amount)}");

        }
    }
}
