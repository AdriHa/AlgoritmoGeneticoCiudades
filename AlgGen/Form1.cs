using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoGenetico
{
    public partial class Form1 : Form
    {
        Poblacion LaPoblacion;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
            LaPoblacion = new Poblacion((int)NUDTamPoblacion.Value);
            RTBPoblacion.Text = LaPoblacion.GetDatosPoblacion();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            LaPoblacion.Evaluacion();
            RTBEvaluados.Text = LaPoblacion.GetDatosPoblacion();

        }



        private void button3_Click(object sender, EventArgs e)
        {

            LaPoblacion.Seleccion((double)NUDPresion.Value);
            RTBSeleccionados.Text = LaPoblacion.GetDatosPoblacion();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            LaPoblacion.Cruzamiento();
            RTBCruzados.Text = LaPoblacion.GetDatosPoblacion();

        }



        private void button5_Click(object sender, EventArgs e)
        {
            
            LaPoblacion.Mutacion((double)NUDProbabilidadMutacion.Value);
            RTBMutados.Text = LaPoblacion.GetDatosPoblacion();

        }
    }
}
