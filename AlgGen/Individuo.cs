using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    class Individuo
    {

        public string Genotipo { get; private set; }
        public int Fitness { get; private set; }



        public Individuo(Random Aleatorio)
        {
           
            Genotipo = "";
            for (int i=0; i<8; i++)
                Genotipo += Aleatorio.Next(1, 8);

        }

        public Individuo(Individuo Padre, Individuo Madre, int PuntoCruzamiento)
        {
           
            Genotipo = Padre.Genotipo.Substring(0, PuntoCruzamiento);
            Genotipo += Madre.Genotipo.Substring(PuntoCruzamiento);

        }

        public int EvaluaFitness(string Modelo)
        {
            
            
            Fitness = 0;

            for (int i = 0; i < Genotipo.Length; i++)
                if (Genotipo[i] == Modelo[i])
                    Fitness++;

            return Fitness;


        }

        public void Muta(double ProbabilidadMutacion, Random Aleatorio)
        {
           
            
            string GenotipoAux = "";

            for (int i=0; i<Genotipo.Length; i++)
            {
                if (Aleatorio.NextDouble() < ProbabilidadMutacion)
                    GenotipoAux += Aleatorio.Next(1, 8);
                else
                    GenotipoAux += Genotipo[i];
            }
            Genotipo = GenotipoAux; 
            

        }
    }
}
