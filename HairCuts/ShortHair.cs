using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.HairCutClasses
{
    class ShortHair :Hair
    {
        string Hair.HairCut()
        {
             return "Short hair cut";
        }
    }
}
