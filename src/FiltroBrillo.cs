using System;

namespace ExamenUnidad3
{
    public class FiltroBrillo : FiltroDecorator
    {
        public FiltroBrillo(IImagen imagen) : base(imagen) {}

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("→ Aumentando el brillo de la imagen...");
        }
    }
}
