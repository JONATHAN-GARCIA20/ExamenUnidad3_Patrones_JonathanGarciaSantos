using System;
using System.Collections.Generic;

namespace ExamenUnidad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string repetir;
            do
            {
                Console.Clear();
                Console.WriteLine("EXAMEN PATRONES: DECORATOR + BRIDGE ");
                Console.WriteLine("\nSimulador de Procesador de Imágenes con Filtros\n");

                IImagen imagenOriginal = new ImagenBase();
                IImagen imagenActual = imagenOriginal;

                // Guardamos los filtros aplicados
                List<string> filtrosAplicados = new List<string>();

                bool continuar = true;
                while (continuar)
                {
                    Console.WriteLine("\nFiltros actuales: " +
                        (filtrosAplicados.Count == 0 ? "ninguno" : string.Join(", ", filtrosAplicados)));

                    Console.WriteLine("\nSeleccione una opción:");
                    Console.WriteLine("1. Aplicar filtro Blanco y Negro");
                    Console.WriteLine("2. Aplicar filtro Brillo");
                    Console.WriteLine("3. Aplicar filtro Difuminado");
                    Console.WriteLine("4. Quitar último filtro");
                    Console.WriteLine("5. Quitar todos los filtros");
                    Console.WriteLine("6. Continuar al guardado");
                    Console.Write("Opción: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            imagenActual = new FiltroBlancoNegro(imagenActual);
                            filtrosAplicados.Add("Blanco y Negro");
                            break;

                        case "2":
                            imagenActual = new FiltroBrillo(imagenActual);
                            filtrosAplicados.Add("Brillo");
                            break;

                        case "3":
                            imagenActual = new FiltroDifuminado(imagenActual);
                            filtrosAplicados.Add("Difuminado");
                            break;

                        case "4": // quitar último
                            if (filtrosAplicados.Count > 0)
                            {
                                filtrosAplicados.RemoveAt(filtrosAplicados.Count - 1);
                                imagenActual = ReaplicarFiltros(imagenOriginal, filtrosAplicados);
                                Console.WriteLine("→ Último filtro eliminado.");
                            }
                            else Console.WriteLine("No hay filtros para quitar.");
                            break;

                        case "5": // quitar todos
                            filtrosAplicados.Clear();
                            imagenActual = imagenOriginal;
                            Console.WriteLine("→ Todos los filtros eliminados.");
                            break;

                        case "6":
                            continuar = false;
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }

                Console.WriteLine("\nProcesando imagen...");
                imagenActual.Mostrar();

                // Selección de formato (Bridge)
                Console.WriteLine("\nSeleccione el formato de guardado:");
                Console.WriteLine("1. PNG");
                Console.WriteLine("2. JPG");
                Console.Write("Opción: ");
                string formatoSeleccionado = Console.ReadLine();

                IFormatoGuardado formato;
                if (formatoSeleccionado == "1")
                    formato = new FormatoPNG();
                else
                    formato = new FormatoJPG();

                Console.Write("\nIngrese el nombre del archivo: ");
                string nombreArchivo = Console.ReadLine();

                ImagenProcesada imgFinal = new ImagenConFiltros(formato);
                imgFinal.Mostrar();
                imgFinal.Guardar(nombreArchivo);

                Console.WriteLine("\n=== PROCESO FINALIZADO ===");
                Console.Write("\n¿Deseas procesar otra imagen? (s/n): ");
                repetir = Console.ReadLine()?.ToLower();

            } while (repetir == "s" || repetir == "si");

            Console.WriteLine("\nGracias por usar el procesador de imágenes. ¡Hasta luego!");
        }

        // 🔧 Método auxiliar para reconstruir los filtros
        static IImagen ReaplicarFiltros(IImagen baseImagen, List<string> filtros)
        {
            IImagen imagen = baseImagen;
            foreach (var filtro in filtros)
            {
                switch (filtro)
                {
                    case "Blanco y Negro": imagen = new FiltroBlancoNegro(imagen); break;
                    case "Brillo": imagen = new FiltroBrillo(imagen); break;
                    case "Difuminado": imagen = new FiltroDifuminado(imagen); break;
                }
            }
            return imagen;
        }
    }
}
