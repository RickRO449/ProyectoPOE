using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo
{
    public class Administrador : Persona
    {
        public string Usuario { get; set; }
        public string Password { get; set; }

        public Administrador(int id, string nombre, string apellido, DateTime fechaNacimiento, string usuario, string password)
            : base(id, nombre, apellido, fechaNacimiento)
        {
            Usuario = usuario;
            Password = password;
        }

        public void RegistrarCandidata(List<Candidata> candidatas, Candidata candidata)
        {
            candidatas.Add(candidata);
        }

        public List<Candidata> GenerarResultados(List<Candidata> candidatas, TipoVoto tipo)
        {
            return candidatas.OrderByDescending(c => c.ObtenerTotalVotos(tipo)).ToList();
        }
    }
}
