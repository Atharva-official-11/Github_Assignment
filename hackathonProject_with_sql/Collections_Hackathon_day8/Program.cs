using Collections_Hackathon_day8.models;
using Collections_Hackathon_day8.repository;
using Collections_Hackathon_day8.exceptions;

namespace InsuranceManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IPolicyInsuranceRepository repository = new PolicyRepository();
            bool exit = false;


            while (!exit)
            {
                Console.WriteLine("Insurance Policy Management System");
                Console.WriteLine($"1. Add Policy\t2. View All Policies\t3. Search Policy by ID\t4. Update Policy Details ");
                Console.WriteLine($"5. Delete Policy\t6. View Active Policies\t 7. View Active Policies Sorted by Start Date");
                Console.WriteLine("8. Exit");

                Console.WriteLine("\n");
                Console.Write("Enter your choice: ");
                
                Console.WriteLine("\n");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        try
                        {
                            //Console.Write("Enter Policy ID: ");
                            //int policyID = int.Parse(Console.ReadLine());

                            Console.Write("Enter Policy Holder Name: ");
                            string holderName = Console.ReadLine();

                            Console.Write("Enter Policy Type (0: Life, 1: Health, 2: Vehicle, 3: Property): ");
                            PolicyType type = (PolicyType)Enum.Parse(typeof(PolicyType), Console.ReadLine());

                            //Console.Write("Enter Start Date (MM/DD/YYYY): ");
                            DateTime startDate = DateTime.Now.Date;
                            //Console.WriteLine(startDate);

                            Console.Write("Enter End Date (MM/DD/YYYY): ");
                            DateTime endDate = DateTime.Parse(Console.ReadLine());
                            
                            Policy policy = new Policy(holderName, type, startDate, endDate);
                            Console.WriteLine("policy type " + policy.Type.ToString());
                            int check = repository.AddPolicy(policy);
                            Console.WriteLine("Policy update"+check);

                            if (check > 0)
                            {
                                Console.WriteLine("Policy updated successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Policy not updated.");
                            }

                            Console.WriteLine("\n");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;

                    case "2":
                        try
                        {
                            var policies = repository.GetAllPolicies();
                            if (policies.Any())
                            {
                                foreach (var policy in policies)
                                {
                                    Console.WriteLine(policy);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No policies found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                        Console.WriteLine("\n");
                        break;

                    case "3":
                        try
                        {
                            Console.Write("Enter Policy ID to search: ");
                            int policyID = int.Parse(Console.ReadLine());

                            var policy = repository.GetPolicyById(policyID);
                            Console.WriteLine(policy);
                        }
                        catch (InsurancePolicyExceptionHandling ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                        Console.WriteLine("\n");

                        break;

                    case "4":
                        try
                        {
                            Console.Write("Enter Policy ID to update: ");
                            int policyID = int.Parse(Console.ReadLine());

                            var existingPolicy = repository.GetPolicyById(policyID);

                            Console.Write("Enter new Policy Holder Name: ");
                            string holderName = Console.ReadLine();

                            Console.Write("Enter new Policy Type (0: Life, 1: Health, 2: Vehicle, 3: Property): ");
                            PolicyType type = (PolicyType)Enum.Parse(typeof(PolicyType), Console.ReadLine());

                            Console.Write("Enter new Start Date (MM/DD/YYYY): ");
                            DateTime startDate = DateTime.Parse(Console.ReadLine());

                            Console.Write("Enter new End Date (MM/DD/YYYY): ");
                            DateTime endDate = DateTime.Parse(Console.ReadLine());

                            Policy updatedPolicy = new Policy(policyID, holderName, type, startDate, endDate);
                            repository.UpdatePolicy(policyID, updatedPolicy);
                            Console.WriteLine("Policy updated successfully.");
                        }
                        catch (InsurancePolicyExceptionHandling ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                        Console.WriteLine("\n");

                        break;

                    case "5":
                        try
                        {
                            Console.Write("Enter Policy ID to delete: ");
                            int policyID = int.Parse(Console.ReadLine());

                            Console.Write("Are you sure you want to delete this policy? (y/n): ");
                            if (Console.ReadLine().ToLower() == "y")
                            {
                               int tocheck =  repository.DeletePolicyById(policyID);
                                if (tocheck > 0)
                                {
                                    Console.WriteLine("Policy updated successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Policy not updated.");
                                }
                            }
                        }
                        catch (InsurancePolicyExceptionHandling ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                        Console.WriteLine("\n");

                        break;

                    case "6":
                        try
                        {
                            var activePolicies = repository.GetAllActivePolicy();
                            if (activePolicies.Any())
                            {
                                foreach (var policy in activePolicies)
                                {
                                    Console.WriteLine(policy);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No active policies found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                        Console.WriteLine("\n");

                        break;

                    case "7":
                        try
                        {
                            var activePolicies = repository.GetActivePolicies().OrderBy(p => p.StartDate).ToList();
                            if (activePolicies.Any())
                            {
                                foreach (var policy in activePolicies)
                                {
                                    Console.WriteLine(policy);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No active policies found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }

                        Console.WriteLine("\n");

                        break;

                    case "8":
                        exit = true;
                        Console.WriteLine("\n");

                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine("\n");

                        break;
                }
            }
        }
    }
}
