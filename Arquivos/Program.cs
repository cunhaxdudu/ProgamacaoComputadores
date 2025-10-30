//Aula Arquivos 14.10.25

Executar();
void Executar()
{
    var arquivoEntrada = "C:\\Users\\cunha\\Downloads\\10PalavrasAleatórias.txt";
    var arquivoSaida = "C:\\Users\\cunha\\Downloads\\Teste_append.txt";
    EscreverArquivo2(arquivoSaida, "Teste 123");
    EscreverArquivo2(arquivoSaida, "Teste 321");

    var linhas = new List<string>();

    EscreverArquivo3(arquivoSaida, linhas);

    //var linhas = LerArquivo(arquivoEntrada);
    var linhasPares = new List<string>(linhas);

    int idx = 0;
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
        if (idx % 2 == 0)
        {
            linhasPares.Add(linha);
        }
        idx++;
    }

 
}
string[] LerArquivo(string arquivoNome)
{
    try
    {
        var linhas = File.ReadAllLines(arquivoNome);
        return linhas;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n{DateTime.Now} -Ocorreu um erro inesperado, parando aplicação... {ex}");
        //throw ex;
        return new string[] { };
    }
}

//void EscreverArquivo(string arquivoNome, List<string> linhas)
//{
//    try
//    {
//        File.WriteAllLines(arquivoNome, linhas);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"\n{DateTime.Now} -Ocorreu um erro inesperado, parando aplicação... {ex}");
//        throw ex;
//    }
//}

void EscreverArquivo2(string arquivoNome, string linha)
{
    try
    {
        File.AppendAllText(arquivoNome, $"{linha}\n");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n{DateTime.Now} -Ocorreu um erro inesperado, parando aplicação... {ex}");
        throw ex;
    }
}

void EscreverArquivo3(string arquivoNome, List<string> linhas)
{
    try
    {
        
        File.AppendAllLines(arquivoNome, linhas);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n{DateTime.Now} -Ocorreu um erro inesperado, parando aplicação... {ex}");
        throw ex;
    }
}

void AddLinhaArquivo(string arquivoNome, string linhas)
{
    try
    {

        var sw = new StreamWriter(arquivoNome, false);
        //abre loop
        sw.WriteLine(linhas);
        //fecha loop
        sw.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n{DateTime.Now} -Ocorreu um erro inesperado, parando aplicação... {ex}");
        throw ex;
    }
}

void LerStreamReader(string arquivoNome)
{
    try
    { 
        var sr = new StreamReader(arquivoNome);
        var linha = sr.ReadLine();
        while (linha != null)
        {
            //Console.WriteLine(linha);
            linha = sr.ReadLine();
        }
        sr.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n{DateTime.Now} -Ocorreu um erro inesperado, parando aplicação... {ex}");
        throw ex;
    }
}