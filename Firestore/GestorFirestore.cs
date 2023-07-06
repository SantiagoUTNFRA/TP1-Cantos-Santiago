namespace Firestore
{
    public class GestorFirestore<T> : GestorFirestoreBase, IRepository<T> where T : class
    {
        /// <summary>
        /// Actualiza una entidad en la base de datos Firestore.
        /// </summary>
        /// <param name="entidad">Entidad a actualizar.</param>
        /// <param name="id">Id de la entidad a actualizar.</param>
        /// <returns></returns>
        public async Task Actualizar(T entidad, string id) => await ActualizarEntidadAsync(entidad, id);

        /// <summary>
        /// Crea una nueva entidad en la base de datos Firestore.
        /// </summary>
        /// <param name="entidad">Entidad a crear.</param>
        /// <param name="id">Id de la entidad a crear.</param>
        /// <returns></returns>
        public async Task Crear(T entidad, string id) => await CrearEntidadAsync(entidad, id);

        /// <summary>
        /// Elimina una entidad de la base de datos Firestore.
        /// </summary>
        /// <param name="id">Id de la entidad a eliminar.</param>
        /// <returns></returns>
        public async Task Eliminar(string id) => await EliminarEntidadAsync(id);

        /// <summary>
        /// Obtiene una entidad de la base de datos Firestore por su id.
        /// </summary>
        /// <param name="id">Id de la entidad a obtener.</param>
        /// <returns></returns>
        public async Task<T> Obtener(string id) => await ObtenerEntidadAsync<T>(id);

        /// <summary>
        /// Obtiene toda la colección completa de la base de datos Firestore
        /// </summary>
        /// <returns></returns>
        public async Task<List<T>> ObtenerTodos() => await ObtenerTodasLasEntidadesAsync<T>();

        /// <summary>
        /// Obtiene entidades de la base de datos Firestore que coinciden con un valor de campo específico.
        /// </summary>
        /// <param name="campo">Nombre del campo a buscar.</param>
        /// <param name="valor">Valor del campo a buscar.</param>
        /// <returns></returns>
        public async Task<List<T>> ObtenerPorCampoValorAsync(string campo, string valor)
        {
            return await ObtenerPorCampoValorAsync<T>(campo, valor);
        }
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="nombreColeccion"></param>
        public GestorFirestore(string nombreColeccion) : base(nombreColeccion)
        {
        }
    }
}
