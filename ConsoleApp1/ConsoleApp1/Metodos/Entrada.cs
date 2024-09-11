using Cinema.Enums;

namespace Cinema.Metodos
{
    public class Entrada
    {
        public Cine Cine { get;private set; }
        public Pelicula Pelicula { get; private set; }
        public Asiento Asiento { get; private set; }
        public DateTime Fecha { get; private set; }
        public double Precio
        {
            get
            {
                double precio = 100;
                if (Asiento.TipoAsiento == TipoAsiento.Superseat)
                {
                    precio += precio * 1.15;
                }
                switch (Pelicula.Formato)
                {
                    case Formato._3d_Subtilada:
                        precio += precio * 1.20;
                        break;
                    case Formato.IMAX_Doblada:
                        precio += precio * 1.40;
                        break;
                }
                return precio;
            }
        }
        public Entrada(Cine cine,Pelicula pelicula,Asiento asiento, DateTime fecha)
        { 
            Cine = cine;
            Pelicula = pelicula;
            Asiento = asiento;
            Fecha = fecha;
        }

    }
}
