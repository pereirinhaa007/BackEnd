﻿using Sesi.Model;

class Program
{
    public static void Main()
    {
        //Criando uma variável aluno1 e instanciando da classe Aluno
        var aluno1 = new Aluno();
        aluno1.nome = "Pereira";
        aluno1.idade = 16;
        aluno1.turma = "2º EM";

        aluno1.Apresentar();

        var aluno2 = new Aluno();
        aluno2.nome = "Victor";
        aluno2.idade = 16;
        aluno2.turma = "2º EM";

        aluno2.Apresentar();
        aluno2.AdicionarFaltas(10);
        aluno2.Apresentar();
    }
}