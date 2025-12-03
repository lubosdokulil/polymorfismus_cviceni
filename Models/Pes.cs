namespace polymorfismus_cviceni.Models
{
    public class Pes : Zvire    //Třída pes je potomek třídy Zvíře
    {
        public override string VydejZvuk()  //Přepisuje původní metodu VydejZvuk
        {
            return "Haf";
        }
    }
}
