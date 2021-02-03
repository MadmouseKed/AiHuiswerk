using System;


//Document door Wytze Ketel 
//Naam: Wytze Ketel
//StudentNummer: 1797080
//Taal: C# windows visualstudio community.

namespace FormatiefAI1A
{
    public static class Extensions
    {
        static public T[] Append<T>(this T[] lijst, T Char) //Maakt array groter met +1, en voegt dan char toe op de nieuwe laatste plek. T[] Is een generic variable.
        {
            if (lijst == null)
            {
                return new T[] { Char };
            }
            Array.Resize(ref lijst, lijst.Length + 1);
            lijst[lijst.Length - 1] = Char;

            return lijst;
        }
    }
    public static class functies //Voor minimaal importeren, zal niet bijzonder efficient zijn maar hopelijk wel leerzaam.
    {
        static public string textVermeenigVuldig(string inText,int getal)
        {
            string uitText = "";
            int i = 0;
            //Geprobeerd while(int i = 0, i < getal, i++), echter dit werkte niet. Klopt dit?
            while(i < getal)
            {
                uitText += inText;
                i++;
            }

            return uitText;
        }
        static public int Count(int[] countLijst, int zoekGetal)
        {
            int voorkomendt = 0;
            foreach (int getal in countLijst)
            {
                if (getal == zoekGetal)
                {
                    voorkomendt += 1;
                }
            }
            return voorkomendt;
        }
        static public int CheckVerschil(int[] verschilLijst)
        {
            int index = 0;
            int verschil = 0;
            while (index < verschilLijst.Length-2)
            {
                if ((verschilLijst[index] - verschilLijst[index+1]) > verschil)
                {
                    verschil = verschilLijst[index] - verschilLijst[index + 1];
                }
                index += 1;
            }
            return verschil;
        }
        static public string ControleO3(int[] Lijst)
        {
            int Nullen = functies.Count(Lijst, 0);
            int Eenen = functies.Count(Lijst, 1);
            string feedback;

            if (Nullen < Eenen & Nullen <= 12)
            {
                feedback = "Deze lijst is goed";
            }
            else if (Nullen < Eenen & Nullen > 12)
            {
                feedback = "Deze lijst heeft meer eenen dan nullen, maar meer dan 12 nullen";
            }
            else if (Nullen > Eenen & Nullen <= 12)
            {
                feedback = "Deze lijst heeft meer nullen dan eenen, maarwel 12 of minder nullen.";
            }         
            else
            {
                feedback = "Deze lijst heeft meer nullen dan eenen, en meer dan 12 nullen.";
            }
            return feedback;
        }
        static public Boolean AGroterDanB(int a, int b)
        {
            if (a > b)
                return true;
            else
                return false;
        }//Pretty pointless? Maar ziet er grappig uit.
        static public int[] Swap(int[] lijst, int index1, int index2) //Swapped index1 met index2.
        {
            int Temp = lijst[index1];
            lijst[index1] = lijst[index2];
            lijst[index2] = Temp;
            return lijst;
        }
        static public int[] Sorteren(int[] lijst)
        {
            Boolean vlag = false;
            int index = 0;

            while(index < lijst.Length-1)
            {
                if(lijst[index] > lijst[index+1])
                {
                    lijst = Swap(lijst, index, index + 1);
                    vlag = true;
                }
                index += 1;
            }
            if (vlag)
            {
                Sorteren(lijst);
            }
            return lijst;
        }
        static public int Gemmidelde(int[] lijst)
        {
            int som = 0;
            foreach (int getal in lijst)
            {
                som += getal;
            }
            int gemmidelde = som / lijst.Length;
            return gemmidelde;
        }
        static public int[] lijstGemmidelde(int[][] lijsten)
        {
            int[] gemLijst = { };
            foreach (int[] lijst in lijsten)
            {
                int gemmidelde = Gemmidelde(lijst);
                gemLijst = gemLijst.Append(gemmidelde);
            }
            return gemLijst;
        }
        static public int[] cyclischSchuiven(int[] lijst, int schuif)
        {
            int Grootte = lijst.Length;
            int[] Uitlijst = new int[Grootte];
            int i = 0;
            int j = 0;
            int k = 0;
            if(schuif < 0)
            {
                schuif -= schuif * 2;
                while (i < Grootte)
                {
                    if(i + schuif < Grootte)
                    {
                        j = i + schuif;
                    }
                    else
                    {
                        j = k;
                        k += 1;
                    }
                    Uitlijst[j] = lijst[i];
                    i += 1;
                }
            }
            else if (schuif > 0)
            {
                while (i < Grootte)
                {
                    if (i + schuif < Grootte)
                    {
                        j =  schuif + i;
                    }
                    else
                    {
                        j = k;
                        k += 1;
                    }
                    Uitlijst[i] = lijst[j];
                    i += 1;
                }
            }
            else
            {
                return lijst;
            }

            return Uitlijst;
        }
        static public int FibonaciNummer(int getal1, int getal2, int iteratie, int doel)
        {
            iteratie += 1;
            Console.WriteLine("iteratie: " + iteratie + " ; " + getal2);
            if (iteratie != doel)
            {
                return getal2 = FibonaciNummer(getal2, getal2+getal1, iteratie, doel);
            }
            return getal2;
        }
    }
    public class Opgaven //Opgaven 1 voor 1
    {
        static public void HelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
        static public void Pyramide()
        {
            int Grootte;
            int i;
            string dummyText = ""; //Zonder deze assignment deed de tweede while loop raar. Geen idee waarom.
            string text = "";
            String PyramideBlokje = "*";
            Console.WriteLine("Ik ben Pyramide");
            Boolean Controle;
            String Invoer;
            Controle = true;
            
            // Controle voor integer ingevoerd. Technisch niet.
            // Deze functie maakt altijd een pyramide met een piek.
            do
            {
                Console.WriteLine("Hoe groot wil je de Pyramide hebben? (int)");
                Invoer = Console.ReadLine();
                if (Int32.TryParse(Invoer, out Grootte))
                {
                    Controle = false;
                }
                else
                {
                    Console.WriteLine("Sorry, dat was geen integer.");
                }
            }
            while (Controle == true);

            i = 1;
            // While loop 1, loopt tot midden
            while (i <= Grootte)
            {
                dummyText = functies.textVermeenigVuldig(PyramideBlokje, i);
                text += dummyText += "\n";                
                i++;
            }

            dummyText = "";
            // While loop 2, loopt van midden tot eind.
            i = i - 1;
            while (i > 0)
            {
                i--;
                dummyText = functies.textVermeenigVuldig(PyramideBlokje, i);
                text += dummyText + "\n";
            }
            Console.WriteLine(text);
        }
        static public void TekstCheck()
        {
            Console.WriteLine("Geef een string");
            string tekstEen = Console.ReadLine();
            Console.WriteLine("Geef een tweede string");
            string tekstTwee = Console.ReadLine();

            int index = 0;

            foreach (char letter in tekstEen)
            {
                if (letter != tekstTwee[index])
                {
                    Console.WriteLine("Verschil gevonden op index: " + index);
                    break;
                }
                else if (index == tekstTwee.Length)
                {
                    Console.WriteLine("Geen verschil gevonden.");
                }
                else
                {
                    index += 1;
                }
            }



        }
        static public void LijstCheck()
        {
            int[] Lijst1 = { 1, 9, 10, 12, 3, 2, 1 };
            int[] Lijst2 = { 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0};
            int[] Lijst3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

            //Testen
            //1a
            int CCount = functies.Count(Lijst1, 1);
            Console.WriteLine("Lijst1 heeft " + CCount + " eenen.");
            //1b
            int Grootsteverschil = functies.CheckVerschil(Lijst1);
            Console.WriteLine("Het grootste verschil in lijst1 is " + Grootsteverschil);

            //3c
            //Return is van type string. Dus kunnen we schrijven.
            Console.WriteLine("Controle Lijst2");
            Console.WriteLine(functies.ControleO3(Lijst2));

            Console.WriteLine("Controle Lijst3");
            Console.WriteLine(functies.ControleO3(Lijst3));
        }
        static public void Palindroom()
        {
            Console.WriteLine("Stop, palindroom tijd!");
            Console.WriteLine("Geef een woord op");
            string Woord1 = Console.ReadLine();
            int Index = Woord1.Length - 1;
            Boolean Flag = true;
            foreach (char letter in Woord1)
            {
                if(letter != Woord1[Index])
                {
                    Console.WriteLine(Woord1 + " was geen palindroom, mismatch gevonden op index: " + Index);
                    Flag = false;
                    break;
                }
                Index -= 1;
            }
            if (Flag)
            {
                Console.WriteLine("Hoera; " + Woord1 + " is een palindroom.");
            }    
        }
        static public void Sorteren()
        {
            //Console.WriteLine("Geef een reeks getallen op, als je een niet getal invoert dan wordt de geven lijst getallen gesorteerd.");
            //Boolean Vlag = true;
            //int[] lijst;
            //while (Vlag)
            //{
            //    Console.WriteLine("Getal?");
            //    string invoer = Console.ReadLine();
            //    try
            //    {
            //        int intInvoer = Int32.Parse(invoer);
            //        lijst = lijst.Append(intInvoer);
            //    }
            //    catch
            //    {
            //        Vlag = false;
            //    }
            //}
            //Kreeg de lijst.Append niet werkent, unsigned variable? Maar het was een signed variable... Dus geen idee.
            //Debuggen met C# is wel lastiger.
            int[] lijst = { 1, 9, 2, 15, 8, 23, 3, 1, 5, 4 };
            Console.WriteLine("Grootte = " + lijst.Length);
            int[] gesorteerd = functies.Sorteren(lijst);
            Console.WriteLine("De input lijst was: " + lijst + "\n" + "De gesorteerde lijst is: " + gesorteerd);
        }
        static public void Gemmiddelde()
        {

        }
        static public void Random()
        {
            Boolean vlag = true;
            Random n = new Random();
            int nInt = n.Next(0, 7);
            Console.WriteLine("Gok een random getal tussen 0 en 7");

            while(vlag)
            {
                string text = Console.ReadLine();
                int gok = Int32.Parse(text);
                if (gok == nInt)
                {
                    Console.WriteLine("Hoera, " + gok + " was het juiste getal!");
                    vlag = false;
                }
            }
        }
        static public void Compressie()
        {

        }
        static public void CyclischSchuiven()
        {
            int[] bitLijst = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Schuiven met lijsten, de huidige lijst is ");
            Console.WriteLine("Geef aan hoeveel er geschoven moet worden n < 0: rechts n > 0: links.");
            string text = Console.ReadLine();
            string resultaat = "";
            int schuiven = Int32.Parse(text);
            int[] geschoven = functies.cyclischSchuiven(bitLijst, schuiven);

            foreach (int getal in geschoven)
            {
                resultaat += getal + " ";
            }
            Console.WriteLine(resultaat);

        }
        static public void Fibonaci()
        {
            int getal1 = 0;
            int getal2 = 1;
            int iteratie = 0;
            Console.WriteLine("Geef op de hoeveelste fibonacci nummer je wilt hebben. n>1");
            string invoer = Console.ReadLine();
            int doel = Int32.Parse(invoer);
            int fibNummer = functies.FibonaciNummer(getal1, getal2, iteratie, doel);
            Console.WriteLine("Jouwn getal is " + fibNummer);
        }
        static public void CeasarCijfer()
        {

        }
        static public void FizzBuzz()
        {

        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("verwijder comments uit Main om opgave te runnen.");
            //Opgaven.HelloWorld();
            //Opgaven.Pyramide();
            //Opgaven.TekstCheck();
            //Opgaven.LijstCheck();
            //Opgaven.Palindroom();
            //Opgaven.Sorteren();
            //Opgaven.Random();
            //Opgaven.CyclischSchuiven();
            //Opgaven.Fibonaci();
            
        }
    }
}