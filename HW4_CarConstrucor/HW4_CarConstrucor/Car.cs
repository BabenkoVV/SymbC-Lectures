using System;

namespace HW4_CarConstructor
{
    public class Car
    {
        public Car(CarColor color, CarEngine engine, CarTransmission transmission)
        {
            Color = color;
            Engine = engine;
            Transmission = transmission;
        }

        public CarColor Color { get; set; }
        public CarEngine Engine { get; set; }
        public CarTransmission Transmission { get; set; }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Car color: '{Color.Color}'; Car gradient value: '{Color.Gradient}';\n" +
                $"Car engine model: '{Engine.Model}'; Car engine power: '{Engine.WattPower}';\n" +
                $"Car transmission model: '{Transmission.Model}'; Car transmission auto value: '{Transmission.Automatic}'.\n");
        }
    }
}
