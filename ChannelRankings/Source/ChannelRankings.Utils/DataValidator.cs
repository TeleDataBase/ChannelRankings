using ChannelRankins.Contracts.Utils;
using System;
using System.Linq;

namespace ChannelRankings.Utils
{
    public class DataValidator : IValidator
    {
        public string ValidateNumberValue(string value)
        {
            var valueByChars = value.ToCharArray();

            if (valueByChars.Any(c => !char.IsDigit(c)))
            {
                throw new ArgumentException("Value must contain only numbers!");
            }

            return value;
        }

        public string ValidateCreationName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be empty!");
            }

            this.ValidateNameForUpdate(name);

            return name;
        }

        public string ValidateNameForUpdate(string name)
        {
            var nameByChars = name.ToArray();

            if (!char.IsUpper(nameByChars[0]))
            {
                throw new ArgumentException("Name should start with a capital letter!");
            }

            for (int i = 1; i < nameByChars.Length; i++)
            {
                if (char.IsUpper(nameByChars[i]))
                {
                    throw new ArgumentException("All letters except the first should be lower cased!");
                }
            }

            return name;
        }
    }
}
