using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ConsoleApp.LSP.Violacao
{
    public class Quadrado : Retangulo
    {
        public override double Altura
        {
            set { base.Altura = base.Largura = value; }
        }

        public override double Largura
        {
            set { base.Altura = base.Largura = value; }
        }
    }
}
