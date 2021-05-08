using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string classToInvestigate, params string[] fieldNames)
        {

            var type = Type.GetType(classToInvestigate);

            var fields = type
                .GetFields(BindingFlags.Public
                | BindingFlags.NonPublic
                | BindingFlags.Instance
                | BindingFlags.Static);


            var sb = new StringBuilder();

            sb.AppendLine($"Class under investigation: {classToInvestigate}");

            var classInstance = Activator.CreateInstance(type, new object[] { });

            foreach (var field in fields.Where(f => fieldNames.Contains(f.Name)))
            {
                var name = field.Name;
                var value = field.GetValue(classInstance);

                sb.AppendLine($"{name} = {value}");
            }


            return sb.ToString().Trim();
        }


       
    }
}
