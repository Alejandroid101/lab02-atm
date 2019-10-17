using System;

namespace atm
{
    public static class Program
    {
        public static Int32 Balance = 5000;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BrokeBank!");
            
            Console.WriteLine("What transaction would you like to perform today?");
            Options();
        }

        public static void Options()
        {
            bool session = true;
            while (session)
            {

                Console.WriteLine("1.)Deposit");
                Console.WriteLine("2.)Withdraw");
                Console.WriteLine("3.)View Balance");
                Console.WriteLine("4.)Return Card(Exit)");
                string choice = Console.ReadLine();
                int opt = Convert.ToInt32(choice);

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("How much would you like to deposit? ");
                        string dv = Console.ReadLine();
                        Int32 depoVal = Convert.ToInt32(dv);
                        Deposit(depoVal);
                        break;
                    case 2:
                        Console.WriteLine("How much would you like to withdraw? ");
                        string wv = Console.ReadLine();
                        Int32 withVal = Convert.ToInt32(wv);
                        Withdraw(withVal);
                        break;
                    case 3:
                        Console.WriteLine($"Your current balance is: {Balance} ");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine($"That is not a valid option, Try again. ");
                        break;
                }
            }
        }
        public static Int32 Deposit(Int32 amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
                Console.WriteLine($"Transaction completed. Your new balance is: {Balance}");
            }
            else
            {
                Console.WriteLine("That is an invalid input");
            }
            return Balance;
        }
        public static Int32 Withdraw(Int32 amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("You dont have that much bread");
            }
            else if (amount < 0)
            {
                Console.WriteLine("That is an invalid input");
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine($"Transaction completed. Your new balance is: {Balance}");
            }
            return Balance;
        }

    }
}
