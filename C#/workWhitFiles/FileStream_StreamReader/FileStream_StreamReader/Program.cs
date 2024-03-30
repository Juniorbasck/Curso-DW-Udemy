// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

class Program
{
    static void main(string[] args)
    {
        string path = "/home/junior/Documentos/file1";

        FileStream fs = null;
        StreamReader sr = null;

        try
        {
            fs = new FileStream(path, FileMode.Open);
            sr = new StreamReader(fs);

            string line = sr.ReadLine();
        }
        catch (IOException e)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if ( sr !=  null) sr.Close();
            if ( fs != null) fs.Close();
        }
    }
}