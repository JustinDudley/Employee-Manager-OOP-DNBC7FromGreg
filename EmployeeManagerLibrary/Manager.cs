using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagerLibrary {

    public class Manager : Employee {

        public int TeamSize { get; set; } = 0;

        public override string Print() {
            return base.Print() + $", Team Size: {TeamSize}";
        }

        public Manager(string name, string job, decimal salary, int teamSize) 
            : base(name, job, salary) {
            this.TeamSize = teamSize;
        }
    }
}
