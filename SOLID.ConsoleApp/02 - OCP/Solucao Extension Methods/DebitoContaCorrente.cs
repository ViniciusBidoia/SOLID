using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta corrente.
            return debitoConta.FormatarTransacao();
        }
    }
}
