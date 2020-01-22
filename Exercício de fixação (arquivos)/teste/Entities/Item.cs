using System;
using System.Collections.Generic;
using System.Text;

namespace teste.Entities
{
    class Item
    {
        public Product Produto { get; set; }
        public int Qtd { get; set; }

        public Item(Product produto, int qtd)
        {
            Produto = produto;
            Qtd = qtd;
        }

        public double SubTotal()
        {
            return Produto.Preco * Qtd;
        }
    }
}
