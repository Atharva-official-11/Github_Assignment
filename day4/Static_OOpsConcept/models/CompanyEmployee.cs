using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Static_OOpsConcept.models
{
    internal class CompanyEmployee
    {
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }

        public CompanyEmployee(string name , double salary)
        {
            this.EmployeeName = name;
            this.EmployeeSalary= salary;
        }

        public virtual void EmployeeDetails() {

            Console.WriteLine($"Employee name is : {EmployeeName}\nEmployee salary is : {EmployeeSalary}");

        }
    }
}
