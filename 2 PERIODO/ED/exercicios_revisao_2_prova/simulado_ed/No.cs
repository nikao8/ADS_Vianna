using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulado_ed {

    public class No {
        public int Valor {get; set;}
        
        public No? Proximo { get; set; } = null;

        public No? Anterior {get; set; } = null;
    }
}