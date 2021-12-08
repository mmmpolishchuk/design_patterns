using Abstract_Factory.Breads;
using Abstract_Factory.Cakes;

namespace Abstract_Factory.Bakeries
{
    public class Bakery : IBakery
    {
        public ICake ProductCake()
        {
            return new Cake();
        }

        public IBread ProductBread()
        {
            return new Bread();
        }
    }
}