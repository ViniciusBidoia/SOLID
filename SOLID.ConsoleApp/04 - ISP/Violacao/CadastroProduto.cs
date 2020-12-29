using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            // Validar valor
        }

        public void SalvarBanco()
        {
            // Insert tabela Produto
        }

        /// <summary>
        /// Nao se envia email pro produto, pouca interface pra muita classe....
        /// </summary>
        public void EnviarEmail()
        {
            // Produto não tem e-mail, o que eu faço agora???
            throw new NotImplementedException("Esse metodo não serve pra nada");
        }
    }
}
