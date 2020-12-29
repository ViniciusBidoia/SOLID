using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.ISP.Solucao.Interfaces
{
    public interface ICadastroProduto : ICadastro
    {
        void ValidarDados();
    }
}
