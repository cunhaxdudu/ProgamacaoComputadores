//Aula Tratamento de Erros - 30.09.25

while (true)
{
    try
    {
        Console.WriteLine("escreva qual erro deseja testar: indice/divisao/parse");
        string teste = Console.ReadLine();

        if (teste == "indice")
        {
            string[] palavras = new string[]
            {"teste", "abc", "erro"}; 

            int idx = new Random().Next(0, 50);
            string palavra = palavras[idx];
            double result = idx / 0;

            Console.WriteLine(palavra);
        }
        if (teste == "divisao")
        {
            int i = 123;
            double result = i / 0;
        }
        if (teste == "parse")
        {
            int a = int.Parse("abc");
        }
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"{DateTime.Now} -Ocorreu um erro, erro de parse. {ex}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"{DateTime.Now} -Ocorreu um erro, divisão por zero. {ex}");
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine($"{DateTime.Now} -Ocorreu um erro, o índice não existe. {ex}");
    }
    catch (Exception ex)
    {
        string msgErro = ex.ToString();
        Console.WriteLine($"{DateTime.Now} -Ocorreu um erro ao acessar o índice do array. {msgErro}");
        throw;
    }
    Console.ReadKey();
}

