# Guía de estilo de código.

> [!WARNING]
> Lea y utilice las siguientes convenciones de código para asegurar un código limpio
> y legible.

## Convenciones de nombramiento

Un **idenficador** es un nombre que se le asigna a un tipo 
(clase, interface, estructura, delegado o enum), un miembro, una variable o un namespace. 

### Reglas generales

Los identificadores deben seguir estas reglas. El compilador de C# producirá un error
por cada identificador que no siga estas reglas.

- Los identificadores deben iniciar con una letra o un guión bajo (_).
- Los idenficadores pueden contener únicamente letras, dígitos decimales y carácteres
especificados en el estándar Unicode.

### Convenciones de nombramiento

Por convención, los programas de C# usan `PascalCase` para nombrar tipos, namespaces, y 
todos los miembros públicos. Además:

- Utilice nombres significativos y descriptivos para variables, métodos y clases.
- Prefiera claridad sobre brevedad (no utilice abreviaturas).
- Use `PascalCase` para nombrar clases y métodos.
- Use `camelCase` para nombrar constantes.
- Los nombres de las variables de instancia privadas inician con un guión bajo (_) y
el texto restante utiliza `camelCase`.

Cuando nombre miembros de tipo `public` tales como campos, propiedades, eventos, etc. 
utilice `PascalCase`. Utilícelo también al nombrar métodos y funciones locales.
```cs
public class EventoEjemplo
{
  // Un campo público.
  public bool EsVálido;

  // Una propiedad init-only
  public IWorkerQueue ColaTrabajo { get; init; }

  // Método
  public void IniciarProcesamientoEvento()
  {
    // Función local
    static int ContarElementosEnCola() => ColaTrabajo.Count;
    // ...
  }
}
```
