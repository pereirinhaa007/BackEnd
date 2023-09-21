Console.WriteLine("Digite o valor de x");
//Precisamos converter os dados que recebemos do WriteLine
//int.Parse() para converter para inteiro
int x = 10;
Console.WriteLine("Digite o valor de y");
int y = 5;

//Exemplos de operadores aritméticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2;

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtração: " + subtracao);
Console.WriteLine("Multiplicação: " + multiplicacao);
Console.WriteLine("Divisão: " + divisao);
Console.WriteLine("Resto: " + resto);

if (restoDiv2 == 0) {
    Console.WriteLine($"{x} é par");
} else {
    Console.WriteLine($"{x} é ímpar");
}

//Operador ternário
//Condição ? se verdade : senão
string ePar = (restoDiv2 == 0) ? "par" : "impar";