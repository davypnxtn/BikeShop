using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.interfaces
{
     public interface ICalculatorService
    {
        int Random();
        double BerekenTotaal(double totaal, int totaalAantal);
        double BerekenKorting(double subtotaal, double totaal);
    }
}
