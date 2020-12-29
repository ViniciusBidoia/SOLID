using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.DIP.Solucao.Services.Inferfaces
{
    public interface IEmailServices
    {
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}
