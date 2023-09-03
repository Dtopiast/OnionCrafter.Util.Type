# OnionCrafter.Utils.Type

![Versión de la librería](https://img.shields.io/badge/Versi%C3%B3n-1.0.0-brightgreen) [![NuGet](https://img.shields.io/nuget/v/OnionCrafter.Util.Type.svg)](https://www.nuget.org/packages/OnionCrafter.Util.Type/)

![](https://raw.githubusercontent.com/Dtopiast/OnionCrafter.Util.Type/main/Images/Logo.png)

**Estado de la Librería: Pre-Alfa - No Listo para Producción**

Esta librería se encuentra actualmente en un estado pre-alfa, lo que significa que está en una fase muy temprana de desarrollo y no está destinada para su uso en entornos de producción. Estamos trabajando arduamente para mejorar y estabilizar la librería, pero aún pueden existir errores y limitaciones significativas.

Si estás interesado en utilizar esta librería, te recomendamos encarecidamente que la pruebes en un entorno de desarrollo o pruebas para evaluar su idoneidad para tu proyecto. No se garantiza la estabilidad ni la compatibilidad con versiones futuras en este estado inicial.

Por favor, mantente atento a futuras actualizaciones y anuncios sobre el progreso de la librería. Tu retroalimentación y contribuciones son bienvenidas a medida que avanzamos hacia una versión más estable y lista para producción.

## Descripción

La librería OnionCrafter.Util.Type proporciona una colección de métodos de extensión para validar tipos en aplicaciones .NET. Esta librería está diseñada para simplificar la validación de tipos y garantizar la seguridad de tipos en tu código.

## Características

- Validación de tipos de manera sencilla y eficiente.
- Verificación de si un tipo es una subclase válida de otro tipo especificado.
- Ayuda a mantener la integridad de tipos en tu código .NET.

## Requisitos

- .NET 7

## Instalación

Puedes agregar esta librería a tu proyecto .NET 7 a través de NuGet. Usa el siguiente comando de NuGet para instalarla:

```bash
dotnet add package OnionCrafter.Util.Type
```

## Uso
A continuación, se muestra un ejemplo básico de cómo utilizar la librería para validar tipos:

```csharp
using OnionCrafter.Util.Type;

// ...

Type myType = typeof(MiClase);
Type baseType = typeof(ClaseBase);

myType.EnsureValidImplement(baseType); // Lanza una excepción si myType no es una subclase válida de baseType.
```

Para obtener ejemplos detallados sobre cómo utilizar esta librería, consulta la [documentación](https://github.com/Dtopiast/OnionCrafter.Util.Type/wiki).


## Contribuir

Si deseas contribuir a esta librería, ¡te damos la bienvenida! Puedes hacerlo de las siguientes maneras:

1. **Informa problemas:** Si encuentras algún problema o error, por favor, abre un [issue](https://github.com/dtopiast/OnionCrafter.Utils.Type/issues).

2. **Envía Pull Requests:** Si deseas agregar nuevas características o corregir errores existentes, no dudes en enviar un [pull request](https://github.com/dtopiast/OnionCrafter.Utils.Type/pulls).

## Licencia

Este proyecto está bajo la [Licencia Mozilla Public v. 2](LICENSE.txt). Consulta el archivo LICENSE.md para obtener más información.
