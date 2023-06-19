# Ejercicio 5
- ¿Funcionan únicamente en C#?
Las expresiones regulares no están limitadas exclusivamente a C#, sino que son utilizadas en muchos lenguajes de programación y herramientas de procesamiento de texto. C# incluye soporte nativo para expresiones regulares a través del namespace System.Text.RegularExpressions.
- ¿En qué casos le parecen útiles? Enuncie al menos 3.
Algunos casos en los que las expresiones regulares son útiles incluyen:
    - Validación de entrada: Las expresiones regulares pueden utilizarse para validar si una cadena de texto cumple con cierto formato o patrón específico. Por ejemplo, validar un correo electrónico, un número de teléfono o una dirección IP.
    - Búsqueda y reemplazo de texto: Las expresiones regulares permiten buscar y reemplazar patrones específicos de texto en una cadena. Puedes realizar tareas como buscar todas las coincidencias de una palabra clave en un documento o reemplazar ciertos caracteres con otros.
    - Extracción de información: Las expresiones regulares pueden utilizarse para extraer información específica de una cadena de texto. Por ejemplo, extraer todos los números de una cadena o extraer los nombres de usuario de una lista de correos electrónicos.
- ¿Cómo se hace uso de estas en C#?
En C#, se utiliza la clase Regex del namespace System.Text.RegularExpressions para trabajar con expresiones regulares. Esta clase proporciona métodos para compilar y ejecutar expresiones regulares, buscar coincidencias en cadenas de texto, realizar reemplazos y más.