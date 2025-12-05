using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo
{
    public abstract class Persona
    {
        public int Id { get; protected set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";
        public DateTime FechaNacimiento { get; set; }

        public Persona(int id, string nombre, string apellido, DateTime fechaNacimiento)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public virtual string ObtenerNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public int CalcularEdad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }
    }
}
