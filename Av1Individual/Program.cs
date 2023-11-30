#region Sistema de Gerenciamento de Escritórios de Advocacia

class Advogado{
    public string Nome { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; } = string.Empty;
    public string CNA { get; set; } = string.Empty;
}

class Cliente{
    public string Nome { get; set;} = string.Empty;
    public DateTime DataNascimento {get; set; }
    public string CPF { get; set; } = string.Empty;
    public string EstadoCivil { get; set; } = string.Empty;
    public string Profissao {get; set;} = string.Empty;
}

class EscritorioAdvocacia{
    private List<Advogado> advogados = new List<Advogado>();
    private List<Cliente> clientes = new List<Cliente>();
// Primeiro Requisito - Coleção de Advogados com validação de CPF e CNA:
    public void AdicionarAdvogado(Advogado advogado){
        if (advogados.Any(a => a.CPF == advogado.CPF || a.CNA == advogado.CNA)){
            throw new ArgumentException("CPF ou CNA já cadastrados.");
        }
        advogados.Add(advogado);
    }
// Segundo Requisito - Coleção de Clientes com validação de CPF:
    public void AdicionarCliente(Cliente cliente){
        if (clientes.Any(c => c.CPF == cliente.CPF)){
            throw new ArgumentException("CPF ja cadastrado.");
        }
        clientes.Add(cliente);    
    }
// Métodos dos Relatórios Solicitados:
    public IEnumerable<Advogado> AdvogadosComIdadeEntre(int idadeMinima, int idadeMaxima){
        return advogados.Where(a => CalculaIdade(a.DataNascimento) >= idadeMinima && CalculaIdade(a.DataNascimento) <= idadeMaxima);
    }

    public IEnumerable<Cliente> ClientesComIdadeEntre(int idadeMinima, int idadeMaxima){
        return clientes.Where(c => CalculaIdade(c.DataNascimento) >= idadeMinima && CalculaIdade(c.DataNascimento) <= idadeMaxima);
    }

    public IEnumerable<Cliente> ClientesPorEstadoCivil(string estadoCivil){
        return clientes.Where(c => estadoCivil.Equals(estadoCivil, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<Cliente> ClientesEmOrdemAlfabetica(){
        return clientes.OrderBy(c => c.Nome);
    }

    public IEnumerable<Cliente> ClientesPorProfissao(string textoProfissao){
        return clientes.Where(c => c.Profissao.Contains(textoProfissao, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<object> AniversariantesDoMes(int mes){
        return advogados.Concat(clientes)
            .Where(p => p.DataNascimento.Month == mes)
            .OrderBy(p => p.DataNascimento.Day);
    }

    private int CalculaIdade(DateTime dataNascimento){
        int idade = DateTime.Now.Year - dataNascimento.Year;
        if (DateTime.Now.Month < dataNascimento.Month || (DateTime.Now.Month == dataNascimento.Month && DateTime.Now.Day < dataNascimento.Day)){
            idade--;
        }

        return idade;
    }
}


class Operacoes{
    public static void AdicionarAdvogado(EscritorioAdvocacia escritorio){
        try{
            Advogado advogado = new Advogado();

            Console.WriteLine("=====CADASTRO DE ADVOGADO(A)=====");
            
            Console.WriteLine("Nome: ");
            advogado.Nome = Console.ReadLine();

            Console.WriteLine("Data de Nascimento (yyyy-mm-dd): ");
            advogado.DataNascimento = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("CPF: ");
            advogado.CPF = Console.ReadLine();
            
            Console.WriteLine("CNA: ");
            advogado.CNA = Console.ReadLine();

            escritorio.AdicionarAdvogado(advogado);
            Console.WriteLine("Advogado cadastrado com sucesso!");
        }
        catch(Exception ex){
            Console.WriteLine($"Erro ao cadastrar advogado: {ex.Message}");
        }
    }

}
class Program{
    static void Main(){

        EscritorioAdvocacia escritorio = new EscritorioAdvocacia();

        while(true){
            Console.WriteLine("\n=====MENU=====");
            Console.WriteLine("1. Cadastrar Advogado(a)");
            Console.WriteLine("2. Cadastrar Cliente");
            Console.WriteLine("3. Consultar Advogados(as) Cadastrados(as)");
            Console.WriteLine("4. Consultar Clientes Cadastrados(as)");
            Console.WriteLine("5. Relatórios");
            Console.WriteLine("6. Sair");

            Console.WriteLine("\nEscolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao){
                case "1":
                    AdicionarAdvogado(escritorio);
                    break;
                /*case "2":
                    AdicionarCliente(escritorio);
                    break;
                case "3":
                    ConsultarAdvogados(escritorio);
                    break;
                case "4":
                    CansultarClientes(escritorio);
                    break;
                case "5":
                    ExibirRelatorios(escritorio);
                    break;*/
                case "6":
                    Console.WriteLine("Encerrando programa.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}

#endregion