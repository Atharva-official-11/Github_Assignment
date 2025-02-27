using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;

namespace dataTypes_type_coversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //student database

            /*   1.You are developing a school management system. Each student has a name, age, and
   percentage.Write a C# code to perform the following 
    Choose the appropriate data types to store the information
    Ask the user to enter values for these fields. 
    Display the information of student to console window*/
            /*
           2.In the above scenario user might enter a non-numeric value for age, which halts the
           execution 
            handle this situation and write a appropriate c# code for this. 
            Give proper message to the user if he enters non-numeric value
           */
            /*
            3.In a school management Application take one more field email.
             Ask the user to enter their email
             The program should not allow the user to leave this field empty. 
             How would you check if the user has entered an empty string?*/

            string name;
            int age;
            float percentage;
            string studentEmail;

            Console.WriteLine("Enter Your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your age::");

            bool result = int.TryParse(Console.ReadLine(), out age);

            while (result != true)
            {
                Console.WriteLine("Enter valid Age!");
                result = int.TryParse(Console.ReadLine(), out age);

                if (result)
                {
                    break;
                }
            }

            Console.WriteLine("Enter percentage:");
            percentage = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your student email");

            studentEmail = Console.ReadLine();

            while (string.IsNullOrEmpty(studentEmail))
            {
                Console.WriteLine("Enter your student email first to move forward!");
                studentEmail = Console.ReadLine();

                if (!string.IsNullOrEmpty(studentEmail))
                {
                    Console.WriteLine("Email enter successfully");
                    break;
                }
            }
            //if (string.IsNullOrEmpty(studentEmail))
            //{
            //}
            //else
            //{
            //    Console.WriteLine("Email enter successfully");   
            //}


            Console.WriteLine($"\n\n\nThe student name is: {name}\nage is {age} \npercentage score is {percentage}\nEmail of student is {studentEmail}");


            Console.WriteLine("\n\n\n");
            /*
            //  hospital management system

            4.You are building a hospital management system where a patient’s discharge date may not
            always be available

             The system should allow null values for the discharge date but still be able
             to check if a patient has been discharged. 
             If the patient has the discharge date print it to the console, if discharge date is
            null then print “Not Discharged” message to the console.*/

            //string? dateTime = null;

            //Console.WriteLine("Enter date of discharge");

            //dateTime = Console.ReadLine();

            //if (string.IsNullOrEmpty(dateTime))
            //{
            //    Console.WriteLine("patient is not discharge...");

            //}
            //else
            //{
            //    Console.WriteLine($"Patient is discharge on {dateTime}");
            //}



            //DateTime? dischargeTime = null;

            //Console.WriteLine("Enter date for discharge (yyyy-MM-dd):");
            //string input = Console.ReadLine();

            //// Try to parse the input string into a DateTime

            //if (DateTime.TryParse(input, out DateTime parsedDate))
            //{
            //    dischargeTime = parsedDate;
            //}

            //if (dischargeTime.HasValue)
            //{
            //    Console.WriteLine("Discharge Date: " + dischargeTime.Value.ToString("yyyy-MM-dd"));
            //}
            //else
            //{
            //    Console.WriteLine("Not Discharged");
            //}



            DateTime? dischargedDate = null;

            Console.WriteLine("Enter the date of discharged in format of (YYYY-MM-DD)");
            string input = Console.ReadLine();

            bool resultOfDischarged = DateTime.TryParse(input, out DateTime parseDate);
            dischargedDate = parseDate;
            if (dischargedDate.HasValue)
            {
                Console.WriteLine("The discharged date of patient is:" + dischargedDate);
            }
            else
            {
                Console.WriteLine("patient not discharged");
            }




        }
}
}
