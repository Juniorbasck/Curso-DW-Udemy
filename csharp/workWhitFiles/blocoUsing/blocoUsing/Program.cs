using System;


class program
{
    static void Main(string[] args)
    {
        string path = "/home/adilson/Documentos/file1";


        try
        {
            using (StreamReader sr = File.OpenText(path)) 
            { 
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occured");
            Console.WriteLine(e.Message);
        }
    }
}


