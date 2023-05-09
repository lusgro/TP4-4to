namespace TP4.Models
{
    public class Indumentaria
    {
        public string medias{get; private set;}
        public string pantalon{get; private set;}
        public string camiseta{get; private set;}
    

        public Indumentaria(string medias, string pantalon, string camiseta)
        {
            this.medias = medias;
            this.pantalon = pantalon;
            this.camiseta = camiseta;
        }
    }
}