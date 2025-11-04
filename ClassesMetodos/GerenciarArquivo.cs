namespace ClassesMetodos.Classes
{
    public static class GerenciarArquivo
    {
        public static List<string> LerArquivo(string arquivo)
        { 
            return File.ReadAllLines(arquivo).ToList();
        }
    }
}
