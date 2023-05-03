using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03
{
    public class FuncionarioHorista : Funcionario
    {
        public double ValorHora { get; set; }
        public double QtdeHoras { get; set; }

        public override double GetSalario()
        {
            return QtdeHoras * ValorHora;
        }
    }
}