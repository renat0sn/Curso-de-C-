using System;
using System.Collections.Generic;
using System.Text;

namespace Contribuinte.Entities
{
    class JuridicalPerson : Taxpayer
    {
        public int Employees { get; set; }

        public JuridicalPerson()
        {
        }

        public JuridicalPerson(string name, double annualIncome, int employees) : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double TaxCalc()
        {
            double tax;

            if(Employees <= 10)
            {
                tax = AnnualIncome * 0.16;
            }
            else
            {
                tax = AnnualIncome * 0.14;
            }

            return tax;
        }
    }
}
