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

        //------ Ejercicio 3 ------
        float num1, num2, num3;
        bool resultado2, resultado3;

        Console.Write("Ingrese un numero: ");
        if (float.TryParse(Console.ReadLine(), out num1))
        {
            calculadoraMejorada(num1);
        }
        Console.Write("Ingrese un numero: ");
        resultado2 = float.TryParse(Console.ReadLine(), out num2);
        Console.Write("Ingrese un numero: ");
        resultado3 = float.TryParse(Console.ReadLine(), out num3);
        if(resultado2 && resultado3)
        {
            Console.WriteLine("Numeros: " + num2 + ", " + num3);
            Console.WriteLine("Maximo: " + maxNumero(num2, num3));
            Console.WriteLine("Minimo: " + minNumero(num2, num3));
        }

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

    public static float maxNumero(float num1, float num2)
    {
        if (num1 == num2 || num1 > num2)
        {
            return num1;
        } else
        {
            return num2;
        }
    }

    public static float minNumero(float num1, float num2)
    {
        if (num1 == num2 || num1 < num2)
        {
            return num1;
        } else
        {
            return num2;
        }
    }

    public static void calculadoraMejorada(float num)
    {
        Console.WriteLine("Numero: " + num);
        Console.WriteLine("Valor Absoluto: " + Math.Abs(num));
        Console.WriteLine("Cuadradro: " + (float)Math.Pow(num, 2));
        Console.WriteLine("Raiz cuadrada: " + (float)Math.Sqrt(num));
        Console.WriteLine("Seno: " + (float)Math.Sin(num));
        Console.WriteLine("Coseno: " + (float)Math.Cos(num));
        Console.WriteLine("Parte entera de un tipo float: " + (int)num);
    }

}