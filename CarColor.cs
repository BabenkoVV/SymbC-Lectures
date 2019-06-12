using System;

namespace HW1_CarConstructor
{
    public class CarColor
    {
        public CarColor(string color, bool gradient)
        {
            Color = color;
            Gradient = gradient;
        }

        public string Color { get; set; }
        public bool Gradient { get; set; }
    }
}
