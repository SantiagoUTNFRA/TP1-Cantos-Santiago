namespace Firestore
{
    public class GestorFirestore<T> : GestorFirestoreBase, IRepository<T> where T : class
    {
        public GestorFirestore(string nombreColeccion) : base(nombreColeccion)
        {
        }

        public async Task Actualizar(T entidad, string id) => await ActualizarEntidadAsync(entidad, id);
         
        public async Task Crear(T entidad, string id) => await CrearEntidadAsync(entidad, id);

        public async Task Eliminar(string id) => await EliminarEntidadAsync(id);

        public async Task<T> Obtener(string id) => await ObtenerEntidadAsync<T>(id);

        public async Task<List<T>> ObtenerTodos() => await ObtenerTodasLasEntidadesAsync<T>();

        public async Task<List<T>> ObtenerPorCampoValorAsync(string campo, string valor)
        {
            return await ObtenerPorCampoValorAsync<T>(campo, valor);
        }
    }
}
