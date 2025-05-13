using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    class Paciente
    {
        public int DNI, telefono;
        public string nombreCompleto;
        public Intervencion[] operaciones;

        public Paciente(int DNI, string nombreCompleto, int telefono, Intervencion[] operaciones)
        {
            this.DNI = DNI;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.operaciones = operaciones;
        }
    }
}
