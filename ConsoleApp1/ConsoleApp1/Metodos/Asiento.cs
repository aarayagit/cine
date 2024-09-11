using Cinema.Enums;

namespace Cinema.Metodos
{
    public class Asiento
    {
        public char Letra { get;private set; }
        public int Numero { get; private set; }
        public TipoAsiento TipoAsiento { get; private set; }
        public bool IsOcupado { get; private set; }=false;
        public Asiento(char letra, int numro,TipoAsiento tipoAsiento)
        { 
            Letra= letra;
            Numero= numro;
            TipoAsiento = tipoAsiento;
        }
        public void CambiarOcupado()
        {
            IsOcupado = !IsOcupado;
        }
    }
}
