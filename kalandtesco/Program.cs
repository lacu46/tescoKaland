using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TeszkoKaland
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kezdeti állapotok
            int penz = 5000;
            int energia = 100;
            bool vanSzatyor = false;

            Console.WriteLine("=== A NAGY TESCO KÜLDETÉS===");
            Console.Write("Hogy hívnak, bátor vásárló? ");
            string nev = Console.ReadLine();

            Console.WriteLine($"\nÜdv, {nev}! A cél: vacsorát venni és épségben hazaérni.");
            Console.WriteLine($"Statisztikáid: {penz} Ft, {energia}% energia.");

            // 1. FEJEZET: Az utazás
            Console.WriteLine("\n--- 1. FEJEZET: AZ ÚT ---");
            Console.WriteLine("Hogyan indulsz el?");
            Console.WriteLine("1. Gyalog (ingyé van, de fárasztó).");
            Console.WriteLine("2. Busszal (gyors, de drága és életveszélyes).");
            Console.Write("Válassz (1) vagy (2) !: ");

            string utazas = Console.ReadLine();

            if (utazas == "1")
            {
                Console.WriteLine("Séta közben elkapott a zápor, és egy veszett kóbor kutya is megkergetett.");
                energia -= 30;
            }
            else
            {
                Console.WriteLine("A buszon jött Pista ellenőr, s nincs jegyed...");
                Console.WriteLine("1. Kiugrassz az ablakon, mint egy blicckirály");
                Console.WriteLine("2. Kifizeted a bírságot (3000 Ft).");
                string buszAkcio = Console.ReadLine();

                if (buszAkcio == "1")
                {
                    Console.WriteLine("Sikerült kirepülni a busz hátsó ablakán! De közben elhagytál 500 forintot a zsebedből.");
                    penz -= 500;
                    energia -= 10;
                }
                else
                {
                    Console.WriteLine("A bírság után alig maradt pénzed, de legalább nem kellett átrepülni az üvegen.");
                    penz -= 3000;
                }
            }

            // 2. FEJEZET: A sorok között
            Console.WriteLine("\n--- 2. FEJEZET: AZ ÁRUHÁZBAN ---");
            Console.WriteLine("Megérkeztél! Egy néni épp kóstolót osztogat egy random pultnál.");
            Console.WriteLine("1. Kérsz egy falatot (+ energia).");
            Console.WriteLine("2. Rá se bagózól mert sietsz.");
            string kostolo = Console.ReadLine();

            if (kostolo == "1")
            {
                Console.WriteLine("Na ez fincsi volt! Visszanyertél +20 energiát!");
                energia += 20;
            }

            Console.WriteLine("\nMit veszel vacsorára?");
            Console.WriteLine("1. Mirelit ananászos pizza (ew) (1200 Ft).");
            Console.WriteLine("2. kutya drága Sushi-s tál (szintén ew) (4000 Ft).");
            string vacsora = Console.ReadLine();

            if (vacsora == "2")
            {
                penz -= 4000;
                Console.WriteLine("Jól megy.. reméljük, marad elég pénzed a kasszánál.");
            }
            else
            {
                penz -= 1200;
                Console.WriteLine("Bölcs, s megfontolt döntés, maradt pénzed másra is ;) ");
            }

            // 3. FEJEZET: A pénztár
            Console.WriteLine("\n--- 3. FEJEZET: A KASSZA ---");
            Console.WriteLine("Sorban állsz. Rájössz, hogy nem hoztál szatyrot!");
            Console.WriteLine("1. Veszel egy olcsó Teszkós szatyrot (300 Ft).");
            Console.WriteLine("2. Betömöd a gatyádba a cuccot (rizikós).");
            string szatyorValasz = Console.ReadLine();

            if (szatyorValasz == "1")
            {
                penz -= 300;
                vanSzatyor = true;
                Console.WriteLine("Vettél egy szatyrot, minden fasza.");
            }
            else
            {
                Console.WriteLine("A cuccok fele lehullot a lábad közt a kijáratnál, máma nem fogsz enni, vedd újra őket");
                penz -= 500;
            }

            // JÁTÉK VÉGE
            Console.WriteLine("\n============================");
            Console.WriteLine($"{nev} kalandja véget ért.");
            Console.WriteLine($"Maradék pénz: {penz} Ft");
            Console.WriteLine($"Maradék energia: {energia}%");

            if (penz >= 0 && energia > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("GRATULÁLOK! Sikeresen hazaértél a vacsorával.");
                if (vanSzatyor) Console.WriteLine("A szatyrod még évekig jó lesz szemeteszsáknak!");
            }
            else if (penz < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ráment a gatyád az egészre, elfoglalták a cuccaidat a biztonsági őrök, mert nem tudtál fizetni.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Elájultál! Még a kapuig se értél el, de az éhségtől kidőltél.");
            }

            Console.ResetColor();
            Console.WriteLine("\nNyomj meg egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
