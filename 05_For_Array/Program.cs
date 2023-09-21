class Program
{
    public static void Main()
    {
        for (int i = 1;i <= 10; i++)
        {
            Console.WriteLine($"Estou passando pela {i}º vez no bloco");
        }

        //Criando uma tabuada utilizando o for
        int num = 5;
        for (int cont = 1; cont <= 10; cont++)
        {
            //num é a variável que estou gerando a tabuada
            //cont é a váriavel  contadora até 10
            Console.WriteLine($"{num} x {cont} = {cont * num}");
        }

        //Declarando um vetor do tipo inteiro com espaço0s
        int[] notas = new int[4];
        //Declarar um vetor atribuindo valores
        string[] meses = {"Jan" , "Fev"};

        
        int[] alunos = new int[6];
        alunos[4] = 3;
        alunos[5] = 11;
        alunos[3] = 7;
        alunos[0] = 20;
        alunos[2] = 8;
        alunos[1] = 12;

        int soma = 0;
        int maior = 0;
        int menor = 10000;
        
        for (int i = 0; i < alunos.Length; i++){
            Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}-");
        }

        foreach (int ricardo in alunos) {
            soma = soma + ricardo;
            if (ricardo > maior){
                maior = ricardo;
            }
            if (ricardo < menor){
                menor = ricardo;
            }
        }
        Console.WriteLine($"Soma é {soma} o maior é {maior} e o menor é {menor}");
        Array.Sort(alunos);
        for (int i = 0; i < alunos.Length; i++){
            Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}");
        }


    }

}