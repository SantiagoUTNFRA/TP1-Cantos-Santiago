using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace Firestore
{
    public abstract class GestorFirestoreBase
    {
        private readonly FirestoreDb _firestoreDb;
        protected readonly CollectionReference _coleccion;

        public GestorFirestoreBase(string nombreColeccion)
        {
            _firestoreDb = ConexionFirestore.ObtenerInstanciaFirestore();
            _coleccion = _firestoreDb.Collection(nombreColeccion);
        }

        protected async Task<bool> CrearEntidadAsync<T>(T entidad, string? docId = null)
        {
            await CrearDocumentoAsync(entidad, docId);
            return true;
        }

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

        protected virtual async Task<bool> ActualizarEntidadAsync<T>(T entidad, string id)
        {
            if (!await ExisteAsync(id))
            {
                return false;
            }
            await ActualizarDocumentoAsync(id, entidad!);
            return true;
        }

        protected virtual async Task<bool> EliminarEntidadAsync(string id)
        {
            if (!await ExisteAsync(id))
            {
                return false;
            }
            await EliminarDocumentoAsync(id);
            return true;
        }

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

        protected async Task<DocumentSnapshot> ObtenerDocumentoAsync(string id)
        {
            var docRef = _coleccion.Document(id);
            return await docRef.GetSnapshotAsync();
        }


        protected async Task ActualizarDocumentoAsync(string id, object objeto)
        {
            var docRef = _coleccion.Document(id);
            await docRef.SetAsync(objeto);
        }

        protected async Task EliminarDocumentoAsync(string id)
        {
            var docRef = _coleccion.Document(id);
            await docRef.DeleteAsync();
        }

        public async Task<bool> ExisteAsync(string id)
        {
            var documento = await ObtenerDocumentoAsync(id);
            return documento.Exists;
        }

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



    }
}
