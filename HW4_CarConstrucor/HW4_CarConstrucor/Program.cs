using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_CarConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MyFirstCar = CarConstructor.Construct(new CarColor("Red", true), new CarEngine(300, "TopModel"), new CarTransmission("TopTransModel", true));
            MyFirstCar.PrintCarInfo();
            CarConstructor.Reconstruct(ref MyFirstCar, new CarEngine(400, "OverTopTransModel"));
            MyFirstCar.PrintCarInfo();
        }
    }
}
