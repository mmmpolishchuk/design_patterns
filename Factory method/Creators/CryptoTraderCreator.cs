namespace Factory_method.Creators
{
    public class CryptoTraderCreator : TradingSchool
    {
        public override ITrader GraduateTrader()
        {
            return new CryptoTrader();
        }
    }
}