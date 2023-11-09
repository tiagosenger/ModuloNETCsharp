Console.WriteLine("Olá, Mundo!");

#region Teste de Tipos de Dados
   
    int tipoInteiro;
    double tipoDouble;
    string tipoString;
    long tipoLong;

   // tipoInteiro = tipoLong;
    tipoInteiro = int.MaxValue;
    tipoLong = long.MaxValue;
    
    tipoString = "100";

    tipoInteiro = int.Parse(tipoString);

    Console.WriteLine("O máximo inteiro é: " + tipoInteiro);
    Console.WriteLine("O máximo long é: " + tipoLong);

#endregion

#region Operadores

    tipoDouble = tipoInteiro + tipoLong;
    //tipoInteiro = tipoDouble + tipoLong; erro, nem long nem double podem ser convertidos a um inteiro
    //tipoLong = tipoDouble + tipoInteiro; erro, um double n pode ser convertido num long (slide 9 aula 2)

    tipoInteiro = 10 > 5 ? 1 : 0;

#endregion
