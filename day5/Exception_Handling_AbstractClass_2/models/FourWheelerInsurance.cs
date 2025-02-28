
using Exception_Handling_AbstractClass_2.repository;

namespace Exception_Handling_AbstractClass_2.models
{
    internal class FourWheelerInsurance: VehicleInsurance
    {
        public FourWheelerInsurance(string VehincleInsuranceType, double VehicleInsuranceValue) : base(VehincleInsuranceType, VehicleInsuranceValue) { }

        public override double GetinsurancePremiumCalculation()
        {
            return this.VehicleInsuranceValue * 0.03; // 3% of insured value
        }
    }
}
