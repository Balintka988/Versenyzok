namespace Versenyzok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Feladat
            //Console.WriteLine("2. feladat: ");
            Feladat pilota = new Feladat("pilotak.csv");
            //Console.WriteLine("Adatok beolvasva");

            //3.Feladat
            Console.WriteLine($"3. feladat: {pilota.PilotakLista.Count}");

            //4.Feladat
            string utolso_nev = pilota.PilotakLista.Last().Nev;
            Console.WriteLine($"4. feladat: {utolso_nev}");

            //5.Feladat
            Console.WriteLine("5. feladat: ");
            var rajtszamok = pilota.KiszuletettXIXElott();
            foreach (var rajtszam in rajtszamok)
            {
                Console.WriteLine($"\t{rajtszam.Nev} {rajtszam.Szuletesiev.ToString("(yyyy. MM. dd.)")}");
            }

            //6.Feladat
            string legkisebbPilotaNemzetiseg = pilota.LegkisebbRajtszam();
            Console.WriteLine($"6. feladat: {legkisebbPilotaNemzetiseg}");

            //7. Feladat
            var tobbszorosRajtszamok = pilota.TobbszorosRajtszam();
            Console.Write("7. feladat: ");
            foreach (var rajtszam in tobbszorosRajtszamok)
            {
                Console.Write($"{rajtszam}");
                if (rajtszam != tobbszorosRajtszamok.Last())
                    Console.Write(", ");
            }
        }
    }
}
