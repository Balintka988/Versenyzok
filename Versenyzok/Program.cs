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
            pilota.KiszuletettXIXElott();

            //6.Feladat
            pilota.LegkisebbRajtszam();

            //7. Feladat
            var tobbszorosRajtszamok = pilota.TobbszorosRajtszam();
            Console.WriteLine("7. feladat: " + string.Join(", ", tobbszorosRajtszamok));
        }
    }
}
