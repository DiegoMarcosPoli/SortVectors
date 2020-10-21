using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vett = new int[10];
            Random r = new Random();
            for (int i = 0; i < vett.Length; i++)
            {
                vett[i] = r.Next(-20, 25);
                Console.WriteLine(vett[i]);                
            }
            Console.WriteLine();
            Console.ReadKey();
            Ordina(vett);
            int max = Massimo(vett);
            for (int i = 0; i < vett.Length; i++)
            {
                Console.WriteLine(vett[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("il valore massimo è " + max);
            
            Console.ReadKey();
        }
        public static void Ordina(int[] v)
        {
            Array.Sort(v);
        }
        public static int Massimo(int[] v)
        {
            return v[9];
        }
    }
}
