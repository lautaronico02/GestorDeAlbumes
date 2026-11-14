using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProductos.Repository
{
    public interface IRepository<T> where T : IEntidad
    {
        void Agregar(T entidad);
        List<T> ObtenerTodos();
        void Eliminar(int id);
        void Modificar(T entidad);
    }
}
