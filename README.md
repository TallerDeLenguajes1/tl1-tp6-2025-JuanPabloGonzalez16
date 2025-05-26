[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)
string es un tipo por referencia, pero se comporta como si fuera inmutable.
Eso significa que cuando modificás un string, no se cambia el original, sino que se crea uno nuevo en memoria.
Las secuencias de escape:
\n	Nueva línea
\t	Tabulación (tab)
\"	Comillas dobles
\\	Barra invertida
\r	Retorno de carro
\a	Sonido (beep)
\b	Retroceso (backspace)
@:
Ignora secuencias de escape.

Ideal para rutas de archivos o textos con muchas barras.
$:
Permite incluir variables dentro de una cadena con {}.
@: texto literal (no interpreta \)
$: interpolación (inserta valores)
$@"...": combina ambas