using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string [10];
            float[] nota1 = new float [10];
            float[] nota2 = new float [10];
            float[] nota3 = new float [10];
            float[] nota4 = new float [10];
            float[] media = new float [10];

            for (var i = 0; i < 10; i++){
                Console.WriteLine("Digite o nome do aluno: ");
                nome[i] = Console.ReadLine();
                Console.Write("Digite a nota do aluno: ");
                nota1[i] = float.Parse(Console.ReadLine());
                Console.Write("Digite a nota do aluno: ");
                nota2[i] = float.Parse(Console.ReadLine());
                Console.Write("Digite a nota do aluno: ");
                nota3[i] = float.Parse(Console.ReadLine());
                Console.Write("Digite a nota do aluno: ");
                nota4[i] = float.Parse(Console.ReadLine());
                
                media[i] = ((nota1[i] + nota1[2] + nota3[i] + nota4[i]) /4);
            }
            for (var i = 0; i < 10; i++){
                if(media[i] >=7){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O aluno {nome[i]} ficou com a media: {media[i]}");
                    Console.WriteLine("Aprovado");
                    Console.WriteLine();
                }else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O aluno {nome[i]} ficou com a media: {media[i]}");
                    Console.WriteLine("Reprovado");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("");
            float mediaGeral = (media[1] + media[2] + media[3] + media[4]) + media[5] + media[6] + media[7] + media[8] + media[9] + media[10]/ 10;
            Console.WriteLine("A media geral foi de " + mediaGeral + " Pontos ao total");
        }
    }
}
