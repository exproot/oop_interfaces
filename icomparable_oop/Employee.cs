using System;

namespace icomparable_oop {
    public class Employee : IComparable {
        public int Id { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(object obj) {
            var cmpr = (Employee)obj;
            if(this.Salary < cmpr.Salary) { return -1; }
            else if (this.Salary.Equals(cmpr.Salary)) { return 0; }
            else { return 1; }

        }

        public override string ToString() {
            return $"{Id, -5} {FullName, -15} {Salary, 10}";
        }
    }
}
