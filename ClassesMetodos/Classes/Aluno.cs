using System.Reflection.Metadata.Ecma335;

namespace ClassesMetodos.Classes
{
    public class Aluno
    {
        public int Indice { get; set; }
        public double Ra { get; set; }
        public string Nome { get; set; }
        public double Nota1bim { get; set; }
        public double Nota2bim { get; set; }
        public string Turma { get; set; }
        public double CalcularMedia()
        {
            return (Nota1bim + Nota2bim) / 2;
        }

        public string RetornarSitacao()
        {
            if (CalcularMedia() < 4)
            {
                return "Reprovado";
            } 
            else if (CalcularMedia() >4 && CalcularMedia() <7)
            {
                return "De final";
            }
            else
            {
                return "Aprovado";
            }
        }
    }
}
