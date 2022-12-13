using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1 {
    class Account {

        public int NumAccount { get; private set; }
        private string TitularAccount;
        public double ValorAccount { get; private set; } = 0;

        public Account() {
            
        }

        public Account(int numAccount, string titularAccount) {
            NumAccount = numAccount;
            TitularAccount = titularAccount;
        }

        public Account(int numAccount, string titularAccount, double valorInicialAccount) {
            NumAccount = numAccount;
            TitularAccount = titularAccount;
            ValorAccount = valorInicialAccount;
        }


        public void DepositoAccount(double valor) {
            ValorAccount += valor;
        }

        public void SaqueAccount(double valor) {
            ValorAccount -= valor;
        }

        public override string ToString() {
            return String.Format("Conta {0}, Titular: {1}, Saldo: ${2}", NumAccount, TitularAccount, ValorAccount);
        }

    }
}
