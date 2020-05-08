using System;
using System.Collections.Generic;
using System.Text;
using Interface.Serviços;

namespace Interface.Entidades
{
    class Contrato
    {
        public int NumContrato { get; private set; }
        public DateTime Date { get; set; }
        public double Valor { get; set; }
        public int Meses { get; set; }
        public IPagamentoOnline Pagamento { get; set; }

        public Contrato(int numContrato, DateTime date, double valor, int meses, IPagamentoOnline pagamento)
        {
            NumContrato = numContrato;
            Date = date;
            Valor = valor;
            Meses = meses;
            Pagamento = pagamento;
        }
    }
}
