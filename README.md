# Árbol Binario de Búsqueda (BST) en C#

## 1. Descripción general
Este repositorio contiene una implementación básica de un **Árbol Binario de Búsqueda (BST)** en **C#**, junto con una interfaz gráfica de usuario (GUI) que permite:

- Insertar valores numéricos.
- Buscar valores.
- Eliminar valores.
- Mostrar recorridos (Inorden, Preorden, Postorden).
- Ver el valor mínimo, máximo y la altura del árbol.
- Visualizar el árbol dibujado en pantalla.

La implementación está pensada como una herramienta educativa para entender cómo funciona un BST y cómo se manipula desde una aplicación de escritorio.

---

## 2. Estructura del repositorio

- `Program.cs` : Contiene la GUI (Windows Forms) y la lógica para dibujar el árbol.
- `ArbolBST.cs` : Implementación del árbol binario de búsqueda (insertar, buscar, eliminar, recorridos, mínimo, máximo, altura).
- `Nodo.cs` : Definición de la clase `Nodo` usada por el árbol.

---

## 3. Cómo ejecutar

### Requisitos
- .NET SDK (recomendado: .NET 6 o superior).

### Instrucciones
1. Abre una terminal en la carpeta del proyecto (`d:\Programa\ArbolBST`).
2. Ejecuta:
   ```bash
   dotnet build
   dotnet run
   ```

La aplicación abrirá una ventana con controles para interactuar con el BST y una zona gráfica donde se dibuja el árbol.

---

## 4. Uso de la interfaz gráfica

En la ventana de la aplicación encontrarás:

- **Caja de texto**: donde ingresas el número.
- **Botones**:
  - `Insertar`: agrega el número al árbol.
  - `Buscar`: indica si el número existe.
  - `Eliminar`: borra el número del árbol.
  - `Inorden`, `Preorden`, `Postorden`: muestran el recorrido en pantalla.
  - `Mínimo`, `Máximo`, `Altura`: muestran valores calculados.
  - `Limpiar`: vacía el árbol y borra el dibujo.

---

## 5. Ejemplos de uso

1. Ingresa `50` y pulsa **Insertar**.
2. Ingresa `30` y pulsa **Insertar**.
3. Pulsa **Inorden** para ver el recorrido ordenado (`30 50`).
4. Pulsa **Eliminar**, ingresa `30` y pulsa **Eliminar**. Pulsa de nuevo **Inorden** para confirmar.

---

## 6. Convenciones de codificación

1. **Nombres claros**: los métodos y variables tienen nombres descriptivos.
2. **Separación por responsabilidad**: la lógica del árbol está en `ArbolBST.cs`, la interfaz en `Program.cs`.
3. **Manejo básico de errores**: la interfaz captura excepciones y muestra mensajes.

---

## 7. Referencias (formato APA)

- Cormen, T. H., Leiserson, C. E., Rivest, R. L., & Stein, C. (2009). *Introduction to Algorithms* (3ª ed.). MIT Press.
- Sedgewick, R., & Wayne, K. (2011). *Algorithms* (4ª ed.). Addison-Wesley.
- Microsoft. (s. f.). *Windows Forms .NET*. https://learn.microsoft.com/dotnet/desktop/winforms/

---

## 8. Cómo contribuir

1. Clona el repositorio.
2. Crea una rama con un nombre descriptivo.
3. Haz los cambios.
4. Haz commit con un mensaje claro.
5. Envía un pull request.

---

### Notas
Este proyecto está diseñado principalmente como ejercicio de aprendizaje y puede adaptarse o ampliarse para incluir más operaciones, balanceo (AVL, Red-Black) o mejor visualización del árbol.
# Implementación de Árbol Binario de Búsqueda (BST) en C#

Este repositorio contiene el desarrollo de una aplicación de consola en C# que implementa un **Árbol Binario de Búsqueda (Binary Search Tree - BST)**.
El programa permite gestionar nodos dentro del árbol, realizando operaciones básicas como inserción, búsqueda y recorridos.

## Información del Autor

**Nombre:** Johnny Vera
**Universidad:** Universidad Estatal Amazónica (UEA)
**Asignatura:** Programación / Estructuras de Datos
**Año:** 2026
**Fecha:** Marzo 2026

## Descripción del Proyecto

El objetivo de este proyecto es aplicar los conceptos fundamentales de estructuras de datos mediante la implementación de un Árbol Binario de Búsqueda en C#.
El sistema permite trabajar con nodos y visualizar el funcionamiento de los recorridos del árbol, fortaleciendo el aprendizaje práctico en programación orientada a objetos.

## Tecnologías utilizadas

* Lenguaje de programación: C#
* Entorno de desarrollo: Visual Studio
* Tipo de aplicación: Consola (.NET)
