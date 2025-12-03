namespace polymorfismus_cviceni.Models
{
    public class Koza : Zvire    //Třída koza je potomek třídy Zvíře
    {
        public override string VydejZvuk()  //Přepisuje původní metodu VydejZvuk
        {
            return "Méé";
        }
    }

}
