using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.ISP.Solucao.Interfaces
{
    public interface ICadastroCliente : ICadastro
    {
        void ValidarDados();
        void EnviarEmail();
    }
}
