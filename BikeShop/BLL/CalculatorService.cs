using BLL.interfaces;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class CalculatorService : ICalculatorService
    {
        public int Random()
        {
            Random random = new Random();
            int rnd = random.Next(1, 5);
            return rnd;
        }

        public double BerekenTotaal(double totaal, int totaalAantal)
        {
            double eindPrijs;
            switch (totaalAantal)
            {
                case int t when (t >= 3 && t < 6):
                    eindPrijs = totaal * 0.95;
                    break;
                case int t when (t >= 6):
                    eindPrijs = totaal * 0.90;
                    break;
                default:
                    eindPrijs = totaal;
                    break;
            }
            return eindPrijs;
        }

        public double BerekenKorting(double subtotaal, double totaal)
        {
            return subtotaal - totaal;
        }
    }
}
