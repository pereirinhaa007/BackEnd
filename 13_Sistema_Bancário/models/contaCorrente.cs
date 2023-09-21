namespace Models{
    public class ContaCorrente{
        private string titular;
        private decimal saldo;

        public ContaCorrente(string titular, decimal saldo){
            this.titular = titular;
            this.saldo = saldo;
        }

        public void VerSaldo(){
            Console.WriteLine($"Olá {titular}, seu saldo é de R${saldo}");
        }

        public void DepositarValor(decimal valor){
            saldo += valor;
            Console.WriteLine($"Você depositou R${valor}.");
        }

        public void SacarValor(decimal valor){
            if (valor > 0 && valor <= saldo){
                saldo -= valor;
                Console.WriteLine($"Você sacou R${valor}.");
            }else{
                Console.WriteLine("Saldo insuficiente ou inválido para realizar o saque.");
            }
        }
    }
}