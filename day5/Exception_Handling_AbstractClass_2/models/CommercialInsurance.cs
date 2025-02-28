
using Exception_Handling_AbstractClass_2.repository;

namespace Exception_Handling_AbstractClass_2.models
{
    internal class CommercialInsurance:VehicleInsurance
    {
        public CommercialInsurance(string VehincleInsuranceType, double VehicleInsuranceValue) : base(VehincleInsuranceType, VehicleInsuranceValue) { }
        public override double GetinsurancePremiumCalculation()
        {
            return VehicleInsuranceValue * 0.05; // 5% of insured value
        }
    }

}
