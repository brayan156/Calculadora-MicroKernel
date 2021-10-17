using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OperacionesCalculadora;

namespace AplicacionCentral
{
    class Calculadora
    {
        private string descripcionOperacion;
        private IOperaciones operacion;

        public string DescripcionOperacion
        {
            get { return descripcionOperacion; }
        }
        public IOperaciones Operacion
        {
            get { return operacion; }
        }


        public void cargarOperacion(string nombre)
        {
            var path = @"Plugins/" + nombre + ".dll";
            Assembly pluginAssembly = Assembly.LoadFrom(path);

            
            var clase = pluginAssembly.GetTypes().First(type => type.IsClass && type.GetInterface("IOperaciones") != null);

            operacion = (IOperaciones)pluginAssembly.CreateInstance(clase.FullName, true);

            InformacionOperacion informacion = (InformacionOperacion)clase.GetCustomAttributes(false).
                First(atributo => atributo.GetType() == typeof(InformacionOperacion));
            descripcionOperacion = informacion.Descripcion;


        }
    }
}
