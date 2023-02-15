using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        //static = propriedade da classe, não dos objetos criados apartir dela
        public static int TotalDeContasCriadas { get; private set; }

        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return numeroAgencia; }
            private set { 
                if (value > 0 )
                    this.numeroAgencia = value; 
                }
        }
        //private string conta;
        public string Conta { get; set; }
        private double _saldo = 100;
        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= _saldo)
            {
                _saldo -= valor;
                return true;
            }
            else return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (_saldo < valor)
                return false;
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
                return;
            else
                this._saldo = valor;
        }

        public double GetSaldo()
        {
            return _saldo;
        }

        public ContaCorrente(int numeroAgencia, string conta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = conta;
            TotalDeContasCriadas++;
        }
    }
}
