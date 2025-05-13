using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    public class Intervencion
    {
        public string codigo;
        public string desc, especialidad;
        public float precio;
    }

    public class IntervencionComun : Intervencion
    {
        public IntervencionComun(string codigo, string desc, string especialidad, float precio)
        {
            this.codigo = codigo;
            this.desc = desc;
            this.especialidad = especialidad;
            this.precio = precio;
        }
    }

    public class IntervencionAltaComplejidad : Intervencion
    {
        public double adicional;

        public IntervencionAltaComplejidad(string codigo, string desc, string especialidad, float precio, double adicional)
        {
            this.codigo = codigo;
            this.desc = desc;
            this.especialidad = especialidad;
            this.precio = precio;
            this.adicional = adicional;
        }

    }
}
