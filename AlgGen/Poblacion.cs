using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    class Poblacion
    {
        List<Individuo> Individuos;
        int NSeleccionados;
        int TamPoblacion;
        Random Aleatorio;





        public Poblacion(int TamPoblacion)
        {
            Individuos = new List<Individuo>();
            this.TamPoblacion = TamPoblacion;

            Aleatorio = new Random();

            for (int i = 0; i < TamPoblacion; i++)
                Individuos.Add(new Individuo(Aleatorio));
        }



        public void Evaluacion()
        {
            for (int i = 0; i < Individuos.Count; i++)
                Individuos[i].EvaluaFitness("12345678");
        }    
        




        public void Seleccion(double Presion)
        {
            Individuo auxiliar;
            for (int i = 0; i < Individuos.Count - 1; i++)
                for (int j = i + 1; j<Individuos.Count; j++)
                    if (Individuos[i].Fitness < Individuos[j].Fitness)
                    {
                        auxiliar = Individuos[i];
                        Individuos[i] = Individuos[j];
                        Individuos[j] = auxiliar;
                    }


            NSeleccionados = (int)((double)Individuos.Count*(100-Presion)/100.0);
            while (Individuos.Count > NSeleccionados)
                Individuos.RemoveAt(Individuos.Count - 1);
        }



        public void Cruzamiento()
        {
            int valor_aleatorio = 0;
            Individuo padre;
            Individuo madre;
            Individuo hijo;



            for(int i=NSeleccionados; i<TamPoblacion; i++)
            {
                valor_aleatorio = Aleatorio.Next(0, NSeleccionados - 1);
                padre = Individuos[valor_aleatorio];

                valor_aleatorio = Aleatorio.Next(0, NSeleccionados - 1);
                madre = Individuos[valor_aleatorio];

                valor_aleatorio = Aleatorio.Next(0, 8);

                hijo = new Individuo(padre, madre, valor_aleatorio);
                Individuos.Add(hijo);
            }


        }



        public void Mutacion(double ProbabilidadMutacion)
        {

            for (int i = NSeleccionados; i < Individuos.Count; i++)
                Individuos[i].Muta(ProbabilidadMutacion, Aleatorio);

        }



        public string GetDatosPoblacion()
        {


            string genotipos_poblacion="";



            for (int i = 0; i < Individuos.Count; i++)
                genotipos_poblacion += Individuos[i].Genotipo + " - " + Individuos[i].Fitness + "\n";



            return genotipos_poblacion;
        }



    }
}
