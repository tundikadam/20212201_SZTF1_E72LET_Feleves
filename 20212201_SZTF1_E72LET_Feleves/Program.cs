using System;

namespace _20212201_SZTF1_E72LET_Feleves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a bemeneti szöveget!");
            string bemenetiszoveg = Console.ReadLine();
            ;
            Console.WriteLine("Adja meg a képszélességet");
            int kepszelesseg = int.Parse(Console.ReadLine());
            Kep kepneve = new Kep();
            Random r1 = new Random();
            Pixel pixelneve = new Pixel(r1);


            string szoveg2 = kepneve.Lecsupaszit(bemenetiszoveg);
            string szoveg3 = kepneve.ÉkezetescsereÉsMéretezés(szoveg2);
            string szoveg4 = kepneve.NégyzettéAlakítás(szoveg3);

            string kisbetu = "";
            string nagybetu = "";
            string szam = "";


            int[,] Rtomb = new int[(int)Math.Sqrt(szoveg4.Length), (int)Math.Sqrt(szoveg4.Length)];
            int[,] Gtomb = new int[(int)Math.Sqrt(szoveg4.Length), (int)Math.Sqrt(szoveg4.Length)];
            int[,] Btomb = new int[(int)Math.Sqrt(szoveg4.Length), (int)Math.Sqrt(szoveg4.Length)];
            int[,] Rteljes = new int[kepszelesseg, kepszelesseg];
            int[,] Gteljes = new int[kepszelesseg, kepszelesseg];
            int[,] Bteljes = new int[kepszelesseg, kepszelesseg];
            int[] Rbeolvasott = new int[(int)Math.Pow(kepszelesseg, 2)];
            int[] Gbeolvasott = new int[(int)Math.Pow(kepszelesseg, 2)];
            int[] Bbeolvasott = new int[(int)Math.Pow(kepszelesseg, 2)];
            kepneve.Kodtomb(szoveg4, ref Rtomb, ref Gtomb, ref Btomb, pixelneve.Red, pixelneve.Green, pixelneve.Blue);
            kepneve.TeljesKeppeKiegeszit(kepszelesseg, pixelneve.Red, pixelneve.Green, pixelneve.Blue, Rtomb, Gtomb, Btomb, ref Rteljes, ref Gteljes, ref Bteljes);
            kepneve.FájbaÍras(ref Rteljes, ref Gteljes, ref Bteljes);
            kepneve.FájlBeolvasás(ref Rbeolvasott, ref Gbeolvasott, ref Bbeolvasott);
            kepneve.Visszafejtes(Rbeolvasott, Gbeolvasott, Bbeolvasott, ref kisbetu, ref nagybetu, ref szam);
            string visszafejtett = kepneve.Összefuttatas(kisbetu, nagybetu, szam);


            Console.WriteLine("A dekódolt szöveg: " + visszafejtett);
        }
    }
}
