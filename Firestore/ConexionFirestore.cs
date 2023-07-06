using Google.Cloud.Firestore;

namespace Firestore
{
    public class ConexionFirestore
    {
        private static FirestoreDb _firestoreDB;

        public static FirestoreDb ObtenerInstanciaFirestore()
        {
            if (_firestoreDB == null)
            {
                string path = $"{AppDomain.CurrentDomain.BaseDirectory}primerparcial-c98f3-firebase-adminsdk-akv8h-367dc4fbf0.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                string projectId = "primerparcial-c98f3";
                _firestoreDB = FirestoreDb.Create(projectId);
            }
            return _firestoreDB;
        }
    }
}