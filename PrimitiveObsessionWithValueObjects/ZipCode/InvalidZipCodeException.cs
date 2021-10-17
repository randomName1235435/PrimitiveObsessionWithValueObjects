using System;

namespace PrimitiveObsessionWithValueObjects.ZipCode
{
    [Serializable]
    public class InvalidZipCodeException : Exception
    {
        public InvalidZipCodeException(string value) : base($"invalid value for german zipcode: {value}") { }
    }
}
