using System;


namespace Banco.Contas
{
    public enum TipoConta { ContaCorrente, ContaPoupanca};
    class Conta
    {
        public string Num;
        private double Saldo;
        public TipoConta Tipo;

        public Conta(TipoConta tipo, string num)
        {
            Saldo = 0;
            Num = num;
            Tipo = tipo;
        }
        
        public void Sacar(double valor)
        {
            Saldo = Saldo - valor;
        }

        public void Depositar (double valor)
        {
            Saldo = Saldo + valor;
        }

        public double GetSaldo()
        {
            return Saldo;
        }
    }
}
