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

        //------ Ejercicio 2 ------
        // string? num1, num2, operador, resultado, flag;
        // do
        // {
        //         Console.WriteLine("------- MENU ------");
        //         Console.WriteLine("1) Sumar");
        //         Console.WriteLine("2) Restar");
        //         Console.WriteLine("3) Multiplicar");
        //         Console.WriteLine("4) Dividir");
        //         Console.Write("Ingrese el numero de operacion: ");
        //         operador = Console.ReadLine();
        //         Console.Write("Ingrese un numero entero: ");
        //         num1 = Console.ReadLine();
        //         Console.Write("Ingrese un numero entero: ");
        //         num2 = Console.ReadLine();
        //         if (num1 != null && num2 != null && operador != null)
        //         {
        //             resultado = calculadora(num1, num2, operador);
        //             Console.WriteLine("Resultado: " + resultado);
        //         }
        //         Console.Write("Desea realizar otro calculo(si=1, no=0): ");
        //         flag = Console.ReadLine();
            
        // } while (flag != "0");


        //------ Ejercicio 3 ------
        // float num1, num2, num3;
        // bool resultado2, resultado3;

        // Console.Write("Ingrese un numero: ");
        // if (float.TryParse(Console.ReadLine(), out num1))
        // {
        //     calculadoraMejorada(num1);
        // }
        // Console.Write("Ingrese un numero: ");
        // resultado2 = float.TryParse(Console.ReadLine(), out num2);
        // Console.Write("Ingrese un numero: ");
        // resultado3 = float.TryParse(Console.ReadLine(), out num3);
        // if(resultado2 && resultado3)
        // {
        //     Console.WriteLine("Numeros: " + num2 + ", " + num3);
        //     Console.WriteLine("Maximo: " + maxNumero(num2, num3));
        //     Console.WriteLine("Minimo: " + minNumero(num2, num3));
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

    public static string sumar(string a, string b)
    {
        int suma;
        suma = int.Parse(a) + int.Parse(b);
        return suma.ToString();
    }

    public static string restar(string a, string b)
    {
        int resta;
        resta = int.Parse(a) - int.Parse(b);
        return resta.ToString();
    }
    
    public static string multiplicar(string a, string b)
    {
        int producto;
        producto = int.Parse(a) * int.Parse(b);
        return producto.ToString();
    }

    public static string dividir(string a, string b)
    {
        int resultado;
        resultado = int.Parse(a) / int.Parse(b);
        return resultado.ToString();
    }

    public static string calculadora(string num1, string num2, string operador)
    {
        switch (operador)
        {
            case "1":
                return sumar(num1, num2);
            case "2":
                return restar(num1, num2);
            case "3":
                return multiplicar(num1, num2);
            case "4":
                return dividir(num1, num2);
            default:
                return "ERROR: opcion ingresada incorrecta";
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