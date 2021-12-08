using System;
using Factory_method.Creators;

namespace Factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("CT be like : ");
            ClientCode(new CryptoTraderCreator(), Console.WriteLine);

            Console.WriteLine();
            
            Console.Write("FX trader be like : ");
            ClientCode(new ForexTraderCreator(), Console.Write);
        }

        static void ClientCode(TradingSchool school, Action<string> result)
        {
            var trader = school.GraduateTrader();

            result(trader.Trade());
        }
    }
}