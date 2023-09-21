//Somente declaramos a variável como inteira e não atriubuimos valo
int num1;

//Declarando uma variável do tipo inteira e atribuindo o valor 5
int nmm2 = 5;

//Declarando uma variável do tipo string
string nomeAluno;

//Variável do tipo lógico (verdadeiro ou falso)
bool resultado = true;

//Variável do tipo valor com casas decimais - para valores mais precisos
double coordenada = 1.80;

//Variável do tipo decimal - mais usada para valor monetário
decimal valor = 1.80M;


int idade = 16;
string nome = "Ricardo";
Console.WriteLine($"Meu nome é {nome} e tenho {idade}");

Console.WriteLine("Em que cidade você nasceu?");
//Recebendo uma informação de usuário e atribuindo an variável cidade
string cidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {cidade}");

int novaIdade = idade + 5;
int anoNascimento = 2023 - idade;
Console.WriteLine($"Você nasceu em {anoNascimento} e daqui 5 anos terá {novaIdade}");