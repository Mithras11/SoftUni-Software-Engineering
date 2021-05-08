using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var properties = obj
                .GetType()
                .GetProperties();

            foreach (var property in properties)
            {
                var attributes = property
                    .GetCustomAttributes(true)
                    .Where(a => a is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (var attribute in attributes)
                {
                    if (!attribute.IsValid(property.GetValue(obj)))
                    {
                        return false;
                    }
                }

            }

            return true;
        }
    }
}
