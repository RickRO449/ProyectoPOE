using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.Repositorio
{
    public interface ICandidataRepository
    {
        void Agregar(Candidata candidata);
        Candidata ObtenerPorId(int id);
        List<Candidata> ObtenerTodas();
        void Actualizar(Candidata candidata);
        void Eliminar(int id);
    }
}
