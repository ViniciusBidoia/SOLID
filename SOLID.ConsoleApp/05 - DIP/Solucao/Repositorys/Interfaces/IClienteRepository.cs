using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.DIP.Solucao.Repositorys.Interfaces
{
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }
}
