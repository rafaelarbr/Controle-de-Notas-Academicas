#pragma warning disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nota.Dados
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public int Nota { get; set; }
        public Resultado Resultado { get; set; }
    }
}
