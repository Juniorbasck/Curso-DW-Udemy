// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

class  program
{
    static void Main(string[] args)
    {
        string sourcePath = "/home/junior/Documentos/file1";
        
        string targetPath = "/home/junior/Documentos/file2";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(lines);
            }
        }
        catch(IOException e)
        {
            Console.WriteLine("an error occurred");
            Console.WriteLine(e.Message);
        }
    }
}
 