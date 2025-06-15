using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public class IntervencionAsignada
    {
        public DateTime fecha;
        public Doctor medico;
        public bool pagado;
        public Intervencion intervencion;

        public IntervencionAsignada(Intervencion intervencion, Doctor medico, DateTime fecha, bool pagado = false)
        {
            this.intervencion = intervencion;
            this.medico = medico;
            this.pagado = pagado;
            this.fecha = fecha;
        } 
    }

    public class Paciente
    {
        public float cobertura;
        public string nombreCompleto, nombreObra, DNI, telefono;
        public List<IntervencionAsignada> operaciones { get; set; } = new List<IntervencionAsignada>();
        public Paciente(string DNI, string nombreCompleto, string telefono, string nombreObra = "-", float cobertura = 0)
        {
            this.DNI = DNI;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.nombreObra = nombreObra;
            this.cobertura = cobertura;
        }  
    }
}
