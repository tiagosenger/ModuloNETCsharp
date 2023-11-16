using System;

class Program {
    static void Main()
    {
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

        Console.Write($"{a} {b} ");

        while (a + b <= limite)
        {
            int proximo = a + b;
            Console.Write($"{proximo} ");
            a = b;
            b = proximo;
        }
        
        Console.Write("\n");

    }
}