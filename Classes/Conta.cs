using System;

namespace NET.Bank
{
    public class Conta
    {
        private string Nome { get; set; }
        private TipoConta TipoConta {get; set;}
        private double Saldo {get; set;}
        private double Credito { get; set; }

        public Conta(string nome, TipoConta tipoConta, double saldo, double credito)
        {
            this.Nome = nome;
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
        }
        public bool Saque(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
               Console.WriteLine("Saldo insuficiente.");
               return false;
            }

            this.Saldo += valorSaque;
           
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }

        public void Depositar(double valorDeposito) 
          {
              this.Saldo += valorDeposito;
              Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
          } 

            public void Transferir(double valorTransferencia, Conta contaDestino)
		{
			if (this.Saque(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
			return retorno;
		}

        internal void Sacar(double valorSaque)
        {
            throw new NotImplementedException();
        }
    }
}