// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string path = "/home/junior/Documentos/file1";

        
        StreamReader sr = null;
        try
        {
            sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if ( sr !=  null) sr.Close();
        }
    }
}