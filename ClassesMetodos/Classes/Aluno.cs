using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ClassesMetodos.Classes
{
    public class Aluno
    {
        private int QtdAulasSemestre = 80;
        private double NotaMinimaAprovacao = 7.0;
        public int Indice { get; set; }
        public double Ra { get; set; }
        public string Nome { get; set; }
        public double Nota1bim { get; set; }
        public double Nota2bim { get; set; }
        public string Turma { get; set; }
        public int QtdFaltas { get; set; }
        public double Media()
        {
            return (Nota1bim + Nota2bim) / 2;
        }

        private bool Aprovado()
        {
            if (this.Media() < 7)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ReprovadoFalta()
        {
            double qtdFaltasReprovado = this.QtdAulasSemestre * 0.25;
            if (this.QtdFaltas <= qtdFaltasReprovado)
            {
                return false;
            }
            return true;
        }

        private string Situacao()
        {
            if (this.ReprovadoFalta())
            {
                return "Reprovado por falta";
            }
            if (this.Aprovado())
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }

        /*
        public string RetornarSitacao()
        {
            if (Media() < 4)
            {
                return "Reprovado";
            }
            else if (Media() > 4 && Media() < 7)
            {
                return "De final";
            }
            else
            {
                return "Aprovado";
            }
        }
        */

        public void ExibirInfo()
        {
            Console.WriteLine($"\n===Informações do aluno nº{this.Indice}===");
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"RA: {this.Ra}");
            Console.WriteLine($"Nota 1° Bim: {this.Nota1bim}");
            Console.WriteLine($"Nota 2° Bim: {this.Nota2bim}");
            Console.WriteLine($"Média: {this.Media()}");
            Console.WriteLine($"Situação: {this.Situacao()}");
            Console.WriteLine($"Turma: {this.Turma}");
        }
    }
}