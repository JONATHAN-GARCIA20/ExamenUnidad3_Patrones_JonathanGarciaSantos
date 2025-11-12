using System;

namespace ExamenUnidad3
{
    public class FiltroBlancoNegro : FiltroDecorator
    {
        public FiltroBlancoNegro(IImagen imagen) : base(imagen) {}

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("→ Aplicando filtro Blanco y Negro...");
        }
    }
}
