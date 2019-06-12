using System;

namespace HW1_CarConstructor
{
    public class CarTransmission
    {
        public CarTransmission(string model, bool automatic)
        {
            Model = model;
            Automatic = automatic;
        }

        public string Model { get; set; }
        public bool Automatic { get; set; }
    }
}
