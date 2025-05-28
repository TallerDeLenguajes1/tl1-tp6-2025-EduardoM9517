[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

### Ejercicio 4
##### ¿String es una tipo por valor o un tipo por referencia?
**String** (en la mayoría de los lenguajes de programación) es un tipo de referencia, no un tipo de valor. Esto significa que las variables String no almacenan los caracteres directamente, sino que almacenan una referencia a un objeto en memoria que contiene los caracteres. 
Cuando se asigna un String a una variable, se crea una referencia al objeto que contiene la cadena de texto, no una copia de la cadena.

##### ¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape son caracteres especiales dentro de una cadena que, cuando interpretados, modifican el significado de la cadena. Algunas secuencias de escape en el tipo string (cadena de caracteres) son:
- \\:Representa una barra invertida.
- \\0:Representa caracter nulo.
- \\b:Mueve el cursor una posición hacia atrás.
- \\n:Avance de linea.
- \\t:Avance de tabulacion.

##### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
En C#, los caracteres @ y $ antes de una cadena de texto (literal) tienen significados específicos. El carácter @ indica que la cadena es un "literal textual", lo que significa que las secuencias de escape (como \n para un nuevo salto de línea) se interpretan literalmente en lugar de ser procesadas. El carácter $ indica que la cadena es una "cadena interpolada", lo que permite insertar expresiones directamente dentro de la cadena. Combinar @ y $ ($@ o @$) permite ambas características: literal textual y interpolación.