using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Diamantes.ConsoleApp
{
    public class Program
    {
        public static Dictionary<int, char> alfabeto = new Dictionary<int, char>
            {
                {1 ,'a'},
                {2, 'b'},
                {3, 'c'},
                {4, 'd'},
                {5, 'e'},
                {6, 'f'},
                {7, 'g'},
                {8, 'h'},
                {9, 'i'},
                {10, 'j'},
                {11, 'k'},
                {12, 'l'},
                {13, 'm'},
                {14, 'n'},
                {15, 'o'},
                {16, 'p'},
                {17, 'q'},
                {18, 'r'},
                {19, 's'},
                {20, 't'},
                {21, 'u'},
                {22, 'v'},
                {23, 'w'},
                {24, 'x'},
                {25, 'y'},
                {26, 'z'}
            };

        public static void Main(string[] args)
        {
            Console.Write("Digite uma letra: ");
            char letra = Convert.ToChar(Console.ReadLine());

            int numeroEspacosFora = 0;
            int numeroEspacosDentro = -1;

            foreach (KeyValuePair<int,char> item in alfabeto)
                if (item.Value == letra)
                    numeroEspacosFora = item.Key;

            // escrevendo a primeira parte
            for (int i = 1; i <= numeroEspacosFora; i++)
            {
                for (int j = numeroEspacosFora - i; j > 0; j--)                                    
                    Console.Write(" ");
                
                Console.Write(alfabeto[i].ToString().ToUpper());

                for (int k = 0;  k < numeroEspacosDentro; k++)
                    Console.Write(" ");

                if (i != 1)
                   Console.Write(alfabeto[i].ToString().ToUpper());

                Console.WriteLine();
                numeroEspacosDentro += 2;
            }

            // escrevendo invertido
            for (int i = numeroEspacosFora - 1; i >= 1; i--)
            {
                for (int j = numeroEspacosFora - i; j > 0; j--)
                    Console.Write(" ");

                Console.Write(alfabeto[i].ToString().ToUpper());


                for (int k = numeroEspacosDentro - 4; k > 0 ; k--)
                    Console.Write(" ");

                if (i != 1)
                    Console.Write(alfabeto[i].ToString().ToUpper());

                Console.WriteLine();
                numeroEspacosDentro -= 2;
            }

            Console.ReadLine();
        }
    }
}
