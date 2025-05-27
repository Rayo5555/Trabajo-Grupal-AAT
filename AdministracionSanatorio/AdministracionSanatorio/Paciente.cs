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
        public string medico;
        public bool pagado;
        public List<Intervencion> listaOperaciones { get; set; } = new List<Intervencion>();

        public IntervencionAsignada(Intervencion listaOperaciones, string medico, DateTime fecha, bool pagado = false)
        {
            this.listaOperaciones.Add(listaOperaciones);
            this.medico = medico;
            this.pagado = pagado;
            this.fecha = fecha;
        } 
    }

    public class Paciente
    {
        public int cobertura;
        public string nombreCompleto, nombreObra, DNI, telefono;
        public List<IntervencionAsignada> operaciones { get; set; } = new List<IntervencionAsignada>();
        public Paciente(string DNI, string nombreCompleto, string telefono, string nombreObra = null, int cobertura = 0)
        {
            this.DNI = DNI;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.nombreObra = nombreObra;
            this.cobertura = cobertura;
        }

        

        
    }
}
