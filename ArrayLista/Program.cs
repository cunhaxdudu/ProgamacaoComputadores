//Aula lista e array - 02.10.25

//List<string> palavras = new List<string>();

/*
var palavras = new List<string>();
palavras.Add("Carro");
palavras.Add("Moto");
palavras[0] = "Ônibus";

palavras.Clear();

List<Tuple<int, string>> produtos = new List<Tuple<int, string>>();
produtos.Add(new Tuple<int, string>(1, "carro"));

Dictionary<int, string> categorias = new Dictionary<int, string>();
categorias.Add(1, "carro");

/*
Console.WriteLine($"numeros: {numeros.Length}");
Console.WriteLine($"valores: {valores.Length}");
Console.WriteLine($"palavras: {palavras.Count}");

Console.WriteLine($"palavras: {palavras[0]}");


var numeros = new List<int>();

while (true)
{
    try
    {
        Console.WriteLine("\nDigite -1 para sair e mostrar valores informados. ");
        Console.Write("Digite um valor inteiro para ser armazenado: ");
        string numS = Console.ReadLine();
        bool numValido = int.TryParse(numS, out int numI);

        if (!numValido)
        {
            Console.WriteLine("\nValor inválido! Por favor, digite um número inteiro.");
            continue;
        }
        if (numI == -1)
        {
            break;
        }
        numeros.Add(numI);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n{DateTime.Now} -Ocorreu um erro inesperado, parando aplicação... {ex}");
        throw;
    }
}
int contador = numeros.Count;
Console.WriteLine($"\nVocê adicionou {contador} items. Valores informados:");
for (int i = 0; i < contador; i++)
{
    Console.Write($"{numeros[i]} ; ");
}

numeros.Sort();//ordena lista
numeros.Reverse();//inverte ordem
Console.WriteLine(string.Join(';', numeros));//concatena char em cada item
Console.WriteLine(numeros.Max());//maior
Console.WriteLine(numeros.Min());//menor
Console.WriteLine(numeros.Sum());//soma
Console.WriteLine(numeros.Average());//media
*/


//Aula Dicionario de dados - 10.07.25


//chave:valor
//chave é unica e nao permite repetição


//var alunos = new Dictionary<int, string>();
//alunos.Add(2025104798, "Eduardo");

//int ra = 2025104798;
//string nome = alunos[ra];

var produtoNome = new Dictionary<int, string>();

var produtoPreco = new Dictionary<int, double>();

int id = 0;
string nome = "";
double preco = 0;

Console.WriteLine("<===/Cadastro de Produtos/===>");
while (true)
{
    try
    {
        Console.WriteLine("\nDigite -1 para sair e mostrar itens cadastrados. ");
        Console.Write("Digite o id do produto: ");
        string idS = Console.ReadLine();
        bool idSValido = int.TryParse(idS, out id);

        if (!idSValido)
        {
            Console.WriteLine("\nValor inválido! Por favor, digite um número inteiro.");
            continue;
        }
        if (id == -1)
        {
            break;
        }
        
        Console.WriteLine("\nDigite -1 para sair e mostrar itens cadastrados. ");
        Console.Write("Escreva o nome do produto: ");
        nome = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("\nNome inválido! Por favor, preencha o campo informado com o nome do produto.");
            continue;
        }
        if (nome == "-1")
        {
            break;
        }
        
        Console.WriteLine("\nDigite -1 para sair e mostrar itens cadastrados. ");
        Console.Write("Digite o preço do produto: ");
        string precoS = Console.ReadLine();
        bool precoSValido = double.TryParse(precoS, out preco);

        if (!precoSValido)
        {
            Console.WriteLine("\nValor inválido! Por favor, digite um número inteiro.");
            continue;
        }
        if (preco == -1)
        {
            break;
        }
        
        produtoNome.Add(id, nome);
        produtoPreco.Add(id, preco);

        Console.WriteLine($"\n({nome}) cadastrado(a) com sucesso!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n{DateTime.Now} -Ocorreu um erro inesperado, parando aplicação... {ex}");
        throw;
    }
}
Console.WriteLine($"\nVocê cadastrou {produtoNome.Count} produtos. Produtos cadastrados:");
foreach (var item in produtoNome)
{
    id = item.Key;
    nome = item.Value;
    preco = produtoPreco[id];
    Console.WriteLine($"\nID: {id} - Nome: {nome} - Preço: {preco}");
}   