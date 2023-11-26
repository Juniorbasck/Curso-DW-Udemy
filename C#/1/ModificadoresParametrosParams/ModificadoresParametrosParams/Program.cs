namespace ModificadoresParametrosParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculetor.Sum(2, 3, 4);
            int s2 = Calculetor.Sum(8, 9);

            Console.WriteLine(s1);
            Console.WriteLine(s2);


            int num = 10;
            int triple; 
            Calculetor.Triple(num, out triple);
            Console.WriteLine(triple);

            // Diferença entre Ref e Out: ref Deve ter sido iniciada, Out não precisa ter sido iniciada
        }
    }
}