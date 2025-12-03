namespace polymorfismus_cviceni.Models
{
    public class Kocka:Zvire    //Třída kočka je potomek třídy Zvíře
    {
        public override string VydejZvuk()  //Přepisuje původní metodu VydejZvuk
        {
            return "Mňau";
        } 
    }
}
