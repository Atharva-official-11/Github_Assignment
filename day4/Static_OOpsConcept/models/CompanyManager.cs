using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_OOpsConcept.models
{
    internal class CompanyManager:CompanyEmployee
    {
        public double EmployeeBonus { get; set; }
        public CompanyManager(string name , double salary , double bonus) :base(name,salary)
        {
            EmployeeName = name;
            EmployeeSalary = salary;
            EmployeeBonus = bonus;
        }

        public override void EmployeeDetails()
        {
            Console.WriteLine($"Employee name is : {EmployeeName}\nEmployee salary is : {EmployeeSalary}\nwith bonus:{EmployeeBonus}");

        }
    }
}
