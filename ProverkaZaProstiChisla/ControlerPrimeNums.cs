using System;
using System.Collections.Generic;
using System.Text;

namespace ProverkaZaProstiChisla
{
    public class ControlerPrimeNums
    {
        Model model = new Model();
        Display display = new Display();
        public void Run()
        {
            display.InputNumbers();
            model.Numbers = display.Numbers;
            model.CalculatePrimeCount();
            display.PrimeCount = model.PrimeCount;
            display.DisplayResults();
        }
    }
}
