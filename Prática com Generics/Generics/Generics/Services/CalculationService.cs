using System;
using System.Collections.Generic;
using System.Text;
using Generics.Entities;

namespace Generics
{
    class CalculationService
    {
        public T Max<T>(List<T> l) where T : IComparable
        {
            if(l.Count == 0)
            {
                throw new ArgumentException("Lista não pode ser vazia.");
            }

            T max = l[0];
            foreach(T t in l)
            {
                if(t.CompareTo(max) > 0)
                {
                    max = t;
                }
            }

            return max;
        }
    }
}
