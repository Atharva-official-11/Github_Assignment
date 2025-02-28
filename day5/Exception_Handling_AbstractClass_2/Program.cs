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


/*
 
 
 using System;

abstract class VehicleInsurance
{
    public string VehicleType { get; set; }
    public double InsuredValue { get; set; }

    // Constructor
    public VehicleInsurance(string vehicleType, double insuredValue)
    {
        if (insuredValue <= 0)
        {
            throw new ArgumentException("Insured value must be greater than zero.");
        }
        VehicleType = vehicleType;
        InsuredValue = insuredValue;
    }

    // Abstract method for premium calculation
    public abstract double CalculatePremium();
}

// Two-Wheeler Insurance Policy
class TwoWheelerInsurance : VehicleInsurance
{
    public TwoWheelerInsurance(double insuredValue) : base("Two-Wheeler", insuredValue) { }

    public override double CalculatePremium()
    {
        return InsuredValue * 0.02; // 2% of insured value
    }
}

// Four-Wheeler Insurance Policy
class FourWheelerInsurance : VehicleInsurance
{
    public FourWheelerInsurance(double insuredValue) : base("Four-Wheeler", insuredValue) { }

    public override double CalculatePremium()
    {
        return InsuredValue * 0.03; // 3% of insured value
    }
}

// Commercial Vehicle Insurance Policy
class CommercialInsurance : VehicleInsurance
{
    public CommercialInsurance(double insuredValue) : base("Commercial", insuredValue) { }

    public override double CalculatePremium()
    {
        return InsuredValue * 0.05; // 5% of insured value
    }
}

class Program
{
    static void Main()
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
                    policy = new TwoWheelerInsurance(insuredValue);
                    break;
                case 2:
                    policy = new FourWheelerInsurance(insuredValue);
                    break;
                case 3:
                    policy = new CommercialInsurance(insuredValue);
                    break;
                default:
                    throw new ArgumentException("Invalid vehicle type selected.");
            }

            Console.WriteLine($"\nVehicle Type: {policy.VehicleType}");
            Console.WriteLine($"Insured Value: {policy.InsuredValue}");
            Console.WriteLine($"Calculated Premium: {policy.CalculatePremium()}");
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

 
 
 
 */