Executar();
void Executar()
{
    var arqv = @"C:\Users\cunha\OneDrive\Documents\Projetos\2ESAN\Programação de Computadores\2° Bimestre\ProgComp2\ArquivoCsv\Teste.csv";
    string[] linhas = LerArquivo(arqv).Skip(1).ToArray();
    foreach (var linha in linhas)
    {
        string[] colunas = linha.Split(";");
       
        string nomeAluno = colunas[1];
        if (double.TryParse(colunas[2], out double n1) == false){
            Console.WriteLine($"Erro ao converter nota 1. Linha{linha}");
        }
        if (double.TryParse(colunas[3], out double n2) == false){
            Console.WriteLine($"Erro ao converter nota 2. Linha{linha}");
        }
        double media = (n1 + n2) / 2;
        var listaMedias = new List<double>();
        listaMedias.Add(media);
        string situacao = "";
        if (media < 7)
        {
            situacao = "Reprovado";
        }
        else 
        {
            situacao = "Aprovado";
        }

        Console.WriteLine($"Nome:{nomeAluno.PadRight(10)} Média:{media.ToString().PadRight(10)} Situação: {situacao}");
        //Console.WriteLine($"Aluno c/ maior média:{nomeAlunoMaiorNota} , {listaMedias.Max()}");
        //for (int i = 0; i < colunas.Length; i++)
        //{
        //    Console.Write(colunas[i].PadRight(15));
        //}
        Console.WriteLine();
    }
}

string[] LerArquivo(string arq)
{
    try
    {
        var linhas = File.ReadAllLines(arq);
        return linhas;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n{DateTime.Now} -Ocorreu um erro inesperado, parando aplicação... {ex}");
        throw ex;
    }
}

void EscreverArquivo(string arq, List<string> linhas)
{
    try
    {
        File.WriteAllLines(arq, linhas);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n{DateTime.Now} -Ocorreu um erro inesperado, parando aplicação... {ex}");
        throw ex;
    }
}