namespace Abstract_Factory
{
    public interface IBakery
    {
        public ICake ProductCake();
        public IBread ProductBread();
    }
}