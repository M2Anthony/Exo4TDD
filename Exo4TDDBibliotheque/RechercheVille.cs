using static System.Formats.Asn1.AsnWriter;

namespace Exo4TDDBibliotheque
{
    public class RechercheVille
    {
        private List<String> Villes()
        {
            List<String> villes = new List<String>
            {
                "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
            };

            return villes;
        }

        public List<String> Rechercher(String mot)
        {
            if (mot.Length < 2)
            {
                throw new NotFoundException();
            }

            List<string> villesTrouvees = new List<string>();

            foreach (string ville in Villes())
            {
                if (ville.Contains(mot))
                {
                    villesTrouvees.Add(ville);
                }
            }

            return villesTrouvees;
        }
    }
}