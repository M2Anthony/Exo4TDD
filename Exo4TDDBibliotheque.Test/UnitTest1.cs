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

            List<string> rechercher = rechercheVille.Rechercher("a");

            // Assert

            Assert.ThrowsException<NotFoundException> (() => rechercheVille.Rechercher("a"));

        }
    }
}