internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mat = new int[3,3];

        for(int l=0; l < 3; l++)
        {
            for(int c=0; c < 3; c++)
            {
                mat[l,c] = int.Parse(Console.ReadLine());
            }
        }

        //impressao da primeira coluna

        for (int l = 0; l < 3; l++)
        {
            Console.WriteLine(mat[l, 0]);
        }

        //impressao de todas as lihas de cada coluna


        for (int l = 0; l < 3; l++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(mat[l, c] + " ");
            }
            Console.WriteLine();
        }

        //diagonal principal 

        for (int l = 0; l < 3; l++)
        {
            Console.WriteLine(mat[l, l]);
        }

        //diagonal segundaria

        for (int l = 0; l < 3; l++)
        {
            for(int c = 2; c >= 0; c--)
            {
                Console.WriteLine(mat[l,c]);
            }
        }

        //teste

        for (int l = 0; l < 3; l++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(mat[l,c]+" ");
            }
            Console.WriteLine();
        }
    }
}