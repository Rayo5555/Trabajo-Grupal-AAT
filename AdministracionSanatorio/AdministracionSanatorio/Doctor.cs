using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    class Doctor
    {
        public string nombreCompleto, especialidad;
        public int matricula;
        public bool disponible;

        public Doctor(string nombreCompleto, string especialidad, int matricula, bool disponible = true)
        {
            this.nombreCompleto = nombreCompleto;
            this.especialidad = especialidad;
            this.matricula = matricula;
            this.disponible = disponible;
        }

    }
}
