using System;

namespace icloneable_oop {

    public class Program {
        static void Main(string[] args) {

            var book1 = new Book() {
                Id = 1,
                Title = "Book 1",
                Price = 25.0
            };

            var book2 = (Book)book1.Clone(); // casting

            book2.Title = "Book 2";

            Console.WriteLine(book1.Title);
            Console.WriteLine(book2.Title);

            Console.ReadKey();
        }
    }
}
