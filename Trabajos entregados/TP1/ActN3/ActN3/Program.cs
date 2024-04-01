using System;

//Obtener la fecha
DateTime fechaActual = DateTime.Now;
Console.WriteLine("Hoy es: " + fechaActual.ToString("dddd, dd/MM/yyyy \n"));

//Obtener componente de la fecha 
int dia = fechaActual.Day;
int mes = fechaActual.Month;
int ano = fechaActual.Year;

Console.WriteLine("Por favor ingrese el mes: ");
// Escanear la entrada del usuario para el mes
int mesIngresado = int.Parse(Console.ReadLine());

Console.WriteLine("Por favor ingrese el año: ");
// Escanear la entrada del usuario para el año
int anoIngresado = int.Parse(Console.ReadLine());

DateTime otraFecha = new DateTime(anoIngresado, mesIngresado, 1);

if (otraFecha <  fechaActual)
{
    Console.WriteLine("\nEl primer dia de ese mes fue el: " + otraFecha.ToString("dddd"));
} else
{
    Console.WriteLine("\nEl primer dia de ese mes sera el: " + otraFecha.ToString("dddd"));
}

