using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaFutbol
{
    public class Alumnos
    {
        public int AlumnoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }
        public int? CategoriaID { get; set; }
        public int? PuestoPrincipalID { get; set; }
        public int? PuestoEspecificoID { get; set; }

        public Alumnos(int alumnoID, string nombre, string apellido, string dNI, DateTime fechaNacimiento, bool activo, int categoriaID, int puestoPrincipalID, int puestoEspecificoID)
        {
            AlumnoID = alumnoID;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            FechaNacimiento = fechaNacimiento;
            Activo = activo;
            CategoriaID = categoriaID;
            PuestoPrincipalID = puestoPrincipalID;
            PuestoEspecificoID = puestoEspecificoID;
        }

        public Alumnos()
        {
        }
    }
}
