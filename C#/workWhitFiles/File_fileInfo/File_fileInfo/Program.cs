// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

class  program
{
    static void Main(string[] args)
    {
        string sourcePath = "/home/Adilson/Pessoal/Estudos/Curso-DW-Udemy/C#/workWhitFiles/Usesfiles/teste.txt";
        
        string targetpath = "~/Adilson/Pessoal/Estudos/Curso-DW-Udemy/C#/workWhitFiles/Usesfiles/teste2.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetpath);
        }
        catch(IOException e)
        {
            Console.WriteLine("an error occurred");
            Console.WriteLine(e.Message);
        }
    }
}
