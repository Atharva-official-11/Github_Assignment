
namespace Exception_Handling_AbstractClass_2.repository
{
    abstract class VehicleInsurance
    {
        // Corrected property name for consistency
        public string VehicleInsuranceType { get; set; }

        public double VehicleInsuranceValue { get; set; }

        // Constructor
        public VehicleInsurance(string vehicleInsuranceType, double vehicleInsuranceValue)
        {
            if (vehicleInsuranceValue <= 0)
            {
                throw new ArgumentException("Insured value must be greater than zero.");
            }

            this.VehicleInsuranceType = vehicleInsuranceType;
            this.VehicleInsuranceValue = vehicleInsuranceValue;
        }

        // Abstract method for premium calculation
        public abstract double GetinsurancePremiumCalculation();
    }
}







































//namespace Exception_Handling_AbstractClass_2.repository
//{
//    abstract class VehicleInsurance
//    {
//        public string VehincleInsuranceType { get; set; }

//        public double VehicleInsuranceValue { get; set; }

//        public VehicleInsurance(string VehincleInsuranceType, double VehicleInsuranceValue)
//        {
//            //try
//            //{

//            //    if (VehicleInsuranceValue <= 0)
//            //    {
//            //        throw new Exception("Please Enter the valid is InValue....");
//            //    }
//            //}
//            //catch (Exception e) { 

//            //}
//            //this.VehincleInsuranceType = vehicleType;
//            //this.VehicleInsuranceValue = VehicleInsuranceValue;

//            if (VehicleInsuranceValue <= 0)
//            {
//                throw new ArgumentException("Insured value must be greater than zero.");
//            }
//            this.VehincleInsuranceType = VehincleInsuranceType;
//            this.VehicleInsuranceValue = VehicleInsuranceValue;
//        }
//        public abstract double GetinsurancePremiumCalculation();
//    }
//}
