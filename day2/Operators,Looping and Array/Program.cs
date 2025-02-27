using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Operators_Looping_and_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
         1.A software company wants to develop a Salary Calculation System that
            calculates the Net Salary of employees based on their basic salary, tax
            deductions, and bonus.The system should perform various operations
            using arithmetic, relational, logical operators
             Take the basic salary as user input.
             Calculate a tax deduction(10 % of the basic salary). 
             Add a bonus based on performance ratings:
             Rating >= 8 → Bonus = 20 % of the basic salary.
             Rating >= 5 and < 8 → Bonus = 10 % of the basic salary.
             Rating < 5 → No bonus. 
             Display the computed salary after all calculations.
            */

            //#region assignment1
            //double empSalary;
            //double rating;
            //double emp_tax;
            //double employeeTotalSalary = 0;

            //Console.WriteLine("Enter the employee salary : ");
            //empSalary = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter employee rating...");
            //rating = Convert.ToDouble(Console.ReadLine());

            //if (rating >= 8)
            //{
            //    emp_tax = empSalary * 0.10;
            //    Console.WriteLine(emp_tax);
            //    empSalary -= emp_tax;
            //    Console.WriteLine(empSalary);
            //    employeeTotalSalary = empSalary + empSalary * 0.20;
            //    Console.WriteLine(employeeTotalSalary);
            //}
            //else if (rating >= 5 && rating < 8)
            //{

            //    emp_tax = empSalary * 0.10;
            //    empSalary -= emp_tax;
            //    employeeTotalSalary = empSalary + empSalary * 0.10;
            //}
            //else
            //{
            //    emp_tax = empSalary * 0.10;
            //    empSalary -= emp_tax;
            //    employeeTotalSalary = empSalary;
            //}

            //Console.WriteLine($"Employee Salary is : {employeeTotalSalary}");

            //#endregion

            /* 
            2.Create a program that Facilitates online train ticket booking and
                        calculates the total cost.Display ticket types(General - 200, Ac - 1000rs,
                        sleeper - 500), decide the price as per your wish, ask the user to input the
            type and number of tickets they want and calculate the total cost.
             User can book multiple tickets until he types exit(use appropriate
            loop and statements).
            */


            //#region question2

            //Console.WriteLine("1.General-200rs\n2.Ac-1000rs\n3.Sleeper-500rs\n4.Exit");
            //Console.WriteLine("Enter your Choice");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //int numberOfGeneralTickets = 0;
            //int numberOfAcTickets = 0;
            //int numberOfSleeperTickets = 0;

           

            //while (choice != 4)
            //{
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter number of tickets::");
            //            numberOfGeneralTickets += Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 2:
            //            Console.WriteLine("Enter number oF tickets::");
            //            numberOfAcTickets += Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 3:
            //            Console.WriteLine("Enter number of tickets::");
            //            numberOfSleeperTickets += Convert.ToInt32(Console.ReadLine());
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice");
            //            break;


            //    }
            //    Console.WriteLine("Enter your Choice");
            //    choice = Convert.ToInt32(Console.ReadLine());
            //}
            //double totalCost = ((numberOfGeneralTickets * 200 )+(numberOfAcTickets * 1000)+(numberOfSleeperTickets * 500));
            //Console.WriteLine("Tickets Details:");
            //Console.WriteLine($"Number of General Tickets:{numberOfGeneralTickets}");
            //Console.WriteLine($"Number of Ac Tickets:{numberOfAcTickets}");
            //Console.WriteLine($"Number of Sleeper Tickets:{numberOfSleeperTickets}");
            //Console.WriteLine($"TotalCost:{totalCost}");

            //#endregion


            #region question3
            double[,] userData =
            {
                { 101, 500.75 },
                { 102, 1200.50 },
                { 103, 300.00 },
                { 104, 750.25 },
                { 105, 950.00 }
            };

            bool validUser = true;
            int userId;

            Console.WriteLine("Welcome to the Online Shopping Wallet System!");
            while (true)
            {
                Console.WriteLine("Enter User Id::");
                userId = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < userData.GetLength(0); i++)
                {
                    if (userData[i, 0] == userId)
                    {
                        validUser = true;
                        Console.WriteLine($"Wallet Balance:{userData[i, 1]}");
                        break;
                    }
                }
                if (!validUser)
                {
                    Console.WriteLine("Invalid User ID");
                }

                if (userId == 0) break;

            }


            #endregion

        }
    }
}
