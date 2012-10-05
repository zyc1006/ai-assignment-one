using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    interface IAdjustmentCalculator
    {
        int AdjESp { get; }
        int AdjEB { get; }
        int AdjEP { get; }
        int AdjTW { get; }
        int AdjTB { get; }

        void calculate(int excessESp, int excessEB, int excessEP, int excessTW, int excessTB);
    }
}
