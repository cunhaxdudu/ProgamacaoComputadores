using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Atividade Array - 16/09/2025");
        Console.WriteLine(" Integrantes");
        Console.WriteLine(" - 202510478 - Eduardo da Cunha;");
        Console.WriteLine(" - 2025106940 - Octavio Henrique Knupp Lucio;");
        Console.WriteLine(" - 2025105022 - Nícolas Joly Mussi.");

        string RetornarPalavra()
        {
            string[] palavra = new string[10];

            palavra[0] = "abacaxi";
            palavra[1] = "girassol";
            palavra[2] = "montanha";
            palavra[3] = "relogio";
            palavra[4] = "chuva";
            palavra[5] = "teclado";
            palavra[6] = "planeta";
            palavra[7] = "folclore";
            palavra[8] = "travesseiro";
            palavra[9] = "janela";

            int indice = new Random().Next(0, 9);
            return palavra[indice];
        }

        Console.WriteLine("\nJogo da Forca:");

        string palavraAtual = RetornarPalavra();
        char[] letras = palavraAtual.ToCharArray();
        char[] progresso = new string('_', palavraAtual.Length).ToCharArray(); 

        int qntTentativas = palavraAtual.Length * 2;

        for (int i = 0; i < qntTentativas; i++)
        {
            string exibicao = "";
            for (int j = 0; j < progresso.Length; j++)
            {
                exibicao += progresso[j] + " ";
            }
            Console.WriteLine("\nPalavra: " + exibicao);

            Console.Write("Informe uma letra: ");
            string letraInformada = Console.ReadLine();

            char letra = letraInformada[0];
            bool temLetra = false;

            for (int j = 0; j < letras.Length; j++)
            {
                if (letras[j] == letra)
                {
                    progresso[j] = letra;
                    temLetra = true;
                }
            }

            bool venceu = true;
            for (int j = 0; j < progresso.Length; j++)
            {
                if (progresso[j] == '_')
                {
                    venceu = false;
                    break;
                }            }


            if (venceu)
            {
                Console.WriteLine("\nVocê venceu! A palavra era: " + palavraAtual);
                return;
            }
        }

        Console.WriteLine("\nSuas tentativas acabaram! A palavra era: " + palavraAtual);
    }
}