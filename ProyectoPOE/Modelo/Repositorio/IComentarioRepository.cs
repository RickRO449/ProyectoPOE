using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.Repositorio
{
    public interface IComentarioRepository
    {
        void Agregar(Comentario comentario);
        Comentario ObtenerPorId(int id);
        List<Comentario> ObtenerPorFoto(int fotoId);
        void Actualizar(Comentario comentario);
        void Eliminar(int id);
    }
}
