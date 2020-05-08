using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Interface.Entidades
{
    static class Registro
    {
        public static void GerarRegistro(Contrato contrato)
        {
            int meses = contrato.Meses;
            double valorParcela = contrato.Valor / meses;
            DateTime inicio = contrato.Date;
            for(int i=1; i<=meses; i++)
            {
                inicio = inicio.AddMonths(1);

                Console.WriteLine("Dia "
                    + inicio.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                    + ": "
                    + contrato.Pagamento.Taxa(valorParcela, i).ToString("C2"));
            }
        }
    }
}
