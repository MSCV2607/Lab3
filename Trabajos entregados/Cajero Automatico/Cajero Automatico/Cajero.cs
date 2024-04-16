using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    //Clase cajero
    internal class Cajero
    {
        //Variable para ayudarme con booleano
        int jubilado = 0;

        //Atributos y conexion con otras clases
        public string direcCajero;
        public int idCaj;
        private CuentaBancaria cuenta; // Variable para almacenar la cuenta creada <--
        public Usuario usuarioX;

        //Constructores de los atributos
        public Cajero(int jubilado, string direcCajero, int idCaj, CuentaBancaria cuenta, Usuario usuarioX)
        {
            this.jubilado = jubilado;
            this.direcCajero = "Av SiempreViva 742";
            this.idCaj = 01;
            this.cuenta = cuenta;
            this.usuarioX = usuarioX;
        }

        //Metodo para crear una cuenta
        public void crearCuenta()
        {
            Console.WriteLine("Ingrese los datos del usuario:");
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();
            Console.Write("Usted es jubilado? (true/false): ");
            bool tipous = Convert.ToBoolean(Console.ReadLine());

            //Si bool es true --> pone 1, caso contrario 2
            if(tipous)
            {
                jubilado = 1;
            } else { jubilado = 2; }

            

            

            
            Usuario nuevoUsuario = new Usuario(id, nombre, direccion, tipous);

            Console.WriteLine("Cuenta creada exitosamente para el usuario:");
            Console.WriteLine("ID: " + nuevoUsuario.id + " Nombre: " + nuevoUsuario.nombre + " Dirección: " + nuevoUsuario.direccion);

            // Creao la cuenta bancaria para el usuario y almacenar en la variable de instancia
            cuenta = new CuentaBancaria(nuevoUsuario.id, 0, DateTime.Now, nuevoUsuario.nombre, "Creación de cuenta");
        }


        //Metodo para depositar
        public void deposito()
        {
            //Si la cuenta no estaa vacia llamamos a la funcion deposito que esta en la clase cuenta
            if (cuenta != null)
            {
                cuenta.deposito();
            }
            //Si la cuenta es null pido que se cree primero una cuenta
            else
            {
                Console.WriteLine("Debe crear una cuenta primero.");
            }
        }

        public void extraccion()
        {
            //Si la cuenta no estaa vacia llamamos a la funcion deposito que esta en la clase cuenta
            if (cuenta != null)
            {
                cuenta.extraccion();
            }
            //Si la cuenta es null pido que se cree primero una cuenta
            else
            {
                Console.WriteLine("Debe crear una cuenta primero.");
            }
        }




        //Metodo para adelanto
        public void adelanto()
        {
   

            if (cuenta != null)
            {
                if (jubilado == 1) //Si es 1
                {
                    cuenta.adelantoJ(); // Adelanto para usuario jubilado
                }
                else if (jubilado == 2) //Si es 2
                {
                    cuenta.adelantoA(); // Adelanto para usuario no jubilado
                }
            }
            else
            {
                Console.WriteLine("Debe crear una cuenta primero.");
            }
            
        }

           
        //Metodo para imprimir el ticket
        public void mostrar()
        {
            if (cuenta != null)
            {
                
                Console.WriteLine("\n----Impresion de datos " + cuenta.fechaHoraActual + "----");
                Console.WriteLine($"Número de cuenta:" + cuenta.numCuenta);
                Console.WriteLine($"Usuario:" + cuenta.usuario);
                cuenta.imprimirTransacciones();
                Console.WriteLine($"Saldo actual:" + cuenta.saldoActual);
                Console.WriteLine("Impresion realizada en el cajero " + idCaj + " De:" + direcCajero);
            }
            else
            {
                Console.WriteLine("No hay ninguna cuenta creada.");
            }
        }

    }
}
