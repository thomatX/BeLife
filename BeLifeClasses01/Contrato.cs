using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLifeClasses01
{
    class Contrato
    {
        public int NumeroContrato { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime Termino { get; set; }
        public Cliente Titular { get; set; }
        public Plan PlanAsociado { get; set; }
        public int Poliza { get; set; }
        public bool EstaVigente { get; set; }

        public DateTime InicioVigencia
        {
            get
            {
                return Creacion;
            }
            set { }
        }
        public DateTime FinVigencia
        {
            get {
                return Termino;
            }

            set { }
        }


    }
}
