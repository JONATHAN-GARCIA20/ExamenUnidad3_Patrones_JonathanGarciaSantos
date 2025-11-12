using System;

namespace ExamenUnidad3
{
    public abstract class ImagenProcesada
    {
        protected IFormatoGuardado formato;

        public ImagenProcesada(IFormatoGuardado formato)
        {
            this.formato = formato;
        }

        public abstract void Mostrar();
        public abstract void Guardar(string nombreArchivo);
    }
}
