using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperacionesCalculadora;

namespace Suma
{
    [InformacionOperacion(Descripcion = "Realiza la suma de operando1 + operando2")]
    public class Suma:IOperaciones
    {
        public double RealizarOperacion(double operando1, double operando2)
        {
            return operando1+operando2;
        }
    }
}
