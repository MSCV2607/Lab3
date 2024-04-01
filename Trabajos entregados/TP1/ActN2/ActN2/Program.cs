using System;


Console.WriteLine("Por favor ingrese un numero");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("TABLA DE MULTIPLICAR");
for (int i = 0; i < 11; i++)
{
    int res = num * i;
    Console.WriteLine(num + "*" + i + " = " + res);
    
}