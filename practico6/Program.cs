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