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
}