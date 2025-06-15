using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace AdministracionSanatorio
{
    public class Hospital
    {
        public List<Doctor> Doctores { get; set; } = new List<Doctor>();
        public List<Paciente> Pacientes { get; set; } = new List<Paciente>();
        public List<Intervencion> Intervenciones { get; set; } = new List<Intervencion>();

        public Hospital()
        {
            // Doctores
            Doctores.Add(new Doctor("Juan Pérez", "12345", "Cardiología", true));
            Doctores.Add(new Doctor("Laura Gómez", "23456", "Traumatología", false));
            Doctores.Add(new Doctor("Carlos Ruiz", "34567", "Neurología", true));
            Doctores.Add(new Doctor("María Silva", "45678", "Gastroenterología", true));
            Doctores.Add(new Doctor("Fernando Torres", "56789", "Cardiología", true));
            Doctores.Add(new Doctor("Cecilia López", "67890", "Traumatología", true));

            // Pacientes
            Pacientes.Add(new Paciente("30111222", "Ana Torres", "1111-2222", "ObraMed", 80));
            Pacientes.Add(new Paciente("29222333", "Luis Fernández", "2222-3333", null, 0));
            Pacientes.Add(new Paciente("28444555", "Clara Méndez", "3333-4444", "SaludPlus", 90));
            Pacientes.Add(new Paciente("27555666", "Pedro Gómez", "4444-5555", "VidaTotal", 70));
            Pacientes.Add(new Paciente("26666777", "Lucía Ortega", "5555-6666", null, 0));
            Pacientes.Add(new Paciente("25777888", "Jorge Ramírez", "6666-7777", "SaludPlus", 60));

            // Intervenciones comunes
            Intervenciones.Add(new IntervencionComun("INT001", "Bypass coronario", "Cardiología", 120000));
            Intervenciones.Add(new IntervencionComun("INT003", "Artroscopía de rodilla", "Traumatología", 80000));
            Intervenciones.Add(new IntervencionComun("INT005", "Endoscopía digestiva", "Gastroenterología", 40000));
            Intervenciones.Add(new IntervencionComun("INT007", "Colocación de stent", "Cardiología", 95000));
            Intervenciones.Add(new IntervencionComun("INT008", "Reducción de fractura", "Traumatología", 60000));

            // Intervenciones de alta complejidad
            Intervenciones.Add(new IntervencionAltaComplejidad("INT002", "Neurocirugía", "Neurología", 200000, 0.2));
            Intervenciones.Add(new IntervencionAltaComplejidad("INT004", "Revascularización miocárdica", "Cardiología", 250000, 0.25));
            Intervenciones.Add(new IntervencionAltaComplejidad("INT006", "Cirugía de columna", "Traumatología", 180000, 0.15));
            Intervenciones.Add(new IntervencionAltaComplejidad("INT009", "Cirugía bariátrica", "Gastroenterología", 220000, 0.3));
            Intervenciones.Add(new IntervencionAltaComplejidad("INT010", "Craneotomía", "Neurología", 270000, 0.2));
        }

        public void darDeAlta(string DNI, string nombreCompleto, string telefono, string nombreObra, int cobertura)
        {
            Pacientes.Add(new Paciente(DNI, nombreCompleto, telefono, nombreObra, cobertura));
        }

        public void listarPacientes()
        {
            foreach (Paciente paciente in Pacientes)
            {
                Console.WriteLine(paciente.nombreCompleto);
            }
        }

        public void asignarIntervencion(string DNI)
        {
            Paciente pacienteEncontrado = null;
            foreach (Paciente paciente in Pacientes)
            {
                if (DNI == paciente.DNI)
                {
                    pacienteEncontrado = paciente;
                    break;
                }
            }
            if (pacienteEncontrado == null)
            {
                Console.WriteLine("No se encontro el DNI en el sistema");
                return;
            }

            Console.WriteLine("Operaciones disponibles");
            foreach (Intervencion intervencion in Intervenciones)
            {
                Console.WriteLine("Codigo: " + intervencion.codigo + " Descripcion: " + intervencion.desc);
            }
            Intervencion intervencionAsignada = null;
            Doctor doctorAsignado = null;
            bool pagado = false;
            DateTime fechaIntervencion = DateTime.MinValue;
            while (intervencionAsignada == null)
            {
                Console.WriteLine("Ingrese un codigo: ");
                string code = Console.ReadLine();
                foreach (Intervencion intervencion in Intervenciones)
                {
                    if (code == intervencion.codigo)
                    {
                        intervencionAsignada = intervencion;
                        Console.WriteLine("Ingrese la fecha (formato DD/MM/YYYY): ");
                        string fecha = Console.ReadLine();
                        fechaIntervencion = DateTime.Parse(fecha);
                        Console.WriteLine("Esta abonado (si/no): ");
                        string condicionPago = Console.ReadLine();
                        if (condicionPago == "si")
                        {
                            pagado = true;
                        }
                        Console.WriteLine("Ingrese el nombre del medico: ");
                        while (doctorAsignado == null)
                        {
                            string nombre = Console.ReadLine();
                            foreach (Doctor doctor in Doctores)
                            {
                                if (nombre == doctor.nombreCompleto && doctor.especialidad == intervencionAsignada.especialidad)
                                {
                                    doctorAsignado = doctor;
                                    break;
                                }
                            }
                            Console.WriteLine("Medico no encontrado o no especializado en ese área, por favor ingrese otro: ");
                        }
                        break;
                    }
                }
                if (intervencionAsignada == null)
                {
                    Console.WriteLine("no se encontro el codigo ");
                }
            }

            IntervencionAsignada nuevaIntervencion = new IntervencionAsignada(
                intervencion: intervencionAsignada,
                medico: doctorAsignado,
                fecha: fechaIntervencion,
                pagado: pagado
            );

            pacienteEncontrado.operaciones.Add(nuevaIntervencion);
            Console.WriteLine("Intervención asignada correctamente");
        }
        public void liquidacionPaciente()
        {
            foreach (Paciente paciente in Pacientes)
            {
                foreach (IntervencionAsignada intervencionAsignada in paciente.operaciones)
                {
                    if (intervencionAsignada.pagado == false)
                    {
                        double monto = intervencionAsignada.intervencion.costo() - paciente.cobertura;
                        Console.WriteLine("Identificador: " + paciente.DNI + " Nombre Completo: " + paciente.nombreCompleto + " Fecha: " + intervencionAsignada.fecha + " Descripcion: " + intervencionAsignada.intervencion.desc);
                        Console.WriteLine("Nombre del dotor: " + intervencionAsignada.medico.nombreCompleto + " Matrícula: " + intervencionAsignada.medico.matricula + " Monto a abonar: " + monto + " Obra social: " + paciente.nombreObra);
                    }
                }
            }
        }
    }

}
