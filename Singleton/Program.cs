using System;

namespace Singleton
{
    class Program
    {
        static void playerPayToPlayer(IPlayer source, IPlayer dest, int amount)
        {
            source.pay(amount);
            dest.earn(amount);
            Console.WriteLine(string.Format("{0} donne {1} € à {2}", source.Name, amount, dest.Name));
        }

        static void Main(string[] args)
        {
            Bank bank1 = Bank.getInstance(100000, null);
            Bank bank2 = Bank.getInstance(100000, null);

            HumanPlayer player1 = new HumanPlayer("joueur 1", 50000);
            HumanPlayer player2 = new HumanPlayer("joueur 2", 50000);

            Console.WriteLine(bank1);
            Console.WriteLine(bank2);
            Console.WriteLine(player1);
            Console.WriteLine(player2);

            Console.WriteLine("");
            playerPayToPlayer(bank1, player1, 20000);
            playerPayToPlayer(bank2, player2, 10000);

            Console.WriteLine("");
            Console.WriteLine(bank1);
            Console.WriteLine(bank2);
            Console.WriteLine(player1);
            Console.WriteLine(player2);
        }
    }
}
