namespace Exo4TDDBibliotheque.Test
{
    [TestClass]
    public class TestRechercheVille
    {
        [TestMethod]
        public void TestRechercheVille_Methode1()
        {
            // Arrange

            RechercheVille rechercheVille = new RechercheVille();

            // Act


            // Assert

            Assert.ThrowsException<NotFoundException>(() => rechercheVille.Rechercher("a"));

        }

        [TestMethod]
        public void TestRechercheVille_Methode2()
        {
            // Arrange

            RechercheVille rechercheVille = new RechercheVille();

            // Act
            List<String> resultatAttendu = new List<String> { "Paris" };

            List<String> listeVilles = rechercheVille.Rechercher("Pa");

            // Assert

            CollectionAssert.AreEqual(resultatAttendu, listeVilles);
        }

    }
}