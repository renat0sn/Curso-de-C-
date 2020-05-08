using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Serviços
{
    class Paypal : IPagamentoOnline
    {
        public double Taxa(double valor, int mes)
        {
            double jSimples = valor * 0.01 * mes;
            double taxaPagamento = (valor + jSimples) + (valor + jSimples) * 0.02;
            return taxaPagamento;
        }
    }
}
