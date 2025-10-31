using ClassesMetodos.Classes;

var listaAlunos = new List<Aluno>();

/*
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"\n--- Cadastro do {i + 1}° Aluno ---");
    var aluno = RetornarAluno();
    aluno.Indice = i +1;
    listaAlunos.Add(aluno);
}
*/

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

Aluno TransformaLinhaAluno(string linha, int indiceLinha)
{
    string[] colunas = linha.Split(";");
    var aluno = new Aluno();
    if (double.TryParse(colunas[0], out double ra) == false)
    {
        Console.WriteLine($"Erro ao ra. Linha{linha}");
    }
    aluno.Ra = ra;
    aluno.Nome = colunas[1];
    if (double.TryParse(colunas[2], out double n1) == false)
    {
        Console.WriteLine($"Erro ao converter nota 1. Linha{linha}");
    }
    if (double.TryParse(colunas[3], out double n2) == false)
    {
        Console.WriteLine($"Erro ao converter nota 2. Linha{linha}");
    }
    aluno.Nota1bim = n1;
    aluno.Nota2bim = n2;
    aluno.Turma = colunas[4];
    aluno.Indice = indiceLinha;
    return aluno;
}

var arqv = @"C:\Users\cunha\OneDrive\Documents\Projetos\2ESAN\Programação de Computadores\2° Bimestre\ProgComp2\ArquivoCsv\Teste.csv";
string[] linhas = LerArquivo(arqv).Skip(1).ToArray();

int indice = 1;
foreach (var linha in linhas) 
{
    var aluno = TransformaLinhaAluno(linha, indice);
    listaAlunos.Add(aluno);
    indice++;
}

foreach (var aluno in listaAlunos)
{
    ExibirInfoAluno(aluno);
}

/*
//Aluno RetornarAluno()
//{
//    var aluno1 = new Aluno();

//    Console.WriteLine("Digite o nome do aluno:");
//    string nomeAluno = Console.ReadLine();

//    string solicitaRa = Console.ReadLine();
//    bool raValido = int.TryParse(solicitaRa, out int raAluno);
//    if (!raValido)
//    {
//        Console.WriteLine("Ra inválido! Utilize apenas número e digite novamente.");
//    }

//    string solicitaNota1 = Console.ReadLine();
//    bool nota1Valido = int.TryParse(solicitaNota1, out int nota1BimAluno);
//    if (!nota1Valido)
//    {
//        Console.WriteLine("Nota inválida! Utilize apenas número e digite novamente.");
//    }

//    string solicitaNota2 = Console.ReadLine();
//    bool nota2Valido = int.TryParse(solicitaNota2, out int nota2BimAluno);
//    if (!nota2Valido)
//    {
//        Console.WriteLine("Nota inválida! Utilize apenas número e digite novamente.");
//    }

//    aluno.Ra = raAluno;
//    aluno.Nome = nomeAluno;
//    aluno.Nota1bim = nota1BimAluno;
//    aluno.Nota2bim = nota2BimAluno;

//    return aluno1;
//}
*/

string RetornarTexto(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}

double RetornarValor(string msg)
{
    Console.WriteLine(msg);
    double.TryParse(Console.ReadLine(), out double valor);
    return valor;
}

/*
string retornarSituacao()
{
    if
    return "";
}
*/

Aluno RetornarAluno()
{
    var aluno = new Aluno();
    aluno.Ra = RetornarValor("Digite o R.A do Aluno: ");
    aluno.Nome = RetornarTexto("Digite o Nome do Aluno: ");
    aluno.Nota1bim = RetornarValor("Digite a Nota do 1° Bim: ");
    aluno.Nota2bim = RetornarValor("Digite a nota do 2° Bim: ");

    return aluno;
}

void ExibirInfoAluno(Aluno aluno)
{
        Console.WriteLine($"\n===Informações do aluno nº{aluno.Indice}===");
        Console.WriteLine($"Nome: {aluno.Nome}");
        Console.WriteLine($"RA: {aluno.Ra}");
        Console.WriteLine($"Nota 1° Bim: {aluno.Nota1bim}");
        Console.WriteLine($"Nota 2° Bim: {aluno.Nota2bim}");
        Console.WriteLine($"Média: {aluno.CalcularMedia()}");
        Console.WriteLine($"Situação: {aluno.RetornarSitacao()}");
        Console.WriteLine($"Turma: {aluno.Turma}");
}




