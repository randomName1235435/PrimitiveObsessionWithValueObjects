using System;
using System.Collections.Generic;
using System.Text;
using ValueOf;
using System.Text.RegularExpressions;

namespace PrimitiveObsessionWithValueObjects.ZipCode
{
    public class GermanZipCode : ValueOf<string, GermanZipCode>
    {
        private const string germanZipCodeRegex = @"^(?!01000|99999)(0[1-9]\d{3}|[1-9]\d{4})$";
        private static readonly Regex regex =
           new Regex(germanZipCodeRegex, RegexOptions.IgnoreCase | RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        protected override void Validate()
        {

            if (!regex.IsMatch(Value))
                throw new InvalidZipCodeException(Value);
        }
    }
}
