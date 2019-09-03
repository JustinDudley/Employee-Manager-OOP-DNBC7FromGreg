using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagerLibrary {

    public class Employee {

        public string Name { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }

        public virtual string Print() {
            return $"{this.GetType().Name}:: Name: {Name}, Job: {Job}, Salary: {Salary.ToString("C")}";
        }

        public Employee(string name, string job, decimal salary) {
            this.Name = name;
            this.Job = job;
            this.Salary = salary;
        }
    }
}
