using System;

Console.WriteLine("Por favor ingrese el año");
int anoIngresado = int.Parse(Console.ReadLine());



for (int mes = 1; mes <= 12; mes++) 
{
    DateTime fecha = new DateTime(anoIngresado, mes, 1);
    Console.WriteLine("El primer dia de " + fecha.ToString("MMMM") + " es el: " + fecha.ToString("dddd"));
}

String respuesta;

do
{
    Console.WriteLine("\nEscriba el número del mes que desea consultar:");
    int mesSeleccionado = int.Parse(Console.ReadLine());
    DateTime fecha = new DateTime(anoIngresado, mesSeleccionado, 1);

    Console.WriteLine("\nLos fines de semana en el mes seleccionado son:");

    //DateTime.DaysInMonth --> Metodo para obtener numero de dias en un mes
    for (int dia = 1; dia <= DateTime.DaysInMonth(anoIngresado, mesSeleccionado); dia++)
    {
        fecha = new DateTime(anoIngresado, mesSeleccionado, dia);

        //DayOfWeek --> Para saber en que dia cae, lo comparo con los fines y si coincide escribo el mensaje
        if (fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday)
        {
            Console.WriteLine("El " + dia + " es " + fecha.ToString("dddd"));
        }
    }

    Console.WriteLine("\n¿Quiere continuar con otros dos números?");
    respuesta = Console.ReadLine();

} while (respuesta == "Si" || respuesta == "si" || respuesta == "SI");
{
    Console.WriteLine("MUCHAS GRACIAS POR USAR EL PROGRAMA!!");
}
