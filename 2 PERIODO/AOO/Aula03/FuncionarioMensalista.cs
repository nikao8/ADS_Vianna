using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03
{
    public class FuncionarioMensalista : Funcionario
    {
        public double ValorMensal { get; set; }

        public override double GetSalario()
        {
            return ValorMensal;
        }
    }
}