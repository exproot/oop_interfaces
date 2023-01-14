using System;

namespace interface_loosely_coupled_oop {
    public class ArrayStack : IStack {
        public void Pop() {
            Console.WriteLine("Array.Pop()");
        }

        public void Push(int item) {
            Console.WriteLine("Array.Push()");
        }
    }
}
