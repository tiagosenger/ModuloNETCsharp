#region Resoluções IP 01
Console.WriteLine("Questão 3:");
double valorDouble = 10.75; //Questão 3 - Será utilizada o Convert.ToInt32 para resolver esse problema, entretanto, conversão de double para int resulta em uma truncagem da parte fracionária, e esta sendo significativa haverá perda dessa informação.

int valorConvertido = Convert.ToInt32(valorDouble);
Console.WriteLine($"Usando Convert.ToInt32: {valorConvertido}");

int valorCastDireto = (int)valorDouble;
Console.WriteLine($"Usando cast direto: {valorCastDireto}");

double valorDoubleComParteFracionaria = 10.99;
int valorConvertidoComPerda = Convert.ToInt32(valorDoubleComParteFracionaria);
Console.WriteLine($"Com perda: {valorConvertidoComPerda}\n");

//Questão 4
Console.WriteLine("Questão 4:");

int x = 10;
int y = 3;

int resultadoAdicao = x + y;
Console.WriteLine($"Adição: {resultadoAdicao}");

int resultadoSubtracao = x - y;
Console.WriteLine($"Subtração: {resultadoSubtracao}");

int resultadoMultiplicacao = x * y;
Console.WriteLine($"Multiplicação: {resultadoMultiplicacao}");

if (y != 0)
{
    int resultadoDivisao = x / y;
    Console.WriteLine($"Divisão: {resultadoDivisao}\n");
}
else
{
    Console.WriteLine("Divisão por zero não é permitida.\n");
}

//Questão 5
Console.WriteLine("Questão 5:");    

int a = 5;
int b = 8;

bool aMaiorQueB = a > b;

if (aMaiorQueB)
{
    Console.WriteLine("a é maior que b.\n");
}
else
{
    Console.WriteLine("a não é maior que b.\n");
}

//Questão 6
Console.WriteLine("Questão 6:");    

string str1 = "Hello";
string str2 = "World";

bool saoIguais = str1.Equals(str2);

if (saoIguais)
{
    Console.WriteLine("As strings são iguais.");
}
else
{
    Console.WriteLine("As strings não são iguais.\n");
}

//Questão 7
Console.WriteLine("Questão 7:");    

bool condicao1 = true;
bool condicao2 = false;

bool ambasCondicoesVerdadeiras = condicao1 && condicao2;

if (ambasCondicoesVerdadeiras)
{
    Console.WriteLine("Ambas as condições são verdadeiras.");
}
else
{
    Console.WriteLine("Pelo menos uma das condições não é verdadeira.\n");
}

//Questão 8
Console.WriteLine("Questão 8:");

int num1 = 7;
int num2 = 3;
int num3 = 10;

bool num1MaiorQueNum2 = num1 > num2;

bool num3IgualSomaNum1Num2 = num3 == (num1 + num2);

if (num1MaiorQueNum2)
{
    Console.WriteLine("num1 é maior do que num2.");
}
else
{
    Console.WriteLine("num1 não é maior do que num2.");
}

if (num3IgualSomaNum1Num2)
{
    Console.WriteLine("num3 é igual a num1 + num2.");
}
else
{
    Console.WriteLine("num3 não é igual a num1 + num2.");
}
#endregion