using System;

namespace HW4_CarConstructor
{
    public static class CarConstructor
    {
        public static Car Construct(CarColor color, CarEngine engine, CarTransmission transmission)
        {
            return new Car(color, engine, transmission);
        }

        public static void Reconstruct(ref Car car, CarEngine carEngine)
        {
            car.Engine = carEngine;
        }
    }
}
