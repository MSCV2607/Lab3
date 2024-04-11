
Console.WriteLine("*****ESTA PARTE ES DEL PROFESOR, SI USTED NO ES PROFESOR ESPERE PARA RESPONDER***** \n");
//Pido cuantas preguntas tendra el parcial
Console.WriteLine("Por favor ingrese cuantas preguntas quiere escribir: ");
int numP = Convert.ToInt32(Console.ReadLine()); //Guardo el número de preguntas

float notaXPreg = 100 / numP; //100 / numero de preguntas dara cuanto vale cada pregunta
float notaAcum = 0; //Variable en la que puedo guardar cuanta nota va acumulando el alumno
int selecc; //Variable de seleccion
String[,] preguntas = new String[numP, 4]; //Matriz bidimencional para guardar respuestas
int[] respuestasCorrectas = new int[numP]; //Matriz Unidimencional para que el profesor elija en donde quiere poner la respuesta correcta

//Bucle para el algoritmo de guardado en la matriz 
for (int i = 0; i < numP; i++)
{
    //Pido al profesor que me ingrese la pregunta X
    Console.WriteLine("\nPor favor ingrese la pregunta " + (i + 1) + ":");
    preguntas[i, 0] = Console.ReadLine();

    //Pido al profesor que ponga cual de las tres opciones será la correcta
    Console.WriteLine("Por favor ingrese donde quiere la respuesta correcta (opción 1-3) ");
    respuestasCorrectas[i] = Convert.ToInt32(Console.ReadLine());

    //Primera pregunta
    Console.WriteLine("\nPor favor ingrese una respuesta ");
    preguntas[i, 0] = Console.ReadLine();

    //Segunda pregunta
    Console.WriteLine("Por favor ingrese otra respuesta ");
    preguntas[i, 1] = Console.ReadLine();

    //Tercera pregunta
    Console.WriteLine("Por favor ingrese la ultima respuesta");
    preguntas[i, 2] = Console.ReadLine();
}

//ACA EMPIEZA LA PARTE DEL ESTUDIANTE
Console.WriteLine("\n---------------------------------------------------Estudiante---------------------------------------------------");
Console.WriteLine("Bienvenido alumno, en esta seccion podrá contestar el parcial multiple choice, el programa le desea suerte....");


//Bucle para mostrar preguntas al estudiante
for (int i = 0; i < numP; i++)
{
    //Num de pregunta
    Console.WriteLine("\nPregunta " + (i + 1) + ": " + preguntas[i, 0]);
    Console.WriteLine("-------------");
    //Opciones para la pregunta
    Console.WriteLine("Opción 1: " + preguntas[i, 0]);
    Console.WriteLine("Opción 2: " + preguntas[i, 1]);
    Console.WriteLine("Opción 3: " + preguntas[i, 2]);
    //Guardo lo que selecciona
    selecc = Convert.ToInt32(Console.ReadLine());

    //Verifico que sea un numero valido (1, 2 o 3)
    while (selecc < 1 || selecc > 3)
    {
        Console.WriteLine("Por favor ingrese un numero del 1 al 3");
        selecc = Convert.ToInt32(Console.ReadLine());
    }

    //Si la respuesta seleccionada es igual al numero que puso el profesor como respuesta correcta hace esto
    if (selecc == respuestasCorrectas[i])
    {
        //Mensaje de felicitación
        Console.WriteLine("CORRECTO!!");
        //Acumulo su progreso
        notaAcum += notaXPreg;
    }
    //En caso de que la respuesta sea incorrecta
    else
    {
        //Mensaje y no acumulo nada
        Console.WriteLine("Incorrecto :c");
    }

}
//Si la nota es mayor o igual a 6 (60) mostrara un mensaje de felicitación mas su nota
if (notaAcum >= 60)
{
    Console.WriteLine("\nFELICIDIADES !!!! SU NOTA FUE DE " + notaAcum + " Y APROBO EL PARCIAL :D");
}
else //Si su nota fue menos de 6 se mostrara un mensaje de que el alumno desaprobo + su nota
{
    Console.WriteLine("\nLamento informarle que desaprobó el parcial su nota fue de: " + notaAcum + " SIGA INTENTANDO.");
}