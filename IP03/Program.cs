using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<(int, string, int, double)> estoque = new List<(int, string, int, double)>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("==== Sistema de Gerenciamento de Estoque ====");
            Console.WriteLine("1. Listar Produtos");
            Console.WriteLine("2. Cadastrar Novo Produto");
            Console.WriteLine("3. Consultar Produto por Código");
            Console.WriteLine("4. Atualizar Estoque");
            Console.WriteLine("5. Relatórios");
            Console.WriteLine("0. Sair");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ListarProdutos();
                    break;
                case "2":
                    CadastrarProduto();
                    break;
                case "3":
                    ConsultarProdutoPorCodigo();
                    break;
                case "4":
                    AtualizarEstoque();
                    break;
                case "5":
                    GerarRelatorios();
                    break;
                case "0":
                    Console.WriteLine("Saindo do sistema. Até mais!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void ListarProdutos()
    {
        if (estoque.Any())
        {
            Console.WriteLine("==== Lista de Produtos ====");
            foreach (var produto in estoque)
            {
                Console.WriteLine($"Código: {produto.Item1}, Nome: {produto.Item2}, Quantidade: {produto.Item3}, Preço: {produto.Item4:C}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum produto cadastrado no estoque.");
        }
    }

    static void CadastrarProduto()
    {
        try
        {
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitário: ");
            double preco = double.Parse(Console.ReadLine());

            estoque.Add((codigo, nome, quantidade, preco));

            Console.WriteLine("Produto cadastrado com sucesso!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato inválido. Certifique-se de inserir valores corretos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void ConsultarProdutoPorCodigo()
    {
        Console.Write("Digite o código do produto: ");
        int codigo = int.Parse(Console.ReadLine());

        var produto = estoque.FirstOrDefault(p => p.Item1 == codigo);

        if (produto != default)
        {
            Console.WriteLine($"Código: {produto.Item1}, Nome: {produto.Item2}, Quantidade: {produto.Item3}, Preço: {produto.Item4:C}");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }

    static void AtualizarEstoque()
    {
        Console.Write("Digite o código do produto: ");
        int codigo = int.Parse(Console.ReadLine());

        var produto = estoque.FirstOrDefault(p => p.Item1 == codigo);

        if (produto != default)
        {
            Console.WriteLine($"Produto: {produto.Item2}, Quantidade atual em estoque: {produto.Item3}");
            
            Console.Write("Digite a quantidade a ser adicionada (positivo) ou removida (negativo): ");
            int quantidadeAtualizacao = int.Parse(Console.ReadLine());

            int novaQuantidade = produto.Item3 + quantidadeAtualizacao;

            if (novaQuantidade < 0)
            {
                Console.WriteLine("Erro: Não há quantidade suficiente para a retirada.");
            }
            else
            {
                int index = estoque.FindIndex(p => p.Item1 == codigo);
                estoque[index] = (codigo, produto.Item2, novaQuantidade, produto.Item4);
                Console.WriteLine($"Estoque atualizado com sucesso. Nova quantidade: {novaQuantidade}");
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }

    static void GerarRelatorios()
    {
        Console.WriteLine("==== Relatórios ====");
        Console.WriteLine("1. Lista de produtos com quantidade abaixo de um limite");
        Console.WriteLine("2. Lista de produtos com valor entre um mínimo e um máximo");
        Console.WriteLine("3. Valor total do estoque e valor total de cada produto");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.Write("Digite o limite de quantidade: ");
                int limiteQuantidade = int.Parse(Console.ReadLine());
                var produtosAbaixoLimite = estoque.Where(p => p.Item3 < limiteQuantidade);
                foreach (var produto in produtosAbaixoLimite)
                {
                    Console.WriteLine($"Código: {produto.Item1}, Nome: {produto.Item2}, Quantidade: {produto.Item3}, Preço: {produto.Item4:C}");
                }
                break;
            case "2":
                Console.Write("Digite o valor mínimo: ");
                double minimo = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor máximo: ");
                double maximo = double.Parse(Console.ReadLine());

                var produtosNoIntervalo = estoque.Where(p => p.Item4 >= minimo && p.Item4 <= maximo);
                foreach (var produto in produtosNoIntervalo)
                {
                    Console.WriteLine($"Código: {produto.Item1}, Nome: {produto.Item2}, Quantidade: {produto.Item3}, Preço: {produto.Item4:C}");
                }
                break;
            case "3":
                double valorTotalEstoque = estoque.Sum(p => p.Item3 * p.Item4);
                Console.WriteLine($"Valor total do estoque: {valorTotalEstoque:C}");

                foreach (var produto in estoque)
                {
                    double valorProduto = produto.Item3 * produto.Item4;
                    Console.WriteLine($"Código: {produto.Item1}, Nome: {produto.Item2}, Valor total: {valorProduto:C}");
                }
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}

