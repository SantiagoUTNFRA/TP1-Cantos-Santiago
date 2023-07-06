using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace Firestore
{
    public abstract class GestorFirestoreBase
    {
        private readonly FirestoreDb _firestoreDb;
        protected readonly CollectionReference _coleccion;

        /// <summary>
        /// Crea una nueva entidad en la base de datos Firestore.
        /// </summary>
        /// <param name="entidad">Entidad a crear.</param>
        /// <param name="docId">Id del documento a crear.</param>
        /// <returns>True si la entidad se creó correctamente, false en caso contrario.</returns>
        protected async Task<bool> CrearEntidadAsync<T>(T entidad, string? docId = null)
        {
            await CrearDocumentoAsync(entidad, docId);
            return true;
        }

        /// <summary>
        /// Obtiene una entidad de la base de datos Firestore por su id.
        /// </summary>
        /// <typeparam name="T">Tipo de entidad a obtener.</typeparam>
        /// <param name="id">Id de la entidad a obtener.</param>
        /// <returns>La entidad solicitada.</returns>
        protected async Task<T> ObtenerEntidadAsync<T>(string id) where T : class
        {
            var docSnapshot = await ObtenerDocumentoAsync(id);
            if (docSnapshot.Exists)
            {
                return docSnapshot.ConvertTo<T>();
            }
            else
            {
                return null!;
            }
        }

        /// <summary>
        /// Obtiene todas las entidades de un tipo específico de la base de datos Firestore.
        /// </summary>
        /// <typeparam name="T">Tipo de entidad a obtener.</typeparam>
        /// <returns>Lista de entidades solicitadas.</returns>
        protected virtual async Task<List<T>> ObtenerTodasLasEntidadesAsync<T>()
        {
            var entidadesSnapshot = await _coleccion.GetSnapshotAsync();
            var listaEntidades = new List<T>();

            foreach (var entidad in entidadesSnapshot)
            {
                var entidadDict = entidad.ToDictionary();
                var json = JsonConvert.SerializeObject(entidadDict);
                var entidadObj = JsonConvert.DeserializeObject<T>(json);
                listaEntidades.Add(entidadObj!);
            }

            return listaEntidades;
        }

        /// <summary>
        /// Actualiza una entidad en la base de datos Firestore.
        /// </summary>
        /// <typeparam name="T">Tipo de entidad a actualizar.</typeparam
        /// <param name="entidad">Entidad a actualizar.</param>
        /// <param name="id">Id de la entidad a actualizar.</param>
        /// <returns>True si la entidad se actualizó correctamente, false en caso contrario.</returns>
        protected virtual async Task<bool> ActualizarEntidadAsync<T>(T entidad, string id)
        {
            if (!await ExisteAsync(id))
            {
                return false;
            }
            await ActualizarDocumentoAsync(id, entidad!);
            return true;
        }

        /// <summary>
        /// Elimina una entidad de la base de datos Firestore.
        /// </summary>
        /// <param name="id">Id de la entidad a eliminar.</param>
        /// <returns>True si la entidad se eliminó correctamente, false en caso contrario.</returns>
        protected virtual async Task<bool> EliminarEntidadAsync(string id)
        {
            if (!await ExisteAsync(id))
            {
                return false;
            }
            await EliminarDocumentoAsync(id);
            return true;
        }

        /// <summary>
        /// Crea un nuevo documento en la base de datos Firestore.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a crear.</typeparam>
        /// <param name="objeto">Objeto a crear.</param>
        /// <param name="docId">Id del documento a crear.</param>
        /// <returns>El id del documento creado.</returns>
        protected async Task<string> CrearDocumentoAsync<T>(T objeto, string? docId = null)
        {
            DocumentReference docRef;

            if (string.IsNullOrEmpty(docId))
            {
                docRef = await _coleccion.AddAsync(objeto);
            }
            else
            {
                docRef = _coleccion.Document(docId);
                await docRef.SetAsync(objeto);
            }

            return docRef.Id;
        }

        /// <summary>
        /// Obtiene un documento de la base de datos Firestore por su id.
        /// </summary>
        /// <param name="id">Id del documento a obtener.</param>
        /// <returns>El documento obtenido.</returns>
        protected async Task<DocumentSnapshot> ObtenerDocumentoAsync(string id)
        {
            var docRef = _coleccion.Document(id);
            return await docRef.GetSnapshotAsync();
        }

        /// <summary>
        /// Actualiza un documento en la base de datos Firestore.
        /// </summary>
        /// <param name="id">Id del documento a actualizar.</param>
        /// <param name="objeto">Objeto a actualizar.</param>
        /// <returns></returns>
        protected async Task ActualizarDocumentoAsync(string id, object objeto)
        {
            var docRef = _coleccion.Document(id);
            await docRef.SetAsync(objeto);
        }

        /// <summary>
        /// Elimina un documento de la base de datos Firestore.
        /// </summary>
        /// <param name="id">Id del documento a eliminar.</param>
        /// <returns></returns>
        protected async Task EliminarDocumentoAsync(string id)
        {
            var docRef = _coleccion.Document(id);
            await docRef.DeleteAsync();
        }

        /// <summary>
        /// Comprueba si un documento existe en la base de datos Firestore.
        /// </summary>
        /// <param name="id">Id del documento a comprobar.</param>
        /// <returns>True si el documento existe, false en caso contrario.</returns>
        public async Task<bool> ExisteAsync(string id)
        {
            var documento = await ObtenerDocumentoAsync(id);
            return documento.Exists;
        }

        /// <summary>
        /// Obtiene documentos de la base de datos Firestore que coinciden con un valor de campo específico.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a obtener.</typeparam>
        /// <param name="campo">Nombre del campo a comprobar.</param>
        /// <param name="valor">Valor del campo a comprobar.</param>
        /// <returns>Lista de objetos obtenidos.</returns>
        protected async Task<List<T>> ObtenerPorCampoValorAsync<T>(string campo, string valor) where T : class
        {
            QuerySnapshot snapshot = await _coleccion.WhereEqualTo(campo, valor).GetSnapshotAsync();
            return snapshot.Documents.Select(document =>
            {
                var diccionario = document.ToDictionary();
                var json = JsonConvert.SerializeObject(diccionario);
                var prod = JsonConvert.DeserializeObject<T>(json);
                return prod;
            }).ToList();
        }
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="nombreColeccion">Valor de la colección a nombrar en firestore</param>
        public GestorFirestoreBase(string nombreColeccion)
        {
            _firestoreDb = ConexionFirestore.ObtenerInstanciaFirestore();
            _coleccion = _firestoreDb.Collection(nombreColeccion);
        }
    }
}
