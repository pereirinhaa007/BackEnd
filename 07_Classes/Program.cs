using Sesi.Models

class Program
{
    public static void Main()
    {
        Gato meuGato = new Gato();
        meuGato.nome = "Bacana";
        meuGato.cor = "Preto";
        meuGato.idade = 2;
        meuGato.especie = "Vira lata";
        meuGato.genero = "macho";
        meuGato.peso = 3;

        Peixe meuPeixe = new Peixe();
        meuPeixe.especie = "Palhaço";
        meuPeixe.cor = "Laranja";
        meuGato.tamanho = 0.20M;
        meuGato.peso = 0.100M;
    }
}