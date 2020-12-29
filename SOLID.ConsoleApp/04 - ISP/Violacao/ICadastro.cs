using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.ISP.Violacao
{
    public interface ICadastro
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();
    }
}
