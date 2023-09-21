using Models;

public class Program{
    static ContaCorrente conta;

    public static void Main(string[] args){
        Console.WriteLine("Bem vindo ao Pino Bancário");

        Thread.Sleep(2000);

        Console.WriteLine("Informe o nome do titular da conta");
        string titular = Console.ReadLine();

        Console.WriteLine("Informe o saldo inicial de sua conta");
        decimal saldo = Convert.ToDecimal(Console.ReadLine());

        conta = new ContaCorrente(titular, saldo); // Corrigimos o nome da classe para ContaCorrente
        string opcao;

        do{
            Console.WriteLine("# # # # # M E N U # # # # #");
            Console.WriteLine("#      1 - Ver saldo      #");
            Console.WriteLine("#      2 - Depositar      #");
            Console.WriteLine("#        3 - Sacar        #");
            Console.WriteLine("#        0 - Sair         #");
            Console.WriteLine("# # # # # M E N U # # # # #");
            opcao = Console.ReadLine();

            switch (opcao){
                case "0":
                    Console.WriteLine("Obrigado, volte sempre!");
                    Thread.Sleep(2000);
                    break;
                case "1":
                    conta.VerSaldo();
                    break;
                case "2":
                    Console.WriteLine("Digite a quantia que deseja depositar");
                    decimal valorDepositar = Convert.ToDecimal(Console.ReadLine());
                    conta.DepositarValor(valorDepositar);
                    break;
                case "3":
                    Console.WriteLine("Digite a quantia que deseja sacar");
                    decimal valorSacar = Convert.ToDecimal(Console.ReadLine());
                    conta.SacarValor(valorSacar);
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        } while (opcao != "0");
    }
}