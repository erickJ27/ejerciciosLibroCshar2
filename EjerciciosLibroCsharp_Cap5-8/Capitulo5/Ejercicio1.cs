using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLibroCsharp_Cap5_8.Capitulo5
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }


        static int  Bfactorial (int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Bfactorial(n - 1);
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int numero = Decimal.ToInt32(NumeroNumericUpDown.Value);


            MessageBox.Show("El factorial es: \n"+Bfactorial(numero), "Factorial de un numero",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
