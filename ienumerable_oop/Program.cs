using System;

namespace ienumerable_oop {
    public class Program {
        static void Main(string[] args) {

            var arr1_custom = new Array(1, 3, 5,7, 9);
            var arr2 = new int[] { 1, 3, 5, 7 };

            //predefined
            foreach (var item in arr2) {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('-', 25));

            foreach (var item in arr1_custom) {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
