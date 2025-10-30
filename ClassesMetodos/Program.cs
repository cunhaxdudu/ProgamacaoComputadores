using ClassesMetodos.Classes;

var al1 = RetornarAluno();
ExibirInfoAluno(al1);

var al2 = RetornarAluno();
ExibirInfoAluno(al2);
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

string RetornaTexto(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}

double RetornaValor(string msg)
{
    Console.WriteLine(msg);
    double.TryParse(Console.ReadLine(), out double valor);
    return valor;
}

Aluno RetornarAluno()
{
    var aluno = new Aluno();
    aluno.Ra = RetornaValor("Digite o R.A do Aluno: ");
    aluno.Nome = RetornaTexto("Digite o Nome do Aluno: ");
    aluno.Nota1bim = RetornaValor("Digite a Nota do 1° Bim: ");
    aluno.Nota2bim = RetornaValor("Digite a nota do 2° Bim: ");

    return aluno;
}

void ExibirInfoAluno(Aluno aluno)
{
    Console.WriteLine($"\nInformações do aluno:");
    Console.WriteLine($"Nome: {aluno.Nome}");
    Console.WriteLine($"RA: {aluno.Ra}");
    Console.WriteLine($"Nota 1° Bim: {aluno.Nota1bim}");
    Console.WriteLine($"Nota 2° Bim: {aluno.Nota2bim}");
}


