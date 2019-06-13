using System;

namespace HW4_CarConstructor
{

    public class CarEngine
    {
        public CarEngine(int wattPower, string model)
        {
            WattPower = wattPower;
            Model = model;
        }

        public int WattPower { get; set; }
        public string Model { get; set; }
    }
}
