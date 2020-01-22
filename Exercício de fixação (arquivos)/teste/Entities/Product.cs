using System;
using System.Collections.Generic;
using System.Text;

namespace teste.Entities
{
    class Product
    {
        public string Objeto { get; set; }
        public double Preco { get; set; }

        public Product(string objeto, double preco)
        {
            Objeto = objeto;
            Preco = preco;
        }

        public override string ToString()
        {
            return Objeto + ", R$" + Preco.ToString("F2");
        }
    }
}
