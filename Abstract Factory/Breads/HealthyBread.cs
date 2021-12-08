namespace Abstract_Factory.Breads
{
    public class HealthyBread : IBread
    {
        public string Make()
        {
            return
                "Here it is! " +
                "Bread with a wholegrain flour with a high concentration of fiber, seeds and italian greens";
        }
    }
}