//Exercício Calculando a média de 3 notas de um aluno

//Receber o nome do aluno e armazenar uma variável do tipo string
Console.WriteLine("Digite o nome do aluno: ");
string nomeAluno = Console.ReadLine();

//Receber a nota 1, converter e armazenar em uma variável int
Console.WriteLine("Digite a nota 1");
int n1 = int.Parse(Console.ReadLine());

//Receber a nota 2, converter e armazenar em uma variável int
Console.WriteLine("Digite a nota 2");
int n2 = int.Parse(Console.ReadLine());

//Receber a nota 3, converter e armazenar em uma variável int
Console.WriteLine("Digite a nota 3");
int n3 = int.Parse(Console.ReadLine());


//Declarar uma variável do tipo int, para receber a média de notas
//(nota 1 + nota 2 + nota 3) / 3
int notas = (n1 + n2 + n3) / 3;
string media = (notas >= 7) ? $"Parabéns, {nomeAluno} Aprovado" :  $"{nomeAluno} Reprovado";
Console.WriteLine(media);


//Exibir uma mensagem se o aluno está aprovado considerando nota acima de 7


int diaSemana = 6
//Aprendendo switch case
switch (diaSemana) {
    case 1:
        Console.WriteLine("Hoje é Domingo");
        break;
    case 2:
        Console.WriteLine("Hoje é Segunda");
        break;
    case 3:
        Console.WriteLine("Hoje é Terça");
        break;
    case 4:
        Console.WriteLine("Hoje é Quarta");
        break;
    case 5:
        Console.WriteLine("Hoje é Quinta");
        break;
    case 6:
        Console.WriteLine("Hoje é Sexta");
        break;
    case 7:
        Console.WriteLine("Hoje é Sábado");
        break;
    default:
        Console.WriteLine("Dia Inválido");
}

Console.WriteLine("Digite a sua placa:");
string placa = Console.ReadLine()