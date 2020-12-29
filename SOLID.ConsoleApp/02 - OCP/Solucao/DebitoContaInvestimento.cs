﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            return FormatarTransacao();
        }
    }
}
