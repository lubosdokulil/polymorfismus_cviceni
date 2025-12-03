namespace polymorfismus_cviceni.Models
{
    public abstract class Zvire //Z abstractní třídy nemůžeme vytvářet instanci
    {
        public string Jmeno { get; set; } = "";    //Vytvoření vlastnosti Jmeno
        public abstract string VydejZvuk();   //Abstractní metoda - potomci ji musejí přepsat
    }
}
    