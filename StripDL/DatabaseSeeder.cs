using StripDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripDL
{
    public class DatabaseSeeder
    {
        public static void SeedFromFile(string filePath)
        {
            using (var context = new StripContext())
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length != 5) continue;

                    // Parse ReeksNr, handling NULL values
                    int? reeksNr = null;
                    if (parts[0].ToUpper() != "NULL")
                    {
                        reeksNr = int.Parse(parts[0]);
                    }

                    var stripTitel = parts[1];
                    var uitgeverijNaam = parts[2];
                    var reeksNaam = parts[3];
                    var auteurNamen = parts[4].Split('|').Select(n => n.Trim()).ToList();

                    // Zoek of maak uitgeverij
                    var uitgeverij = context.Uitgeverijen
                        .FirstOrDefault(u => u.Naam == uitgeverijNaam);
                    if (uitgeverij == null)
                    {
                        uitgeverij = new UitgeverijEF { Naam = uitgeverijNaam };
                        context.Uitgeverijen.Add(uitgeverij);
                    }

                    // Zoek of maak reeks
                    var reeks = context.Reeksen
                        .FirstOrDefault(r => r.Naam == reeksNaam);
                    if (reeks == null)
                    {
                        reeks = new ReeksEF { Naam = reeksNaam };
                        context.Reeksen.Add(reeks);
                    }

                    // Zoek of maak auteurs
                    var auteurs = new List<AuteurEF>();
                    foreach (var auteurNaam in auteurNamen)
                    {
                        var auteur = context.Auteurs
                            .FirstOrDefault(a => a.Naam == auteurNaam);
                        if (auteur == null)
                        {
                            auteur = new AuteurEF
                            {
                                Naam = auteurNaam,
                                EmailAdres = $"{auteurNaam.ToLower().Replace(" ", ".").Replace("|", ".")}@example.com"
                            };
                            context.Auteurs.Add(auteur);
                        }
                        auteurs.Add(auteur);
                    }

                    // Maak strip aan
                    var strip = new StripEF
                    {
                        Titel = stripTitel,
                        ReeksNr = reeksNr ?? 0, // Als reeksNr null is, gebruik 0
                        Uitgeverij = uitgeverij,
                        Reeks = reeks,
                        Auteurs = auteurs
                    };

                    context.Strips.Add(strip);
                }

                context.SaveChanges();
            }
        }
    }
}
