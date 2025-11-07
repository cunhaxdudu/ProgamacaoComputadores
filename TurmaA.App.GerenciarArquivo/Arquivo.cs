namespace TurmaA.App.GerenciarArquivo
{
    public static class Arquivo
    {
        public static List<string> Ler(string arquivo)
        {
            return File.ReadAllLines(arquivo).ToList();
        }
        public static List<string> LerParcial(string arquivo)
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
        public static void Excrever(string arquivo, List<string> linhas)
        {
            var test = new Carro();
            File.WriteAllLines(arquivo, linhas);
        }
    }
}
