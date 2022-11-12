using System.Globalization;

namespace Banque
{
    public class CompteBancaire
    {
        private string m_nomClient;
        private double m_solde;
        private bool m_bloqué = false;

        public CompteBancaire(string nomClient, double solde)
        {
            m_nomClient = nomClient;
            m_solde = solde;
        }
        public string nomClient
        {
            get { return m_nomClient; }
        }
        public double Balance
        {
            get { return m_solde; }
        }
        public void Débiter(double montant)
        {
            if (m_bloqué)
            {
                throw new Exception("Compte bloqué");
            }
            if (montant > m_solde)
            {
                throw new ArgumentOutOfRangeException("Montant débité doit etre inférieur ou égal au solde disponible");
            }
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException("Montant doit etre positif");
            }
            m_solde -= montant;
        }
        public void Créditer(double montant)
        {
            if (m_bloqué)
            {
                throw new Exception("Compte Bloqué");
            }
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException("Montant doit etre positif");
            }
            m_solde += montant;
        }
        public void BloquerCompte()
        {
            m_bloqué = true;
        }
        private void DébloquerCompte()
        {
            m_bloqué = false;
        }
        public static void Main()
        {
            CompteBancaire cb = new CompteBancaire("Pr Abdoulaye Diankha", 500000);
            cb.Débiter(400000);
            Console.WriteLine("Solde disponible égal à F{0}", cb.Balance);
        }
    }
}