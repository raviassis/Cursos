using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Calculadora
    {
        private double areaParedes;
        private double areaTeto;

        public double calcularAreaParedes(double largura, double profundidade, double altura)
        {
            this.areaParedes = 2 * (largura + profundidade) * altura;
            return this.areaParedes;
        }

        public double calcularAreaTeto(double largura, double profundiade)
        {
            return this.areaTeto = largura * profundiade;
        }

        public double calcularLitragem(double rendimento)
        {
            double lit = 0;
            if (this.areaParedes == 0.0 && this.areaTeto == 0.0) return lit;
            else return (this.areaParedes + this.areaTeto) / rendimento;
        }
        
    }
}
