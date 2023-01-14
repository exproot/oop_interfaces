using System;
using System.Net.WebSockets;

namespace interface_loosely_coupled_oop {
    public class Program {
        static void Main(string[] args) {

            var stack = new Stack(new ArrayStack());
            var stack2 = new Stack(new LinkedList());

            stack.Pop();
            stack.Push(5);
            stack2.Pop();
            stack2.Push(5);

            Console.ReadKey();
        }
    }
}
