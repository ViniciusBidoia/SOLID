using SOLID.ConsoleApp.DIP.Solucao.Repositorys.Interfaces;
using SOLID.ConsoleApp.DIP.Solucao.Services.Inferfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.DIP.Solucao.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteService(
            IClienteRepository clienteRepository,
            IEmailServices emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);

            _emailServices.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
