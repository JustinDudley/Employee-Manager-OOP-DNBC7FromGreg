using EmployeeManagerLibrary;
using System;
using System.Collections.Generic;

namespace EmployeeManagerProject {
    class Program {

        void X() {

        }
        void Run() {
            var emp1 = new Employee("John Doe", "Maint", 35000);
            var emp2 = new Employee("Jane Smith", "Sr. Maint", 45000);
            var emp3 = new Employee("Noah Phence", "Clown", 15000);

            var mgr1 = new Manager("Chrystal Vaze", "Maint Mgr", 55000, 10);
            var mgr2 = new Manager("Graham Krakir", "Clown Mgr", 55000, 5);
            Console.WriteLine(mgr2.Print());

            var emps = new List<Employee>() { emp1, emp2, emp3, mgr1, mgr2 };
            foreach(var emp in emps) {
                Console.WriteLine(emp.Print());
            }
        }

        static void Main(string[] args) {
            (new Program()).Run();
        }
    }
}
