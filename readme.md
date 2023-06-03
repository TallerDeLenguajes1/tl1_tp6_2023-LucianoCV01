# Ejercicio 4
- ¿String es una tipo por valor o un tipo por referencia?
String es un tipo por referencia, ósea que cuando asignas una cadena a una variable, en realidad estás almacenando una referencia a esa cadena en la memoria, en lugar de los propios datos de la cadena.
- ¿Qué secuencias de escape tiene el tipo string?
Secuencias de escape: 
    - \'	Comilla simple
    - \"	Comilla doble	
    - \\	Barra diagonal inversa	
    - \0	Null	
    - \a	Alerta	 
    - \b	Retroceso	
    - \f	Avance de página	
    - \n	Nueva línea	 
    - \r	Retorno de carro
- ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Cuando se utiliza el carácter "@" antes de una cadena de texto, la cadena se interpreta tal como está escrita, sin procesar secuencias de escape. 
Por otro lado, cuando se utiliza el carácter "$" antes de una cadena de texto, este permite la incrustación de expresiones dentro de la cadena utilizando la sintaxis ${expresión}.