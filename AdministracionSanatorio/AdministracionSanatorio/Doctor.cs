using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public class Doctor
    {
        public string nombreCompleto, especialidad;
        public string matricula;
        public bool disponible;

        public Doctor(string nombreCompleto, string matricula, string especialidad, bool disponible = true)
        {
            this.nombreCompleto = nombreCompleto;
            this.especialidad = especialidad;
            this.matricula = matricula;
            this.disponible = disponible;
        }

    }
}
