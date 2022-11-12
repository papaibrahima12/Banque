using Banque;
namespace BanqueTests
{
    [TestClass]
    public class CompteBancaireTests
    {
        [TestMethod]
        public void VérifierDébitCompteCorrect()
        {
            //ouvrir un compte
            double soldeInitial = 500000;
            double montantDébit = 400000;
            double soldeAttendu = 100000;
            var compte = new CompteBancaire("Pr Abdoulaye Diankha",soldeInitial);

            //Débiter compte
            compte.Débiter(montantDébit);

            //tester 
            double soldeObtenu = compte.Balance;
            Assert.AreEqual(soldeAttendu, soldeObtenu, 0.001, "Compte Débité Incorrectement");

        }
        [TestMethod]
        public void DébiterMontantSupérieurSoldeLèveArgumentOutOfRange()
        {
            //ouvrir un compte
            double soldeInitial = 500000;
            double montantDébit = 600000;
            double soldeAttendu = 100000;
            var compte = new CompteBancaire("Pr Abdoulaye Diankha", soldeInitial);

            //Débiter compte
            compte.Débiter(montantDébit);

            //tester 
            double soldeObtenu = compte.Balance;
            Assert.AreEqual(soldeAttendu, soldeObtenu, 0.001, "Compte Débité Incorrectement");
        }
    }
}