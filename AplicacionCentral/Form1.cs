using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OperacionesCalculadora;


namespace AplicacionCentral
{
    public partial class Form1 : Form
    {
        private Calculadora calculadora=new Calculadora();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DirectoryInfo di = new DirectoryInfo(@"Plugins");
            foreach (var fileInfo in di.GetFiles("*.dll"))
            {
                string pluginName = fileInfo.Name.Replace(".dll", "");
                if (!pluginName.Equals("OperacionesCalculadora"))
                {
                    PluginsCombo.Items.Add(pluginName);
                }

            }
        }

        private void BRealizar_Click(object sender, EventArgs e)
        {
            double op1 = Convert.ToDouble(Op1Box.Text);
            double op2 = Convert.ToDouble(Op2Box.Text);
            LabelResult.Text = calculadora.Operacion.RealizarOperacion(op1,op2).ToString();
        }

        private void PluginsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculadora.cargarOperacion(PluginsCombo.Text);
            LabelDescripcion.Text = calculadora.DescripcionOperacion;
        }


    }
}
