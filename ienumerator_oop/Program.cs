using System;
using System.Collections.Generic;

namespace ienumerator_oop {
    
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Program {
        static void Main(string[] args) {

            var collection = new List<Product>() {
                new Product() {Id =1, Name = "CPU", Price = 400},
                new Product() {Id =2, Name = "GPU", Price = 1000},
                new Product() {Id =3, Name = "Mobo", Price = 600},
                new Product() {Id =4, Name = "RAM", Price = 200}
            };

            foreach (var item in collection) {
                Console.WriteLine($"{item.Id} " + $"{item.Name} " + $"{item.Price}");
            }

            Console.WriteLine(new string('-', 25));

            IEnumerator<Product> enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext()) {
                Console.WriteLine($"{enumerator.Current.Id} " + $"{enumerator.Current.Name} "
                    + $"{enumerator.Current.Price}");
            }

            Console.ReadKey();
        }
    }
}
