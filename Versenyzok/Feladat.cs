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

        //1.Feladat 
        public List<Pilotak> Beolvas()
        {
            StreamReader srBe = new StreamReader(FajlBe);
            List<Pilotak> pilotakLista = new List<Pilotak>();

            string row1 = srBe.ReadLine();

            while (!srBe.EndOfStream)
            {
                string row = srBe.ReadLine();

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
        public List<Pilotak> KiszuletettXIXElott()
        {
            return PilotakLista
                .Where(p => p.Szuletesiev.Year < 1901)
                .ToList();
        }

        //6.Feladat
        public string LegkisebbRajtszam()
        {
            var legkisebbRajtszam = PilotakLista.Min(p => p.Rajtszam);
            var legkisebbRajtszamuPilota = PilotakLista.Where(p => p.Rajtszam == legkisebbRajtszam)
                .Select(p => new {p.Nemzetiseg})
                .First();
            return legkisebbRajtszamuPilota.Nemzetiseg;
        }
        //7.Feladat
        public List<int> TobbszorosRajtszam()
        {
            return PilotakLista
                .Where(p => p.Rajtszam != null)
                .GroupBy(p => p.Rajtszam.Value)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();
        }
    }
}
