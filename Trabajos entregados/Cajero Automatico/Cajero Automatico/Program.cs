using System;

namespace Cajero_Automatico
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Cajero cajero = null; // Inicializamos el Cajero fuera del bucle

            do
            {
                //Menu
                Console.WriteLine("\n------------------------------------------------------------------");
                Console.WriteLine("Bienvenido al Cajero Automático");
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Crear cuenta");
                Console.WriteLine("2. Realizar depósito");
                Console.WriteLine("3. Realizar extracción");
                Console.WriteLine("4. Realizar adelanto");
                Console.WriteLine("5. Imprimir recibo y salir");
                Console.WriteLine("6. Salir");

                
                //Guardo el numero que la persona puso
                opcion = Convert.ToInt32(Console.ReadLine());

                //Depende del numero que toco la persona se abre alguna opcion
                switch (opcion)
                {
                    case 1:
                        // Crear una nueva instancia de CuentaBancaria y Usuario
                        CuentaBancaria nuevaCuenta = new CuentaBancaria(0, 0, DateTime.Now, "", "");
                        Usuario nuevoUsuario = new Usuario(0, "", "", false);

                        // Crear una nueva instancia de Cajero con la cuenta y el usuario creados
                        cajero = new Cajero(0, "Dirección del Cajero", 1, nuevaCuenta, nuevoUsuario);
                        cajero.crearCuenta();
                        break;
                    case 2:
                        if (cajero != null) // Verificar si se ha creado una cuenta
                            cajero.deposito();
                        else
                            Console.WriteLine("Debe crear una cuenta primero.");
                        break;
                    case 3:
                        if (cajero != null) // Verificar si se ha creado una cuenta
                            cajero.extraccion();
                        else
                            Console.WriteLine("Debe crear una cuenta primero.");
                        break;
                    case 4:
                        if (cajero != null) // Verificar si se ha creado una cuenta
                            cajero.adelanto();
                        else
                            Console.WriteLine("Debe crear una cuenta primero.");
                        break;
                    case 5:
                        if (cajero != null) // Verificar si se ha creado una cuenta
                            cajero.mostrar();
                        else
                            Console.WriteLine("Debe crear una cuenta primero.\n\n");
                        break;
                    case 6:
                        Console.WriteLine("Gracias por utilizar nuestro servicio.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 5); // Repetir hasta que se seleccione la opción de salir
        }
    }
}