using Exception_Handling_AbstractClass_2.models;
using Exception_Handling_AbstractClass_2.repository;

namespace Exception_Handling_AbstractClass_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Select Vehicle Type (1: Two-Wheeler, 2: Four-Wheeler, 3: Commercial): ");
                int choice = int.Parse(Console.ReadLine());

                Console.Write("Enter Insured Value: ");
                double insuredValue = double.Parse(Console.ReadLine());

                VehicleInsurance policy;

                switch (choice)
                {
                    case 1:
                        policy = new TwoWheelerInsurance("Two-Wheeler", insuredValue);
                        break;
                    case 2:
                        policy = new FourWheelerInsurance("Four-Wheeler", insuredValue);
                        break;
                    case 3:
                        policy = new CommercialInsurance("Commercial", insuredValue);
                        break;
                    default:
                        throw new ArgumentException("Invalid vehicle type selected.");
                }

                Console.WriteLine($"\nVehicle Type: {policy.VehicleInsuranceType}");
                Console.WriteLine($"Insured Value: {policy.VehicleInsuranceValue}");
                Console.WriteLine($"Calculated Premium: {policy.GetinsurancePremiumCalculation()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input Error: Please enter a valid numeric value.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Insurance premium calculation process completed.");
            }
        }
    }
}

