using System;
using System.Collections.Generic;

namespace icomparable_T_oop {

    public class Program {
        static void Main(string[] args) {

            var emps = new List<Employee>() {
                new Employee() { Id = 1, FullName = "Kai Havertz", Salary = 800000 },
                new Employee() { Id = 2, FullName = "Guti Hernandez", Salary = 200000 },
                new Employee() { Id = 3, FullName = "Paulo Dybala", Salary = 100000 },
                new Employee() { Id = 4, FullName = "Neymar Jr.", Salary = 600000 },
                new Employee() { Id = 5, FullName = "Eden Hazard", Salary = 500000 }
            };

            emps.Sort();

            foreach (var item in emps) {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
