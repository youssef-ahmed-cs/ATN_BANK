using System;
namespace ATM
{
    class BANK_SYSTEM
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================== CIB ATM =====================\n");

            int amount = 3000, deposit, withdraw;
            int choice;
            string pin;

            do
            {
                Console.Write("Enter Your 4 Digit Pin: ");
                pin = Console.ReadLine();

                if (pin.Length < 4)
                {
                    Console.WriteLine("Error: PIN must be 4 digits long plase try agin......\n");
                }
            } while (pin.Length < 4);

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("==================================================\n");
                Console.WriteLine("1.Current Balance\n");
                Console.WriteLine("2.Withdraw \n");
                Console.WriteLine("3.Deposit \n");
                Console.WriteLine("4.Cancel \n");
                Console.WriteLine("==================================================\n");
                Console.Write("ENTER YOUR CHOICE: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("==================================================\n");
                        Console.WriteLine("YOUR CURRENT BALANCE IS EG : {0} ", amount);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("PLEASE ENTER THE AMOUNT IN ABOVE 100");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("SORRY! INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("CURRENT BALANCE IS EG : {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY.....");
                        Console.WriteLine("YOUR TOTAL BALANCE IS EG : {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("THANK YO...");
                        break;
                }
            }
        }
    }
}