//O namespace é um nome em que usaremos para fazer referência quando usarmos
namespace Sesi.Model
{
    //Declarando a classe Aluno
    public class Aluno 
    {
        //Declarando os atributos
        public string nome {get; set; }
        public int idade {get; set; }
        public string turma {get; set; }
        public int nrFaltas {get; set;}

        //Criando um método
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos, estudo na turma {turma} e tenho {nrFaltas} faltasm");
        }

        public void AdicionarFaltas(int nr)
        {
            Console.WriteLine($"O aluno {nome} faltou hoje e somou {nr} faltas");
            nrFaltas = nrFaltas + nr;
        }

        public void ResumoFaltas()
        {
            Console.WriteLine($"O aluno {nome} tem {nrFaltas} faltas");
        }
    }  
}