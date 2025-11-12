# ExamenUnidad3_Patrones_JonathanGarciaSantos
Examen Unidad 3 - Patrones de diseño

**Autor:** Jonathan García Santos  
**Número de Control:** 22210307  
**Proyecto:** Procesador de Imágenes con Filtros y Formatos  
**Materia:** Patrones de Diseño

---

## Descripción General

Este proyecto implementa un **procesador de imágenes por consola**, aplicando los patrones de diseño **Decorator** y **Bridge**.  
El sistema permite al usuario **aplicar o quitar filtros visuales** (como brillo, blanco y negro o difuminado) y **guardar la imagen en distintos formatos** (PNG, JPG o BMP), demostrando flexibilidad, bajo acoplamiento y extensibilidad.

---

## Funcionamiento del Sistema

1. **Inicio del programa**  
   - El usuario inicia el simulador en consola.  
   - Se muestra un menú donde puede seleccionar los filtros que desea aplicar a una imagen base.

2. **Aplicación de filtros (Patrón Decorator)**  
   - Cada filtro funciona como un decorador que rodea a la imagen base sin modificarla.  
   - Los filtros disponibles son:  
     - Blanco y Negro  
     - Brillo  
     - Difuminado  
   - El usuario puede **agregar filtros**, **eliminar el último filtro** o **limpiar todos los filtros**.

3. **Selección de formato (Patrón Bridge)**  
   - Una vez lista la imagen modificada, el usuario elige el formato de guardado:  
     - PNG  
     - JPG  
     - BMP  
   - Gracias al patrón Bridge, el formato puede cambiarse sin afectar la lógica del procesamiento de la imagen.

4. **Guardado e iteración**  
   - El programa simula el guardado de la imagen en el formato elegido.  
   - El usuario puede decidir **procesar otra imagen** o **salir del sistema**.

---

## Patrones Aplicados

### 🔹 Patrón Decorator
- Permite agregar filtros visuales de forma dinámica sin modificar la clase base `ImagenBase`.  
- Cada filtro (`FiltroBlancoNegro`, `FiltroBrillo`, `FiltroDifuminado`) agrega un comportamiento adicional.  
- Facilita la extensión del programa agregando nuevos efectos sin cambiar la estructura original.

### 🔹 Patrón Bridge
- Separa la **abstracción** (`ImagenProcesada`) de la **implementación** (`IFormatoGuardado`).  
- Los formatos (`FormatoPNG`, `FormatoJPG`, `FormatoBMP`) son independientes del procesado.  
- Permite agregar nuevos formatos sin modificar las clases principales.

---

## Ventajas del Diseño

- Modularidad y bajo acoplamiento entre clases.  
- Fácil extensión de nuevos filtros o formatos.  
- Interacción directa con el usuario mediante la consola.  
- Mayor flexibilidad y organización en el código.  
- Uso práctico y claro de dos patrones de diseño profesionales.

---

## Conclusión

En este examen se implementaron los patrones **Decorator** y **Bridge** dentro de un procesador de imágenes.  
El patrón Decorator permitió agregar filtros visuales de forma dinámica, y el patrón Bridge separó el procesamiento de la imagen del formato de guardado.  
Gracias a esta combinación, el sistema es **flexible, modular y fácilmente extensible**, cumpliendo completamente con los objetivos del examen.

---

## Cómo ejecutarlo

Sigue estos pasos para ejecutar el proyecto usando **C# y .NET SDK**.

---

### 🔧 Requisitos

- Visual Studio Code  
- SDK de .NET 6 o superior  
- Extensión oficial de C# instalada  

Verifica tu versión con:
```bash
dotnet --version
