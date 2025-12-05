using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.Repositorio
{
    public interface IVotoRepository
    {
        void Registrar(Voto voto);
        Voto ObtenerPorId(int id);
        List<Voto> ObtenerPorCandidata(int candidataId);
        List<Voto> ObtenerPorEstudiante(int estudianteId);
        List<Voto> ObtenerTodos();
    }
}
