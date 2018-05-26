using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Prova
    {
        public String materia { get; set; }

        private double _Nota;

        public double Nota
        {
            get
            {
                return _Nota;
            }
            set
            {
                if(value<0|| value>10)
                {
                    throw new ArgumentException("Valor Inválido");
                }
                else
                {
                    _Nota = value;
                }
            }
        }
    }
}
