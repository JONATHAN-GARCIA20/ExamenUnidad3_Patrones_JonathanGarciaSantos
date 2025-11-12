using System;

namespace ExamenUnidad3
{
    public class FormatoJPG : IFormatoGuardado
    {
        public void Guardar(string nombreArchivo)
        {
            Console.WriteLine($"Guardando la imagen '{nombreArchivo}.jpg' en formato JPG.");
        }
    }
}
