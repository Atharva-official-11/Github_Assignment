using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_AbstractClass_2.exceptions
{
    class VehicleInsuranceException:ApplicationException
    {
        public VehicleInsuranceException() { }

        public VehicleInsuranceException(string msg) : base(msg) { }
    }
}
