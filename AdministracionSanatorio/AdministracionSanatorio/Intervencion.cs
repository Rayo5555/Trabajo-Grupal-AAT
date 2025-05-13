using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionSanatorio
{
    class Intervencion
    {
        public int codigo;
        public string desc, especialidad;
        public float precio;

        public Intervencion(int codigo, string desc, string especialidad, float precio)
        {
            this.codigo = codigo;
            this.desc = desc;
            this.especialidad = especialidad;
            this.precio= precio;
        }
    }

    class Normal : Intervencion
    {

    }

    class Compleja : Intervencion
    {
        static double adicional = 0.5;
    }
}
