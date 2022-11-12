using Banque;
namespace BanqueTests
{
    [TestClass]
    public class CompteBancaireTests
    {
        [TestMethod]
        public void V�rifierD�bitCompteCorrect()
        {
            //ouvrir un compte
            double soldeInitial = 500000;
            double montantD�bit = 400000;
            double soldeAttendu = 100000;
            var compte = new CompteBancaire("Pr Abdoulaye Diankha",soldeInitial);

            //D�biter compte
            compte.D�biter(montantD�bit);

            //tester 
            double soldeObtenu = compte.Balance;
            Assert.AreEqual(soldeAttendu, soldeObtenu, 0.001, "Compte D�bit� Incorrectement");

        }
        [TestMethod]
        public void D�biterMontantSup�rieurSoldeL�veArgumentOutOfRange()
        {
            //ouvrir un compte
            double soldeInitial = 500000;
            double montantD�bit = 600000;
            double soldeAttendu = 100000;
            var compte = new CompteBancaire("Pr Abdoulaye Diankha", soldeInitial);

            //D�biter compte
            compte.D�biter(montantD�bit);

            //tester 
            double soldeObtenu = compte.Balance;
            Assert.AreEqual(soldeAttendu, soldeObtenu, 0.001, "Compte D�bit� Incorrectement");
        }
    }
}