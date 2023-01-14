using System;

namespace icomparable_T_oop {
    public class Employee : IComparable<Employee> {
        public int Id { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(Employee other) {

            return this.FullName.CompareTo(other.FullName);
            //return this.Id.CompareTo(other.Id);
            //return this.Salary.CompareTo(other.Salary);
        }

        public override string ToString() {
            return $"{Id,-5} {FullName,-15} {Salary,10}";
        }

    }
}
