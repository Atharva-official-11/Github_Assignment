﻿
namespace classes_and_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(100, "toyota", "M12", 2012, 3000000);
            //car1.addCarDetails();
            car1.displyCarDetails();
        }
    }
}
