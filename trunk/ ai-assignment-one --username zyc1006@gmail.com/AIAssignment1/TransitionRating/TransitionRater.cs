using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1.TransitionRating
{
    // <summary>
    // Defines an object that can be used to rate a set of
    // actions regardless of the current state.
    // </summary>
    public interface TransitionRater
    {
        // <summary>
        // Evaluates the set of actions and returns a score.
        // The higher the score the better this choice of actions is.
        // <summary>
        int rateActions(Dictionary<string, int> actions);
        // <summary>
        // Returns a score for a single actions.
        // </summary>
        int rateAction(string action);
    }
}
