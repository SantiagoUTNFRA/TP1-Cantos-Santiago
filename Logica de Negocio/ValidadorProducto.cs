using Entidades;

namespace Logica_de_Negocio
{
    public static class ValidadorProducto
    {
        public static void Validar(Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto), "El producto no puede ser nulo.");
            }

            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                throw new ArgumentException("El producto debe tener un nombre.");
            }

            if (producto.Precio <= 0)
            {
                throw new ArgumentException("El precio del producto debe ser mayor que cero.");
            }

        }
    }

}
