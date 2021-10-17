using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OperacionesCalculadora
{
    public interface IOperaciones
    {
        double RealizarOperacion(double operando1, double operando2);
    }

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class InformacionOperacion:System.Attribute
    {
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value;}
        }

    }
}
