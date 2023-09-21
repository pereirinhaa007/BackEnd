using System.Collections.Generic;
using Sesi.Models;

public class Program{
    public static void Main(){
        //Criando uma lista de números inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos à lista
        listaNumeros.Add(10); //Está posição [0]
        listaNumeros.Add(20); //Está posição [1]
        listaNumeros.Add(45); //Está posição [2]

        //Contando a quantidade de elementos em nossa lista
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[1]);

        listaNumeros.Add(34); //posição [3]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        Console.WriteLine("-----------------------");

        //Criem uma nova lista de nomes e adicionem alguns nomes e ela e exibam a quantidade de nomes que contém nessa lista
        List<string> listaNomes = new List<string>();

        listaNomes.Add("Pereira");
        listaNomes.Add("Victor");
        listaNomes.Add("Guilherme");
        listaNomes.Add("Caio");

        Console.WriteLine($"Agora temos {listaNomes.Count} nomes na lista");

        foreach (string item in listaNomes){
            Console.WriteLine(item);
        }

        Console.WriteLine("-----------------------");

        //Criando uma lista já atribuindo valores
        List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
        numeros.Add(10);

        //Iterando sobre todos os itens da lista
        foreach (int item in numeros){
            Console.WriteLine(item);
        }
        
        numeros.Remove(2); //Remove o elemento buscando pelo conteúdo
        numeros.RemoveAt(4); //Remove o elemento pela posição (índice)
        numeros.RemoveRange(2, 2); //Remove o elemento da posição 2 e os próximos 2

        foreach (int item in numeros){
            Console.WriteLine(item);
        }

        //Criando uma nova lista com objetos da Classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno à listaAlunos
        Aluno novoAluno = new Aluno("Bruno", 15);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Edenílson", 16));
        listaAlunos.Add(new Aluno("Flanela", 20));
        listaAlunos.Add(new Aluno("Ferdinando", 14));
        listaAlunos.Add(new Aluno("Zeca", 19));
        listaAlunos.Add(new Aluno("Adaílton", 18));
        listaAlunos.Add(new Aluno("Edílson", 19));

        Console.WriteLine("Lista de Alunos:");
        foreach (Aluno item in listaAlunos){
            Console.WriteLine($"Nome aluno: {item.nome} - {item.idade}");
        }

        //Criando uma nova lista, filtrando e ordenando por nome LINQ utilizando sintaxe de consulta
        var consulta = from aluno in listaAlunos
                        where aluno.idade > 18
                        orderby aluno.nome
                        select aluno;
        Console.WriteLine("Lista de alunos maiores de 18 anos");
        foreach (var item in consulta){
            Console.WriteLine($"Nome aluno: {item.nome} - {item.idade}");
        }

        //LINQ utilizando sintaxe de método
        var metodo = listaAlunos
                        .Where(aluno => aluno.idade < 18)
                            .OrderBy(aluno => aluno.nome);
        Console.WriteLine("Lista de alunos menores de 18 anos");
        foreach (var item in metodo){
            Console.WriteLine($"Nome aluno: {item.nome} - {item.idade}");
        }
    }
}