using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.HairCutClasses
{
    class LongHair :Hair
    {
        //public LongHair() { }

        string Hair.HairCut()
        {
            return "long hair cut";
        }
    }
}
