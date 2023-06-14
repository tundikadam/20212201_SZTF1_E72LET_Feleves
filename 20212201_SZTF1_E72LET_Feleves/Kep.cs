using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20212201_SZTF1_E72LET_Feleves
{
    internal class Kep
    {
        public Kep()
        { }














        public string Lecsupaszit(string szoveg)
        {
            string szoveg2 = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (char.IsLetterOrDigit(szoveg[i]))
                { szoveg2 = szoveg2 + szoveg[i]; }
            }
            return szoveg2;
        }
        public string ÉkezetescsereÉsMéretezés(string szoveg)
        {







            return szoveg.Replace('Á', 'A').Replace('É', 'E').Replace('Í', 'I').Replace('Ó', 'O').Replace('Ö', 'O').Replace('Ő', 'O').Replace('Ú', 'U').Replace('Ü', 'U').Replace('Ű', 'U').Replace('á', 'a').Replace('é', 'e').Replace('í', 'i').Replace('ó', 'o').Replace('ö', 'o').Replace('ő', 'o').Replace('ú', 'u').Replace('ü', 'u').Replace('ű', 'u');




        }
        public string NégyzettéAlakítás(string szoveg)
        {
            string szoveg2 = "";
            string szoveg3 = "";
            double gyok = Math.Sqrt(szoveg.Length);
            if (szoveg.Length % gyok == 0)
            { return szoveg; }
            else
            {
                int hasznosnegyzetoldal = (int)gyok + 1;
                double ujszoveghossz = Math.Pow(hasznosnegyzetoldal, 2);
                int kitoltendo = (int)ujszoveghossz - szoveg.Length;
                for (int i = 0; i < kitoltendo; i++)
                { szoveg2 = szoveg2 + '*'; }
                szoveg3 = szoveg + szoveg2;
                return szoveg3;
            }


        }




        public void Kodtomb(string szoveg, ref int[,] Rszovegben1, ref int[,] Gszovegben1, ref int[,] Bszovegben1, int rbazis, int gbazis, int bbazis)
        {
            int[] rszovegben = new int[szoveg.Length];
            int[] gszovegben = new int[szoveg.Length];
            int[] bszovegben = new int[szoveg.Length];



            for (int i = 0; i < szoveg.Length; i = i + 1)
            { rszovegben[i] = rbazis; }
            for (int i = 0; i < szoveg.Length; i = i + 1)
            { gszovegben[i] = gbazis; }
            for (int i = 0; i < szoveg.Length; i = i + 1)
            { bszovegben[i] = bbazis; }

            for (int i = 0; i < szoveg.Length - 1; i = i + 1)
            {
                if (i % 2 == 0)
                {
                    if (char.IsLower(szoveg[i]))
                    { rszovegben[i + 1] = rszovegben[i + 1] + (int)szoveg[i]; }
                    else if (char.IsUpper(szoveg[i]))
                    { gszovegben[i + 1] = gszovegben[i + 1] + (int)szoveg[i]; }
                    else if (char.IsNumber(szoveg[i]))
                    { bszovegben[i + 1] = bszovegben[i + 1] + (int)szoveg[i]; }

                }
                else
                {
                    if (char.IsLower(szoveg[i]))
                    { rszovegben[i + 1] = rszovegben[i + 1] - (int)szoveg[i]; }
                    else if (char.IsUpper(szoveg[i]))
                    { gszovegben[i + 1] = gszovegben[i + 1] - (int)szoveg[i]; }
                    else if (char.IsNumber(szoveg[i]))
                    { bszovegben[i + 1] = bszovegben[i + 1] + (int)szoveg[i]; }
                }
            }

            int indexr = 0;
            int indexg = 0;
            int indexb = 0;
            int[,] keszr = new int[(int)Math.Sqrt(szoveg.Length), (int)Math.Sqrt(szoveg.Length)];
            int[,] keszg = new int[(int)Math.Sqrt(szoveg.Length), (int)Math.Sqrt(szoveg.Length)];
            int[,] keszb = new int[(int)Math.Sqrt(szoveg.Length), (int)Math.Sqrt(szoveg.Length)];
            for (int i = 0; i < keszr.GetLength(0); i = i + 1)
            {
                for (int j = 0; j < keszr.GetLength(1); j = j + 1)
                {
                    keszr[i, j] = rszovegben[indexr];
                    indexr = indexr + 1;
                }
            }
            for (int i = 0; i < keszg.GetLength(0); i = i + 1)
            {
                for (int j = 0; j < keszg.GetLength(1); j = j + 1)
                {
                    keszg[i, j] = gszovegben[indexg];
                    indexg = indexg + 1;
                }
            }
            for (int i = 0; i < keszb.GetLength(0); i = i + 1)
            {
                for (int j = 0; j < keszb.GetLength(0); j = j + 1)
                {
                    keszb[i, j] = bszovegben[indexb];
                    indexb = indexb + 1;
                }
            }

            Rszovegben1 = keszr;
            Gszovegben1 = keszg;
            Bszovegben1 = keszb;


        }
        public void TeljesKeppeKiegeszit(int kepszelesseg, int rbazis, int gbazis, int bbazis, int[,] R, int[,] G, int[,] B, ref int[,] Rteljes, ref int[,] Gteljes, ref int[,] Bteljes)
        {
            int[,] Rkesz = new int[kepszelesseg, kepszelesseg];
            int[,] Gkesz = new int[kepszelesseg, kepszelesseg];
            int[,] Bkesz = new int[kepszelesseg, kepszelesseg];
            int kodkepszel = R.GetLength(0);
            for (int i = 0; i < kepszelesseg; i = i + 1)
            {
                for (int j = 0; j < kepszelesseg; j = j + 1)
                { Rkesz[i, j] = -1000; }
            }
            for (int i = 0; i < kepszelesseg; i = i + 1)
            {
                for (int j = 0; j < kepszelesseg; j = j + 1)
                { Gkesz[i, j] = -1000; }
            }
            for (int i = 0; i < kepszelesseg; i = i + 1)
            {
                for (int j = 0; j < kepszelesseg; j = j + 1)
                { Bkesz[i, j] = -1000; }
            }
            for (int i = 0; i < kodkepszel; i = i + 1)
            {
                for (int j = 0; j < kodkepszel; j = j + 1)
                { Rkesz[i, j] = R[i, j]; }
            }
            for (int i = 0; i < kodkepszel; i = i + 1)
            {
                for (int j = 0; j < kodkepszel; j = j + 1)
                { Gkesz[i, j] = G[i, j]; }
            }
            for (int i = 0; i < kodkepszel; i = i + 1)
            {
                for (int j = 0; j < kodkepszel; j = j + 1)
                { Bkesz[i, j] = B[i, j]; }
            }
            for (int i = 0; i < kepszelesseg; i = i + 1)
            {
                for (int j = 0; j < kepszelesseg; j = j + 1)
                {
                    if (Rkesz[i, j] == -1000)
                    {
                        Rkesz[i, j] = rbazis;
                    }
                }

            }
            for (int i = 0; i < kepszelesseg; i = i + 1)
            {
                for (int j = 0; j < kepszelesseg; j = j + 1)
                {
                    if (Gkesz[i, j] == -1000)
                    {
                        Gkesz[i, j] = gbazis;
                    }
                }

            }
            for (int i = 0; i < kepszelesseg; i = i + 1)
            {
                for (int j = 0; j < kepszelesseg; j = j + 1)
                {
                    if (Bkesz[i, j] == -1000)
                    {
                        Bkesz[i, j] = bbazis;
                    }
                }

            }
            Rteljes = Rkesz;
            Gteljes = Gkesz;
            Bteljes = Bkesz;

        }
        public void FájbaÍras(ref int[,] fajl1, ref int[,] fajl2, ref int[,] fajl3)
        {
            StreamWriter sw = new StreamWriter("eredmeny.txt", false);
            for (int i = 0; i < fajl1.GetLength(0); i++)
            {
                for (int j = 0; j < fajl1.GetLength(1); j++)
                { sw.WriteLine(i + "\t" + j + "\t" + fajl1[i, j] + "\t" + fajl2[i, j] + "\t" + fajl3[i, j]); }
            }
            sw.Close();

        }
        public void FájlBeolvasás(ref int[] Rbeolvasott, ref int[] Gbeolvasott, ref int[] Bbeolvasott)
        {
            int sorokszama = 0;
            StreamReader sr = new StreamReader("eredmeny.txt");
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                sorokszama++;
            }
            sr.Close();

            string[] sorok = new string[sorokszama];
            int szamlalo = 0;
            sr = new StreamReader("eredmeny.txt");
            while (!sr.EndOfStream)
            {
                sorok[szamlalo] = sr.ReadLine();
                szamlalo++;
            }
            sr.Close();
            int[] r = new int[sorokszama];
            int[] g = new int[sorokszama];
            int[] b = new int[sorokszama];
            for (int i = 0; i < sorok.Length; i++)
            {
                string[] sor = sorok[i].Split("\t");

                r[i] = int.Parse(sor[2]);

                g[i] = int.Parse(sor[3]);
                b[i] = int.Parse(sor[4]);
            }
            Rbeolvasott = r;
            Gbeolvasott = g;
            Bbeolvasott = b;





        }
        public void Visszafejtes(int[] R, int[] G, int[] B, ref string kis, ref string nagy, ref string szam)
        {
            string kisbetuk = "";
            string nagybetuk = "";
            string szamok = "";
            for (int i = 0; i < R.Length; i++)
            {
                if (R[i] < R[0])
                { kisbetuk = kisbetuk + (char)(R[0] - R[i]); }
                else if (R[i] > R[0])
                {
                    kisbetuk = kisbetuk + (char)(R[i] - R[0]);
                }
                else { kisbetuk = kisbetuk + '*'; }


            }
            for (int i = 0; i < G.Length; i++)
            {
                if (G[i] < G[0])
                { nagybetuk = nagybetuk + (char)(G[0] - G[i]); }
                else if (G[i] > G[0])
                {
                    nagybetuk = nagybetuk + (char)(G[i] - G[0]);
                }
                else { nagybetuk = nagybetuk + '*'; }
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] < B[0])
                { szamok = szamok + (char)(B[0] - B[i]); }
                else if (B[i] > B[0])
                {
                    szamok = szamok + (char)(B[i] - B[0]);
                }
                else { szamok = szamok + '*'; }
            }
            kis = kisbetuk;
            nagy = nagybetuk;
            szam = szamok;
        }
        public string Összefuttatas(string elso, string masodik, string harmadik)
        {
            string kimenet = "";
            for (int i = 0; i < elso.Length; i++)
            {
                if (char.IsLower(elso[i]))
                { kimenet += elso[i]; }
                else if (char.IsUpper(masodik[i]))
                { kimenet += masodik[i]; }
                else if (char.IsNumber(harmadik[i]))
                { kimenet += harmadik[i]; }
            }
            return kimenet;
        }
    }
}
