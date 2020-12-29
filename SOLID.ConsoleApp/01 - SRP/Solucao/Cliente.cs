using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.SRP.Solucao
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public CPF Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        /// <summary>
        /// Responsabilidade de validar email e cpf passam a estar na suas respoectivas classes
        /// </summary>
        /// <returns></returns>
        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}
