using System;

namespace ExamenUnidad3
{
    public class ImagenConFiltros : ImagenProcesada
    {
        public ImagenConFiltros(IFormatoGuardado formato) : base(formato) {}

        public override void Mostrar()
        {
            Console.WriteLine("Mostrando imagen con filtros aplicados...");
        }

        public override void Guardar(string nombreArchivo)
        {
            formato.Guardar(nombreArchivo);
        }
    }
}
