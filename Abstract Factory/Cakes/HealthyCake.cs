namespace Abstract_Factory.Cakes
{
    public class HealthyCake : ICake
    {
        public string Make()
        {
            return
                "Mmmm, it smells delicious! Our cakes are made without sugar, using a natural sweetener - stevia. " +
                "Recommended to eat even in the night";
        }
    }
}