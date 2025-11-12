using System;

namespace ExamenUnidad3
{
    public class FiltroDifuminado : FiltroDecorator
    {
        public FiltroDifuminado(IImagen imagen) : base(imagen) { }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("→ Aplicando filtro Difuminado...");
        }
    }
}
