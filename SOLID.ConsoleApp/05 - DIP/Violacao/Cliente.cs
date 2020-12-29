using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.DIP.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public CPF Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}
