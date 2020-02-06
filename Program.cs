using System;
using StrategyPattern.HairCutClasses;
namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Hair longHair = new LongHair();
            var ahmed = new Child(longHair, "ahmed", 10);
            ahmed.Display();

            longHair = new ShortHair();
            ahmed.SetHairCut(longHair);
            ahmed.Display();
           
        }
    }
}
