using System;

int i = 0;

Console.WriteLine("----------------------------------------");
Console.WriteLine("Programa usando FOR");
Console.WriteLine("----------------------------------------");
for (i=0; i < 101; i++)
{
    Console.WriteLine(i);  
}


Console.WriteLine("----------------------------------------");
Console.WriteLine("Programa usando WHILE");
Console.WriteLine("----------------------------------------");
i = 0;
while (i<=100)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("----------------------------------------");
Console.WriteLine("Programa usando Do WHILE");
Console.WriteLine("----------------------------------------");
i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 101); {
    Console.WriteLine("Programa finalizado");
}