using Task1.Model;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(13569,"Atharva Chaudhari",23, new DateTime(2018,01,19));
            employee.calculateExperience();
        }
        }
}
