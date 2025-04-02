namespace Versenyzok
{
    internal class Feladat
    {
        public Feladat(string fajlBe)
        {
            FajlBe = fajlBe;
            PilotakLista = Beolvas();
        }

        public string FajlBe { get; set; }

        public List<Pilotak> PilotakLista = new List<Pilotak>();

        //1.Feladat sdfsdfsddddddd
        public List<Pilotak> Beolvas()
        {
            StreamReader srBe = new StreamReader(FajlBe);
            List<Pilotak> pilotakLista = new List<Pilotak>();

            string row = srBe.ReadLine();

            while (!srBe.EndOfStream)
            {
                row = srBe.ReadLine();

                string[] pilotaktemp = row.Split(';');
                Pilotak pilotak = new Pilotak();
                pilotak.Nev = pilotaktemp[0];
                pilotak.Szuletesiev = DateTime.Parse(pilotaktemp[1]);
                pilotak.Nemzetiseg = pilotaktemp[2];
                //pilotak.Rajtszam = int.Parse(pilotaktemp[3]);

                if(string.IsNullOrEmpty(pilotaktemp[3]))
                {
                    pilotak.Rajtszam = null;
                }
                else
                {
                    pilotak.Rajtszam = int.Parse(pilotaktemp[3]);
                }

                pilotakLista.Add(pilotak);
            }
            srBe.Close();
            return pilotakLista;
        }
        //5.Feladat
        public void KiszuletettXIXElott()
        {
            var pilotakXIX = PilotakLista.Where(p => p.Szuletesiev.Year < 1901)
                .Select(p => new { p.Nev, p.Szuletesiev});

            foreach (var pilota in pilotakXIX)
            {
                Console.WriteLine($"- {pilota.Nev} {pilota.Szuletesiev.ToString("yyyy. MM. dd")}");
            }
        }
        public void LegkisebbRajtszam()
        {
            var legkisebbRajtszam = PilotakLista.Min(p => p.Rajtszam);
            var legkisebbRajtszamuPilota = PilotakLista.Where(p => p.Rajtszam == legkisebbRajtszam)
                .Select(p => new {p.Nemzetiseg});

            foreach (var pilota in legkisebbRajtszamuPilota)
            {
                Console.WriteLine($"BlablablaBlüblüblü:{pilota.Nemzetiseg}");
            }
        }
    }
}
