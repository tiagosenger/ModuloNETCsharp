﻿#region Exercicios aula

Console.WriteLine("Números divísiveis por 3 ou 4 entre 0 e 30:");

for (int i = 0; i <= 30; i++){
    if (i % 3 == 0  || i % 4 == 0)
    {
        Console.WriteLine(i);
    }{}
}

Console.WriteLine("\nPrimeiros números da série de Fibonacci:");

int limite = 100;
int a = 0, b = 1;

Console.Write($"{a} \n{b} \n");

while (a + b <= limite)
{
    int proximo = a + b;
    Console.Write($"{proximo} \n");
    a = b;
    b = proximo;
}

Console.Write("\nTabela: \n");

int nivelMaximo = 8;

for (int n = 1; n <= nivelMaximo; n++)
{
    Console.Write($"n = {n}: ");

    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{n * i} ");
    }

    Console.WriteLine();
}
#endregion

#region Exemplo Datas

string dataString = "25/10/2023";
string[] partes = dataString.Split('/');

List<string> listaData = new List<string>(partes);

Console.WriteLine("Dia: " + listaData[0]);
Console.WriteLine("Mes: " + listaData[1]);
Console.WriteLine("Ano: " + listaData[2]);

#endregion