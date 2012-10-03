using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1
{
    /// <summary>
    /// Describes a graph-searching class that performs a
    /// greedy, best-first search, walking from state to
    /// state without keeping track of pervious states
    /// or other candidate paths.
    /// </summary>
    interface IWalker
    {
        /// <summary>
        /// Tells the walker to determine a suitable
        /// set of actions and perform them.
        /// </summary>
        void nextAction();
    }
}
