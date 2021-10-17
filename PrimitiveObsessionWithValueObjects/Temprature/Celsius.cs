using System;
using System.Collections.Generic;
using System.Text;
using ValueOf;

namespace PrimitiveObsessionWithValueObjects.Temprature
{
    public class Celsius : ValueOf<double, Celsius>
    {
        private const double minTemperatureInCelsius = -273.15;

        protected override void Validate()
        {
            if (Value < minTemperatureInCelsius)
                throw new ArgumentOutOfRangeException($"Value is lower than absolute zero: {Value}");
        }
    }
}
