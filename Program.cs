namespace TrabajoPrimerosPasos
{
    class AreaDeTrabajo
    {
        public static void Main(string[] args)
        {

        }
    }

    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contraseña;
        private string mail;

        public Usuario()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.nombreUsuario = string.Empty;
            this.contraseña = string.Empty;
            this.mail = string.Empty;
        }
    }

    public class Producto
    {
        private int id;
        private string descripcion;
        private double precioCosto;
        private double precioVenta;
        private int enStock;
        private int idUsuario;

        public Producto()
        {
            this.id = 0;
            this.descripcion = string.Empty;
            this.precioCosto = 0;
            this.precioVenta = 0;
            this.enStock = 0;
            this.idUsuario = 0;
        }
    }

    public class ProductoVendido
        
    {
        private int id;
        private int idProducto;
        private int enStock;
        private int idVenta;

        public ProductoVendido()
        {
            this.id = 0;
            this.idProducto = 0;
            this.enStock = 0;
            this.idVenta = 0;
        }
    }

    public class Venta
    {
        private int id;
        private string comentarios;

        public Venta()
        {
            this.id = 0;
            this.comentarios = string.Empty;
        }

    }

}