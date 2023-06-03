internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //------ Ejercicios Propuestos ------
        //Apartado 6
        // Console.WriteLine("Hello, World!");
        // int a;
        // int b;
        // a=10;
        // b=a;
        // Console.WriteLine("valor de a:"+a);
        // Console.WriteLine("valor de b:"+b);

        //------- Ejercicio 1 ------
        // int num=0;
        // string? entrada, salida;
        // Console.WriteLine("Ingrese un numero: ");
        // entrada = Console.ReadLine();
        // bool resultado = int.TryParse(entrada, out num);
        // if (resultado)
        // {
        //     Console.WriteLine("Numero: " + num);
        //     if (num > 0)
        //     {
        //         salida = invertirNumero(num);
        //         Console.WriteLine("Numero Invertido: " + salida);
        //     }
        // }

        //------ Ejercicio 4 ------
        string? cadena1;
        do
        {
            Console.Write("Ingrese un texto: ");
            cadena1 = Console.ReadLine();
        } while (cadena1 == null);
        // // Obtener la longitud de la cadena y muestre por pantalla.
        // int longitud;
        // longitud = cadena1.Length;
        // Console.WriteLine(cadena1);
        // Console.WriteLine($"Longitud: {longitud}");
        // A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
        string? cadena2;
        do
        {
            Console.Write("Ingrese un texto: ");
            cadena2 = Console.ReadLine();
        } while (cadena2 == null);
        Console.WriteLine(cadena2);
        string cadenasConca = string.Concat(cadena1, " ", cadena2);
        Console.WriteLine(cadenasConca);
        // // Extraer una subcadena de la cadena ingresada.
        // string subcadena = cadena1.Substring(0, 4);
        // Console.WriteLine(subcadena);
        // // Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
        // foreach (var item in subcadena)
        // {
        //     Console.WriteLine(item);
        // }
        // // Buscar la ocurrencia de una palabra determinada en la cadena ingresada
        // int ocurrencia = cadena1.IndexOf(cadena2);
        // Console.WriteLine(cadena1[ocurrencia]);
        // // Convierta la cadena a mayúsculas y luego a minúsculas.
        // cadena1 = cadena1.ToUpper();
        // cadena2 = cadena1.ToLower();
        // Console.WriteLine(cadena1);
        // Console.WriteLine(cadena2);
        // // Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
        // string[] cadenas = cadena1.Split(" ");
        // foreach (var subcadena in cadenas)
        // {
        //     Console.WriteLine(subcadena);
        // }
        

    }
    public static string invertirNumero(int num)
    {
        if (num < 10)
        {
            return num.ToString();
        } else
        {
            return (num%10).ToString() + invertirNumero(num/10);
        }
    }
}
/*
Dada una cadena (un string) de texto ingresada por el usuario, realice las siguientes tarea:

*/