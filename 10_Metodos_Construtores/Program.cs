using Models;

public class Program{
    public static void Main(){
        //Criar um objeto da classe Pessoa
        /*
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Ginaldo";
        pessoa1.idade = 69;

        //Alternativa de um objeto instanciado sem construtor
        Pessoa pessoa1 = new Pessoa {
            nome = "Ricardo",
            idade = 16
        }
        */

        //Instanciando um objeto com o método construtor
        Pessoa pessoa1 = new Pessoa("Ginaldo", 69);
        //Chamando o método Cantar da classe Pessoa
        pessoa1.Cantar();

        Pessoa pessoa2 = new Pessoa("Jandir", 53);
        pessoa2.Cantar();

        Pessoa pessoa3 = new Pessoa("Nelson", 58);
        pessoa3.Cantar();
    }
}