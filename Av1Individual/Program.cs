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

    
}

class Program{

}

#endregion