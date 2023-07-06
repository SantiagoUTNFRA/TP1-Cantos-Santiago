using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firestore
{
    public interface IRepository<T> where T : class
    {
        Task Crear(T entidad, string id);
        Task<T> Obtener(string id);
        Task<List<T>> ObtenerTodos();
        Task Actualizar(T entidad, string id);
        Task Eliminar(string id);
        Task<List<T>> ObtenerPorCampoValorAsync(string campo, string valor);
    }
}
