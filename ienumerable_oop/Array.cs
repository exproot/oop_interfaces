using System.Collections;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace ienumerable_oop {
    public class Array : IEnumerable {
        private int[] InnerList { get; set; }
        private int index = 0;

        public Array(int size = 16) {
            InnerList = new int[size];
        }

        public Array(params int[] initial) {

            InnerList = new int[initial.Length];

            foreach (var item in initial) {
                InnerList[index] = item;
                index++;
            }
        }

        public IEnumerator GetEnumerator() {
            
            // default
            //return InnerList.Take(index).GetEnumerator();

            // custom
            return new ArrayEnumerator(InnerList);
        }
    }
}
