using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string? cadena;
        do
        {
            Console.Write("Ingrese una cadena: ");
            cadena = Console.ReadLine();
        } while (cadena == null);

        if (EsDireccionWeb(cadena))
        {
            Console.WriteLine("Es una direccion web");
        } else
        {
            if (Esmail(cadena))
            {
                Console.WriteLine("Es un mail");
            } else
            {
                Console.WriteLine("No es ninguno");
            }
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
    public static bool EsDireccionWeb(string cadena)
    {
        string expresionRegular = @"^(https?://)?(w{3}.)?[a-zA-Z0-9.-]+.(com|com.ar)$";
        return Regex.IsMatch(cadena, expresionRegular);
    }
    public static bool Esmail(string cadena)
    {
        string expresionRegular = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$";
        return Regex.IsMatch(cadena, expresionRegular);
    }
}