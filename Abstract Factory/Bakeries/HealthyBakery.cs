using Abstract_Factory.Breads;
using Abstract_Factory.Cakes;

namespace Abstract_Factory.Bakeries
{
    public class HealthyBakery : IBakery
    {
        public ICake ProductCake()
        {
            return new HealthyCake();
        }

        public IBread ProductBread()
        {
            return new HealthyBread();
        }
    }
}