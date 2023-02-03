using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_No._1___Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Error Provider
            if (NumeroTextBox.Text == "")
            {
                ErrorProvider1.SetError(NumeroTextBox, "Ingrese un número");
                return;
            }

            if (NumeroTextBox.Text == String.Empty)
            {
                ErrorProvider1.SetError(NumeroTextBox, "Ingrese un número");
                return;
            }
            ErrorProvider1.Clear();

            //Declaración de Variables
            int Numero = Convert.ToInt16(NumeroTextBox.Text);
            string Resultado1;
            string Resultado2;

            //Llamado a funciones
            Resultado1 = ParoImpar(Numero);
            Resultado2 = NegativoPositivo(Numero);

            //Resultados
            ParImparTextBox.Text= Resultado1;
            PositivoNegativoTextBox.Text= Resultado2;
        }

        //Función para determinar si el número es par o impar
        private string ParoImpar (int Numero)
        {
            string R1;

            if (Numero % 2 == 0)
                R1 = "El número " + Numero + " es par";
            else
                R1 = "El número " + Numero + " es impar";

            return R1;
        }

        //Función para determinar si el número es positivo o negativo
        private string NegativoPositivo(int Numero)
        {
            string R2;

            if (Numero >= 0)
                R2 = "El número " + Numero + " es positivo";
            else
                R2 = "El número " + Numero + " es negativo";

            return R2;
        }


    }
}
