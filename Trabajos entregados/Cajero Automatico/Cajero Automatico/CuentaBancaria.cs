using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    //Clase Cuenta Bancaria
    internal class CuentaBancaria
    {
        // Definición de la estructura Transaccion
        internal struct Transaccion
        {
            //Fechas
            public DateTime FechaHora;
            //Que tipo es la transaccion (deposito, extraccion, adelanto)
            public string Tipo;
            //Monto de la transaccion
            public int Monto;
        }

        //Atributos
        public int numCuenta;
        public int saldoActual; 
        public DateTime fechaHoraActual = DateTime.Now;
        public string usuario;
        public string LOperacion;

        //Arreglo que almacena transacciones
        public Transaccion[] transacciones = new Transaccion[100]; 
        //Indice para el seguimiento de la proxima transaccion inicializado en 0
        private int indiceTransaccion = 0; 

        //Constructrores de los atributos
        public CuentaBancaria(int numCuenta, int saldoActual, DateTime fechaHoraActual, string usuario, string lOperacion)
        {
            this.numCuenta = numCuenta;
            this.saldoActual = saldoActual;
            this.fechaHoraActual = fechaHoraActual;
            this.usuario = usuario;
            LOperacion = lOperacion;
        }

        //Metodo con logica de deposito
        public void deposito()
        {
            //Inicializamos sus saldo en 0
            int saldo = 0;

            //Preguntamos cuanto quiere ingresar
            Console.WriteLine("Cuánto quiere ingresar");
            //Guardo el numero
            saldo = Convert.ToInt32(Console.ReadLine());

            //Guardo su saldo --> saldoActual + lo que me ingreso
            saldoActual += saldo;

            // Registrar la transacción de deposito en el arreglo (que es, numero)
            registrarTransaccion("Depósito", saldo);
        }

        //Metodo con logica de extraccion
        public void extraccion()
        {
            //Inicializamos la extraccion en 0
            int ext = 0;

            //Preguntamos cuanto quiere extraer
            Console.WriteLine("Cuánto quiere sacar");
            //Guardo el numero
            ext = Convert.ToInt32(Console.ReadLine());

            //Guardo su extraccion --> saldoActual - lo que me ingreso y solo se puede sacar si la cuenta tiene saldo suficiente
            if (ext <= saldoActual)
            {
                saldoActual -= ext;

                // Registrar la transacción de la extraccion en el arreglo (que es, numero) --> el - es para que se vea que esta en negativo cuando lo muestre
                registrarTransaccion("Extracción", -ext); 
            }
            else
            {
                Console.WriteLine("Fondos insuficientes.");
            }
        }

        //Defino los limites de adelanto
        public int limiteAdelantoA = -20000; 
        public int limiteAdelantoJ = -10000; 
        //Variables para guardar preguntas 
        string preguntaA;
        int preguntaB;

        //Metodo con logica de adelanto a Activos
        public void adelantoA()
        {
            int adelanto = 0;

            Console.WriteLine("Posee un monto de saldo positivo mayor a 20.000?");
            preguntaA = Console.ReadLine();

            //Si la respuesta es si pasa a la otra pregunta, si no sigue todo normal con un saldo negativo de 20000
            if (preguntaA == "Si")
            {
                Console.WriteLine("Hace cuántos meses usted posee un saldo positivo mayor a 20.000?");
                preguntaB = Convert.ToInt32(Console.ReadLine());
                //Si el usuario puso mas o igual a 2 su saldo negativo se aumenta a 80000
                if (preguntaB >= 2)
                {
                    limiteAdelantoA = -80000;
                }
            }
            //Lo que el usuario desea adelantar y lo guardo
            Console.WriteLine("¿Cuánto desea adelantar?");
            adelanto = Convert.ToInt32(Console.ReadLine());

            //Si se puedo hacer el adelanto se guarda y resta del saldo actual [ojo puede quedar en negativo]
            if (saldoActual - adelanto >= limiteAdelantoA)
            {
                saldoActual -= adelanto;
                Console.WriteLine("Adelanto exitoso.");

                // Registrar la transacción de adelanto
                registrarTransaccion("Adelanto", -adelanto); // Valor negativo para indicar un adelanto
            }
            //Si no hay fondo o llega al limite mostramos el mensaje
            else
            {
                Console.WriteLine("Fondos insuficientes o excede el limite de adelanto");
            }
        }

        //Metodo con logica de adelanto a jubilados
        public void adelantoJ()
        {
            int adelanto = 0;

            //Lo que el usuario desea adelantar y lo guardo
            Console.WriteLine("¿Cuánto desea adelantar?");
            adelanto = Convert.ToInt32(Console.ReadLine());

            //Si se puedo hacer el adelanto se guarda y resta del saldo actual [ojo puede quedar en negativo]
            if (saldoActual - adelanto >= limiteAdelantoJ)
            {
                saldoActual -= adelanto;
                Console.WriteLine("Adelanto exitoso.");

                // Registrar la transacción de adelanto
                registrarTransaccion("Adelanto", -adelanto); // Usamos un valor negativo para indicar un adelanto
            }
            //Si no hay fondo o llega al limite mostramos el mensaje
            else
            {
                Console.WriteLine("Fondos insuficientes o excede el límite de adelanto.");
            }
        }


        // Metodo para registrar una transacción en el arreglo
        public void registrarTransaccion(string tipo, int monto)
        {
            transacciones[indiceTransaccion].FechaHora = DateTime.Now;
            transacciones[indiceTransaccion].Tipo = tipo;
            transacciones[indiceTransaccion].Monto = monto;
            indiceTransaccion++;
        }

        public void imprimirTransacciones()
        {
            Console.WriteLine("Historial de transacciones:");
            for (int i = 0; i < indiceTransaccion; i++)
            {
                var transaccion = transacciones[i];
                Console.WriteLine($"Fecha: {transaccion.FechaHora}, Tipo: {transaccion.Tipo}, Monto: {transaccion.Monto}");
            }
        }

    }
}
