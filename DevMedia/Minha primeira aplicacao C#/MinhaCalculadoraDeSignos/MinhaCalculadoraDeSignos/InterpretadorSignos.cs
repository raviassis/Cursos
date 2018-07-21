using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCalculadoraDeSignos
{
    class InterpretadorSignos
    {
        private Signo[] signos = new Signo[12];
        
        public InterpretadorSignos()
        {
            this.signos[0] = new Signo {  nome =     "Aguário", diaInicio = 20, mesInicio =  1, diaFim = 18, mesFim =  2, caracteristicas = "" };
            this.signos[1] = new Signo {  nome =      "Peixes", diaInicio = 19, mesInicio =  2, diaFim = 20, mesFim =  3, caracteristicas = "" };
            this.signos[2] = new Signo {  nome =       "Áries", diaInicio = 21, mesInicio =  3, diaFim = 19, mesFim =  4, caracteristicas = "" };
            this.signos[3] = new Signo {  nome =       "Touro", diaInicio = 20, mesInicio =  4, diaFim = 20, mesFim =  5, caracteristicas = "" };
            this.signos[4] = new Signo {  nome =      "Gêmeos", diaInicio = 21, mesInicio =  5, diaFim = 21, mesFim =  6, caracteristicas = "" };
            this.signos[5] = new Signo {  nome =      "Câncer", diaInicio = 22, mesInicio =  6, diaFim = 22, mesFim =  7, caracteristicas = "" };
            this.signos[6] = new Signo {  nome =        "Leão", diaInicio = 23, mesInicio =  7, diaFim = 22, mesFim =  8, caracteristicas = "" };
            this.signos[7] = new Signo {  nome =      "Virgem", diaInicio = 23, mesInicio =  8, diaFim = 22, mesFim =  9, caracteristicas = "" };
            this.signos[8] = new Signo {  nome =       "Libra", diaInicio = 23, mesInicio =  9, diaFim = 22, mesFim = 10, caracteristicas = "" };
            this.signos[9] = new Signo {  nome =   "Escorpião", diaInicio = 23, mesInicio = 10, diaFim = 21, mesFim = 11, caracteristicas = "" };
            this.signos[10] = new Signo { nome =   "Sagitário", diaInicio = 22, mesInicio = 11, diaFim = 21, mesFim = 12, caracteristicas = "" };
            this.signos[11] = new Signo { nome = "Capricórnio", diaInicio = 22, mesInicio = 12, diaFim = 19, mesFim =  1, caracteristicas = "" };
        }

        public Signo Interpretar(int dia, int mes)
        {
            for (int i = 0; i < this.signos.Length; i++)
            {
                if ( (dia >= this.signos[i].diaInicio && mes == this.signos[i].mesInicio) || (dia <= this.signos[i].diaFim && mes == this.signos[i].mesFim)  )
                    return this.signos[i];
            } 

            return null;
        }
    }
}
