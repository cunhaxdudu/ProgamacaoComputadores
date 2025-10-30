using System.IO;

Console.WriteLine("===Atividade Arquivos 2° Bimestre - 21.10.2025===");
Console.WriteLine("\nIntegrantes:");
Console.WriteLine("Eduardo da Cunha");
Console.WriteLine("Octavio Henrique Knupp Lucio");
Console.WriteLine("Nícolas Joly Mussi");
Console.WriteLine("Alexandre Aielo Lima");

var ListaItens = new List<string>();
Executar();

void Executar()
{
    string dataAtual = DateTime.Now.ToString("yyyy_MM_dd");
    var caminhoArquivo = $"C:\\Users\\cunha\\Downloads\\Crud_Atividade_Arquivo_2Bim_{dataAtual}.txt";

    CriarArquivo(caminhoArquivo);
    ListaItens = LerArquivo(caminhoArquivo).ToList(); // carrega itens existentes no arquivo

    while (true)
    {
        try
        {
            Console.WriteLine("\n=Cadastramento de itens=");
            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Inserir Novo Item");
            Console.WriteLine("3 - Alterar Item Existente");
            Console.WriteLine("4 - Excluir Item");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite uma opção: ");

            string opcao = Console.ReadLine();
            bool opcaoValida = int.TryParse(opcao, out int opcaoInt);

            if (!opcaoValida)
            {
                Console.WriteLine("Entrada não é um número. Digite uma opção de 0 a 4.");
                continue;
            }

            switch (opcaoInt)
            {
                case 1:
                    ListarItens(caminhoArquivo);
                    break;

                case 2:
                    Console.Write("\nInserir Novo Item: ");
                    string novoItem = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(novoItem))
                    {
                        Console.WriteLine("Item inválido!");
                        break;
                    }

                    ListaItens.Add(novoItem);
                    InserirNovoArquivo(caminhoArquivo, $"{novoItem}");
                    Console.WriteLine("Item adicionado com sucesso!");
                    break;

                case 3:
                    AlterarItem(caminhoArquivo);
                    break;

                case 4:
                    ExcluirItem(caminhoArquivo);
                    break;

                case 0:
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"\n{DateTime.Now} - Erro: O arquivo não foi encontrado.");
            Console.WriteLine($"\nDetalhes: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n{DateTime.Now} - Ocorreu um erro inesperado: {ex.Message}");
            throw;
        }
    }
}

void CriarArquivo(string caminhoArquivo)
{
    try
    {
        if (!File.Exists(caminhoArquivo))
        {
            var fs = File.Create(caminhoArquivo);
            fs.Close();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nErro ao criar o arquivo: {ex.Message}");
        throw;
    }
}

string[] LerArquivo(string arquivoNome)
{
    try
    {
        if (!File.Exists(arquivoNome))
            return new string[] { };

        var linhas = File.ReadAllLines(arquivoNome);
        return linhas;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nErro ao ler o arquivo: {ex.Message}");
        return new string[] { };
    }
}

void InserirNovoArquivo(string arquivoNome, string linha)
{
    try
    {
        File.AppendAllText(arquivoNome, $"{linha}\n");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nErro ao inserir no arquivo: {ex.Message}");
        throw;
    }
}

void ListarItens(string caminhoArquivo)
{
    try
    {
        Console.WriteLine("\n=Listagem de Itens=");
        var linhas = LerArquivo(caminhoArquivo);

        if (linhas.Length == 0)
        {
            Console.WriteLine("Nenhum item cadastrado.");
            return;
        }

        for (int i = 0; i < linhas.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {linhas[i]}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nErro ao listar itens: {ex.Message}");
        throw;
    }
}

void AlterarItem(string caminhoArquivo)
{
    try
    {
        var linhas = LerArquivo(caminhoArquivo).ToList();

        if (linhas.Count == 0)
        {
            Console.WriteLine("Nenhum item para alterar.");
            return;
        }

        ListarItens(caminhoArquivo);
        Console.Write("\nDigite o número do item que deseja alterar: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= linhas.Count)
        {
            Console.Write("Digite o novo item: ");
            string novoValor = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(novoValor))
            {
                Console.WriteLine("Valor inválido.");
                return;
            }

            linhas[indice - 1] = novoValor;
            File.WriteAllLines(caminhoArquivo, linhas);
            ListaItens = linhas;
            Console.WriteLine("Item alterado com sucesso!");
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nErro ao alterar item: {ex.Message}");
        throw;
    }
}

void ExcluirItem(string caminhoArquivo)
{
    try
    {
        var linhas = LerArquivo(caminhoArquivo).ToList();

        if (linhas.Count == 0)
        {
            Console.WriteLine("Nenhum item para excluir.");
            return;
        }

        ListarItens(caminhoArquivo);
        Console.Write("\nDigite o número do item que deseja excluir: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= linhas.Count)
        {
            linhas.RemoveAt(indice - 1);
            File.WriteAllLines(caminhoArquivo, linhas);
            ListaItens = linhas;
            Console.WriteLine("Item excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nErro ao excluir item: {ex.Message}");
        throw;
    }
}
