using System;

namespace csapp {

    public class Program {
        static void Main(string[] args) {

            var user1 = new SaverAcc();

            user1.Deposit(1000);

            Console.WriteLine(user1);

            user1.Withdraw(1250);

            Console.WriteLine(user1);

            Console.ReadKey();
        }
    }
}
