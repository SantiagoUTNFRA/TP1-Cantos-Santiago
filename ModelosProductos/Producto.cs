namespace Modelos_Productos
{
    public class Producto
    {
        private int _id;
        private string _nombre;
        private double _precio;
        private int _stock;
        private string _categoria;
        private string _imageUri;

        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public double Precio { get { return _precio; } set { _precio = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
        public string Categoria { get { return _categoria; } set { _categoria = value; } }
        public string ImageUri { get { return _imageUri; } set { _imageUri = value; } }
    }
}
