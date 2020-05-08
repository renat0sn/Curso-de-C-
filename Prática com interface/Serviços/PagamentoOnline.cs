using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Serviços
{
    interface IPagamentoOnline
    {
        double Taxa(double valor, int mes);
    }
}
