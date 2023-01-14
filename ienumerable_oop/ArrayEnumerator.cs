using System.Collections;

namespace ienumerable_oop {
    internal class ArrayEnumerator : IEnumerator {
        public object Current => InnerList[index];
        private int[] InnerList;
        private int index;
        public ArrayEnumerator(int[] arr) {
            InnerList = arr;
            index = InnerList.Length;
        }
        public bool MoveNext() {
            if(index == InnerList.Length) {
                index--;
                return true;
            }else if(index > 0) {
                index--;
                return true;
            }else {
                index = InnerList.Length;
                return false;
            }
        }

        public void Reset() {
            index = InnerList.Length;
        }
    }
}