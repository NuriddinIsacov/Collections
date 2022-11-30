using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLessons
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<char> toplam1 = new List<char> { 'a', 'b', 'c', 'd' };        //  X to'plam

            List<char> toplam2 = new List<char> { 'b', 'c', 'd', 'e' };         // Y to'plam

            List<char> toplam3 = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };     //Umumiy to'plam

            // 1 - ish

            List<char> resultToplam1 = new List<char> { 'b', 'c', 'd', 'e' };

            foreach (char c in toplam1)
            {
                if(!resultToplam1.Contains(c))
                    resultToplam1.Add(c);
            }

            resultToplam1 = null;


            //2 - ish
            List<char> resultToplam2 = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            foreach (var item in toplam2)
            {
                if(resultToplam2.Contains(item))
                    resultToplam2.Remove(item);
            }

            //3 - ish   RESULT = reverseToplam
            List<char> reverseToplam = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            foreach (var item in toplam1)
            {
                if (reverseToplam.Contains(item))
                    reverseToplam.Remove(item);
            }

            foreach (var item in toplam2)
            {
                if (reverseToplam.Contains(item))
                    reverseToplam.Remove(item);
            }

            //4 - ish

            List<char> resultToplam4 = resultToplam2;
            List<char> tempToplam = toplam1;

            foreach (var item in toplam1)
            {
                if (resultToplam4.Contains(item))
                {
                    resultToplam4.Remove(item);
                    tempToplam.Remove(item);
                }
            }

            resultToplam4 = resultToplam4.Concat(tempToplam).ToList();

            //5 - ish   RESULT = reversX
            List<char> reversX = new List<char>();
            //reversY = resultToplam2
            foreach (var item in toplam3)
            {
                if (!toplam1.Contains(item))
                    reversX.Add(item);
            }

            foreach (var item in reversX)
            {
                if (resultToplam2.Contains(item))
                    reversX.Remove(item);
            }

        }
    }
}
