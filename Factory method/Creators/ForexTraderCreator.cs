namespace Factory_method.Creators
{
    public class ForexTraderCreator : TradingSchool
    {
        public override ITrader GraduateTrader()
        {
            return new ForexTrader();
        }
    }
}