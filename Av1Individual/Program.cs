#region Sistema de Gerenciamento de Escritórios de Advocacia

class Advogado{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }
    public string CNA { get; set; }
}

class Cliente{
    public string Nome { get; set;}
    public DateTime DataNascimento {get; set; }
    public string CPF { get; set; }
    public string EstadoCivil { get; set; }
    public string Profissao {get; set;}
}


class EscritorioAdvocacia{
    private List<Advogado> advogados = new List<Advogado>();
    private List<Cliente> clientes = new List<Cliente>();

    public void AdicionarAdvogado(Advogado advogado){
        if (advogados.Any(a => a.CPF == advogado.CPF || a.CNA == advogado.CNA)){
            throw new ArgumentException("CPF ou CNA já cadastrados.");
        }

        advogados.Add(advogado);
    }

    public void AdicionarCliente(Cliente cliente){
        
    }
}

#endregion