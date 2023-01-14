using System;

namespace interface_loosely_coupled_oop {
    public class Stack : IStack {

        private readonly IStack _stack;

        public Stack(IStack stack) {
            _stack = stack;
        }

        public void Pop() {
            _stack.Pop();
        }

        public void Push(int item) {
            _stack.Push(item);
        }
    }
}
