using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Aluno
    {
        public String nome { get; set; }
        public String matricula { get; set; }
        public DateTime nascimento { get; set; }


        public List<Prova> Provas { get; set; } = new List<Prova>();
    }
}
