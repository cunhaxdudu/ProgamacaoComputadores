using System.Reflection.Metadata.Ecma335;

namespace ClassesMetodos.Classes
{
    public static class GerenciarArquivo
    {
        public static void Excrever(string arquivo, List<string> linhas) 
        {
            File.WriteAllLines(arquivo, linhas);
        }

        public static List<string> LerArquivoParcial(string arquivo)
        {
            var linhas = new List<string>();
            var sr = new StringReader(arquivo);
            var linha = sr.ReadLine();
            while (linha != null)
            {
                linhas.Add(linha);
                if (linha.Length > 1000)
                {
                    break;
                }
            }
            return linhas;
        }

        public static List<string> LerArquivo(string arquivo)
        { 
            return File.ReadAllLines(arquivo).ToList();
        }
    }
}
