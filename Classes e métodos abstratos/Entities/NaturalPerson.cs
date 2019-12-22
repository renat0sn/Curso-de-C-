using System;
using System.Collections.Generic;
using System.Text;

namespace Contribuinte.Entities
{
    class NaturalPerson : Taxpayer
    {
        public double HealthSpending { get; set; }

        public NaturalPerson()
        {
        }

        public NaturalPerson(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double TaxCalc()
        {
            double tax;

            if(AnnualIncome < 20000)
            {
                tax = AnnualIncome*0.15;
            }
            else
            {
                tax = AnnualIncome*0.25;
            }

            if(HealthSpending > 0)
            {
                tax -= HealthSpending / 2;
            }

            return tax;
        }
    }
}
