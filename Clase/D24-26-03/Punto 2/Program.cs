//Obtener la fecha
DateTime fechaActual = DateTime.Now;
Console.WriteLine("Hoy es: " + fechaActual.ToString("dddd, dd/MM/yyyy"));

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

Console.WriteLine("El primer dia de ese mes es el: " + otraFecha.ToString("dddd"));

