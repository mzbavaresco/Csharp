using System;
using System.IO;

namespace LeituraEscritaArq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor=ConsoleColor.DarkBlue;
            try
            {

            
            string diretorio= @"C:\Users\Mauricio\Desktop\Atividades\CSharp\leituraEscritaArq\LeituraEscritaArq\LeituraEscritaArq\TextoFile.txt";
            StreamWriter wr = new StreamWriter(diretorio, true);
            wr.WriteLine("Primeira linha");
            wr.WriteLine("Segunda linha");
            wr.Close();
            StreamReader rd = new StreamReader(diretorio);
            while (!rd.EndOfStream) 
            {
                string linha=rd.ReadLine();
                Console.WriteLine(linha);
            }
            rd.Close();


            }catch(Exception e) 
            {
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
