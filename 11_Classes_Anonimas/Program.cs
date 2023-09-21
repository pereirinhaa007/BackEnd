public class Program{
    
    public static void Main(){
        var pessoa1 = new{
            nome = "Rodinei",
            idade = 25
        };
        var pessoa2 = new{
            nome = "Eduardo",
            idade = 31
        };
        Console.WriteLine($"A pessoa 1 se chama {pessoa1.nome} e a pessoa 2 {pessoa2.nome}");

        Console.WriteLine("Digite o modelo do carro");
        string modeloDigitado = Console.ReadLine();
        Console.WriteLine("Digite a marca do carro");
        string marcaDigitado = Console.ReadLine();
        Console.WriteLine("Digite o ano do carro");
        string anoDigitado = Console.ReadLine();
        var carro = new{
            marcaDigitado = Console.ReadLine(),
            modeloDigitado = Console.ReadLine(),
            anoDigitado = Console.ReadLine()
        };
        Console.WriteLine($"Meu carro é um {carro.modeloDigitado}, do(a) {carro.marcaDigitado} e do ano {carro.anoDigitado}");
    }
}