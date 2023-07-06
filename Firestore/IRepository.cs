using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firestore
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Crea una entidad en la base de datos.
        /// </summary>
        /// <param name="entidad">Entidad a crear.</param>
        /// <param name="id">Id de la entidad a crear.</param>
        /// <returns></returns>
        Task Crear(T entidad, string id);

        /// <summary>
        /// Obtiene una entidad específica de la base de datos por su ID.
        /// </summary>
        /// <param name="id">Id de la entidad a obtener.</param>
        /// <returns></returns>
        Task<T> Obtener(string id);

        /// <summary>
        /// Obtiene todas las entidades de la base de datos.
        /// </summary>
        /// <returns></returns>
        Task<List<T>> ObtenerTodos();

        /// <summary>
        /// Actualiza una entidad específica en la base de datos.
        /// </summary> 
        /// <param name="entidad">Entidad a actualizar.</param>
        /// <param name="id">Id de la entidad a actualizar.</param>
        /// <returns></returns>
        Task Actualizar(T entidad, string id);

        /// <summary>
        /// Actualiza una entidad específica en la base de datos.
        /// </summary> 
        /// <param name="id">Id de la entidad a eliminar.</param>
        /// <returns></returns>
        Task Eliminar(string id);

        /// <summary>
        /// Obtiene entidades de la base de datos que coinciden con un valor de campo específico.
        /// </summary>
        /// <param name="campo">Nombre del campo a buscar.</param>
        /// <param name="valor">Valor del campo a buscar.</param>
        /// <returns></returns>
        Task<List<T>> ObtenerPorCampoValorAsync(string campo, string valor);
    }
}
