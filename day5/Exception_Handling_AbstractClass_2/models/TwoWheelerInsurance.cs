
using Exception_Handling_AbstractClass_2.repository;

namespace Exception_Handling_AbstractClass_2.models
{
    internal class TwoWheelerInsurance: VehicleInsurance
    {
        public TwoWheelerInsurance( string VehincleInsuranceType,  double VehicleInsuranceValue) : base(VehincleInsuranceType, VehicleInsuranceValue) { 
        
        }

        public override double GetinsurancePremiumCalculation()
        {
            return VehicleInsuranceValue * 0.02;// 2% of insured value
        }
    }
}
