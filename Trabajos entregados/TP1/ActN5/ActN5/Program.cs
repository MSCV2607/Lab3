using System;

int sueldoXHora = 3000;
int sueldoDesarollo = 0;

DateTime fecha = new DateTime(2022, 4, 8);

for (int dia = 8; dia < 22; dia++)
{
    if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
    {
        sueldoDesarollo += sueldoXHora * 4; // 4 horas por día
    }
    //fecha.AddDays(1) --> Se agrega un dia mas
    fecha = fecha.AddDays(1);
}

Console.WriteLine("El desarrollo se estima en: $" + sueldoDesarollo);