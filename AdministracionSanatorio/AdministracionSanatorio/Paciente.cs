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
        public List<Intervencion> operaciones { get; set; } = new List<Intervencion>();
        public Paciente(string DNI, string nombreCompleto, string telefono, string nombreObra = null, int cobertura = 0)
        {
            this.DNI = DNI;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.nombreObra = nombreObra;
            this.cobertura = cobertura;
        }

        public void nuevaOperacion(Intervencion op)
        {
            operaciones.Add(op);
        }

        public double costoOperacion()
        {
            double gasto = 0;
            foreach (Intervencion intervencion in operaciones)
            {
                gasto += intervencion.costo();
            }
            return gasto;
        }
    }
}
