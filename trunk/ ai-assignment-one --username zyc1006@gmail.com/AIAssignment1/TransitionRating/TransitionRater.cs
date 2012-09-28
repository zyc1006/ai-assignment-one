using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1.TransitionRating
{
    public interface TransitionRater
    {
        int rateActions(Dictionary<string, int> actions);
        int rateAction(string action);
    }
}
