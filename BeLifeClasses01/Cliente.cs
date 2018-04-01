using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLifeClasses01
{
    public class Cliente
    {

        public string Rut { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int EstadoCivil { get; set; }
        public int Sexo { get; set; }

        public Cliente() {
            this.InitClass();
        }

        private void InitClass() {
            this.Rut = String.Empty;
            this.Nombres = String.Empty;
            this.Apellidos = String.Empty;
            this.FechaNacimiento = DateTime.Today;
            this.EstadoCivil = 0;
            this.Sexo = 0;
        }

    }
}
