using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.Repositorio
{
    public interface IEstudianteRepository
    {
        void Agregar(Estudiante estudiante);
        Estudiante ObtenerPorId(int id);
        Estudiante ObtenerPorMatricula(string matricula);
        List<Estudiante> ObtenerTodos();
        void Actualizar(Estudiante estudiante);
        void Eliminar(int id);
    }
}
