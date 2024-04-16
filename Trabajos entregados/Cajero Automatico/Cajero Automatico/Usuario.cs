using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    //Clase Usuario
    internal class Usuario
    {
        //Atributos
        public int id;
        public string nombre;
        public string direccion;
        
        public bool tipous;

        //Constructores de los atributos
        public Usuario(int id, string nombre, string direccion, bool tipous)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.tipous = tipous;
        }


    }
}
