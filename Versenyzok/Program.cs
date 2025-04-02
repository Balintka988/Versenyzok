namespace Versenyzok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Feladat
            Console.WriteLine("2. feladat: ");
            Feladat pilota = new Feladat("pilotak.csv");
            Console.WriteLine("Adatok beolvasva");

            //3.Feladat
            Console.WriteLine("3. feladat: ");
            Console.WriteLine($"A versenyzők száma: {pilota.PilotakLista.Count}");

            //4.Feladat
            Console.WriteLine("4. feladat: ");
            string utolso_nev = pilota.PilotakLista.Last().Nev;
            //Console.WriteLine($"Az utolsó versenyző neve: {pilota.PilotakLista.Last().Nev}");
            Console.WriteLine($"Az utolsó versenyző neve: {utolso_nev}");

            //5.Feladat
            Console.WriteLine("5. feladat: ");
            Console.WriteLine("Azok a pilóták, akik 1900 előtt születtek:");
            pilota.KiszuletettXIXElott();

            //6.Feladat
            Console.WriteLine("6. feladat: ");
            pilota.LegkisebbRajtszam();
        }
    }
}
