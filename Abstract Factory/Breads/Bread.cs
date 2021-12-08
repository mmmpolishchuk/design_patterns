namespace Abstract_Factory.Breads
{
    public class Bread : IBread
    {
        public string Make()
        {
            return "Out bread is most popular among citizens. " +
                   "We are proud of our technologies, which save that taste and smell of traditional bread.";
        }
    }
}