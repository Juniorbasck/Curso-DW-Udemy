
class program
{
    static void Main(string[] args)
    {
        string path = "/home/adilson/Documentos/file1";
        string targPAth = "/home/adilson/Documentos/file2";
        
        try
        {
            string[] lines = File.ReadAllLines(path);

            using (StreamWriter sw = File.AppendText(targPAth))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
        catch(IOException)
        {
            Console.WriteLine("an error ocurred");
        }
    }
}