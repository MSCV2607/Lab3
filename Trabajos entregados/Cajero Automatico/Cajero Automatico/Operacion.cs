using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    //Clase operacion
    internal class Operacion
    {

        //Atributos
        public int cajeriID;
        public string tipoDeOp;
        public int monto;
        public DateTime fechaHoraActual = DateTime.Now;

        //Constructores de los atributos
        public Operacion(int cajeriID, string tipoDeOp, int monto, DateTime fechaHoraActual)
        {
            this.cajeriID = cajeriID;
            this.tipoDeOp = tipoDeOp;
            this.monto = monto;
            this.fechaHoraActual = fechaHoraActual;
        }
    }
}
