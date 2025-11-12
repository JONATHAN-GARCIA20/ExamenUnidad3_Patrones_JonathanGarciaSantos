using System;

namespace ExamenUnidad3
{
    public class FormatoPNG : IFormatoGuardado
    {
        public void Guardar(string nombreArchivo)
        {
            Console.WriteLine($"Guardando la imagen '{nombreArchivo}.png' en formato PNG.");
        }
    }
}
