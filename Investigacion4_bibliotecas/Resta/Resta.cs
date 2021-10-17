using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperacionesCalculadora;

namespace Resta
{
    [InformacionOperacion(Descripcion = "Realiza la resta de operando1 - operando2")]
    public class Resta:IOperaciones
    {
        public double RealizarOperacion(double operando1, double operando2)
        {
            return operando1 - operando2;
        }
    }
}
