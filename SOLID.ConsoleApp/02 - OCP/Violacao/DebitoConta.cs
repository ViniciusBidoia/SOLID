using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.OCP.Violacao
{
    /// <summary>
    /// Exemplo de violacao, caso tivesse mais tipos de contas no fututo, seria necessario modificar a classe, quebrando o conceito do ABERTO-FECHADO
    /// </summary>
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                // Debita Conta Corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                // Valida Aniversário da Conta
                // Debita Conta Poupança
            }
        }
    }
}
