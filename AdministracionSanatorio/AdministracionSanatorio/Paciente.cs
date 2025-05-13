using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public class Paciente
    {
        public int cobertura;
        public string nombreCompleto, nombreObra, DNI, telefono;
        public Intervencion[] operaciones;
        public Paciente(string DNI, string nombreCompleto, string telefono, string nombreObra = null, int cobertura)
        {
            this.DNI = DNI;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.nombreObra = nombreObra;
            this.cobertura = cobertura;
        }
    }
}
