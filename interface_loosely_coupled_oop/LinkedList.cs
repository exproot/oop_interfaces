using System;

namespace interface_loosely_coupled_oop {
    public class LinkedList : IStack {
        public void Pop() {
            Console.WriteLine("LinkedList.Pop()");
        }

        public void Push(int item) {
            Console.WriteLine("LinkedList.Push()");
        }
    }
}
