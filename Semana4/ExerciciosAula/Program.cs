/*#region Herança 

ContaCorrente contaDan = new ContaCorrente("100");
contaDan.sacar(500);
Console.WriteLine($"{contaDan.getNumero()}");
ContaPoupanca contaPenedo = new ContaPoupanca("171", 200);
contaPenedo.sacar(500);
Console.WriteLine($"{contaPenedo.getNumero()}");

var contas = new List<Conta>();
contas.add(contaDan);
contas.add(contaPenedo);

abstract class Conta{
    protected string numero;
    protected string? titular; 
    protected double saldo;

    public Conta(string _numero, double _saldo=0){
        this.numero = _numero;
        this.saldo = _saldo;
    }

    public string getNumero(){
        return this.numero;
    }

    public virtual double sacar (double valor){
        if(valor > 0 && valor <= this.saldo){
            this.saldo -= valor;
            return valor;
        }
        else{
            throw new Exception("Valor inválido");
        }
    }
}
class ContaCorrente: Conta{
    double limite;
    public ContaCorrente(string _numero, double _saldo=0):base(_numero, _saldo){
        
        this.limite = 1000;
        this.numero = _numero;
        this.saldo = _saldo;
    }
}

class ContaPoupanca: Conta{
    
    double rendimento;

    public ContaPoupanca(string _numero, double _saldo=0):base(_numero, _saldo)
}
#endregion*/

#region Exercícios Aula

/*class Veiculo{
    public string? Modelo { get; set; }
    public int Ano { get; set; }
    public string? Cor { get; set; }

    public int IdadeVeiculo{
        get{int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        }
    }
  
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Idade: {IdadeVeiculo} anos");
    }
}

class Program {
    
    static void Main()
    {
        Veiculo meuVeiculo = new Veiculo();
        meuVeiculo.Modelo = "Etios";
        meuVeiculo.Ano = 2018;
        meuVeiculo.Cor = "Cinza Pérola";
        meuVeiculo.ExibirInformacoes();
        Console.ReadLine();
    }
}*/

class ContaBancaria {
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Saldo não pode ser negativo");
            }
            saldo = value;
        }
    }

    // Outros membros da classe, como métodos, podem ser adicionados conforme necessário
}

class Program {
    static void Main(){
        ContaBancaria minhaConta = new ContaBancaria();

        try{
            minhaConta.Saldo = -1000;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        Console.ReadLine();
    }
}


#endregion