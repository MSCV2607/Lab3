//Factorial
using System;

/*
class Programa
{
    static void Main(string[] args)
    {
        int numero;
        int factorial = 1;

        Console.WriteLine("Por favor ingrese un número entero:");
        numero = Convert.ToInt32(Console.ReadLine()); //Para escanear un numero

        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(numero + "! = " + factorial);
    }
}
*/

/*
class Programa
{
    static void Main(string[] args)
    {
        int numero;

        Console.WriteLine("Por favor ingrese un número entero:");
        numero = Convert.ToInt32(Console.ReadLine()); //Para escanear un numero

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número ingresado es par.");
        }
        else
        {
            Console.WriteLine("El número ingresado es impar.");
        }
    }
}
*/

class Programa
{
    static void Main(string[] args)
    {
        int numero;

        Console.WriteLine("Por favor ingrese un número entero:");
        numero = Convert.ToInt32(Console.ReadLine()); //Para escanear un numero

        for (int i = 0; i < numero; i++)
        {
            Console.WriteLine("*\v");
        }
    }
}

/*
 //ASI SE ESCRIBE UN STRING
class Ejemplo
{
   public static void Main(string[] args)
{
    Console.WriteLine("Introduzca un texto");
    String texto;
    texto = Console.ReadLine();
    Console.WriteLine("El texto introducido es: " + texto);
}
}
*/