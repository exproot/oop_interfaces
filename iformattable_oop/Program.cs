using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Principal;

namespace iformattable_oop {

    public class Program {
        static void Main(string[] args) {
            var emps = new List<Employee>() {

                new Employee() {
                Id = 7,
                FirstName = "Paulo",
                LastName = "Dybala"
                },
                new Employee() {
                Id = 29,
                FirstName = "Kai",
                LastName = "Havertz"
                },
                new Employee() {
                Id = 10,
                FirstName = "Neymar",
                LastName = "Junior"
                }

            };

            foreach (var item in emps) {
                //Console.WriteLine(item.ToString(""));
                //Console.WriteLine(item.ToString("FN"));
                //Console.WriteLine(item.ToString("LF"));
                Console.WriteLine(item.ToString("S"));
            }

            Console.ReadKey();
        }
    }
}
