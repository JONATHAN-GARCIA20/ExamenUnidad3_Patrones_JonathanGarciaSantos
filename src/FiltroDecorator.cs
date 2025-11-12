using System;
namespace ExamenUnidad3
{
   public abstract class FiltroDecorator : IImagen
   {
       protected IImagen _imagen;

       public FiltroDecorator(IImagen imagen)
       {
           _imagen = imagen;
       }

       public virtual void Mostrar()
       {
           _imagen.Mostrar();
       }
   }
}
