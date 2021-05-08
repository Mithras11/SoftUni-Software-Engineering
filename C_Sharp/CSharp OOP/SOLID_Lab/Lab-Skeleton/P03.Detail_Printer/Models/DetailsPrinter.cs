namespace P03.DetailPrinter.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DetailsPrinter
    {
        private IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        public string PrintDetails()
        {
            var sb = new StringBuilder();

            sb.AppendJoin(Environment.NewLine, employees);

            return sb.ToString().Trim();
        }
               
    }
}
