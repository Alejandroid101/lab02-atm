using System;

namespace atm
{
    public static class Program
    {
        // Basic comments to welcome user and call of "options" method

        public static Double Balance = 5000;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BrokeBank!");
            
            Console.WriteLine("What transaction would you like to perform today?");
            Options();
        }

        public static void Options()
        {
            //options menu and method initializer. Everything wrapped on a while loop to end when exit.
            //case 1 and 2 run Deposit() and Withdraw() respectively.

            bool session = true;
            while (session)
            {
                Console.WriteLine("1.)Deposit");
                Console.WriteLine("2.)Withdraw");
                Console.WriteLine("3.)View Balance");
                Console.WriteLine("4.)Return Card(Exit)");
                string choice = Console.ReadLine();
                Double opt = Convert.ToDouble(choice);
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("How much would you like to deposit? ");
                        string dv = Console.ReadLine();
                        Double depoVal = Convert.ToDouble(dv);
                        Deposit(depoVal);
                        break;
                    case 2:
                        Console.WriteLine("How much would you like to withdraw? ");
                        string wv = Console.ReadLine();
                        Double withVal = Convert.ToDouble(wv);
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
        //Deposit only works with positive numbers. Updates The current balance.
        public static Double Deposit(Double amount)
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
        //Withdraw only allows you to get available money. Updates the current balance.
        public static Double Withdraw(Double amount)
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
