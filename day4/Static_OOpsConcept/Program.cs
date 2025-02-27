using Static_OOpsConcept.models;

namespace Static_OOpsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*userDetails user = new userDetails();
            userDetails user1 = new userDetails();
            userDetails user2 = new userDetails();
            userDetails user3 = new userDetails();
            
            userDetails.returnUserLoginCount();*/

            CompanyManager companyManager = new CompanyManager("Atharva",8000000.70, 500000);

            companyManager.EmployeeDetails();
        }
    }
}
