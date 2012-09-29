using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AIAssignment1.Basics;

namespace AIAssignment1.TransitionRating
{
    /**
     * <summary>
     * Transition rater used to evaluate actions based on the resources required.
     * </summary>
     */
    public class ResourceBasedTR : ITransitionRater
    {
        private Dictionary<Resource, ResourceScore> scoreLookup;

        /**
         * <summary>
         * Creates a new resource based transition rater using the given
         * resource scores.
         * </summary>
         */
        public ResourceBasedTR(ResourceScore[] rs)
        {
            scoreLookup = new Dictionary<Resource, ResourceScore>();
            for (int i = 0; i < rs.Length; i++ )
            {
                scoreLookup.Add(rs[i].R, rs[i]);
            }
        }

        /**
         * <summary>
         * Returns a score based on the amount of resources used by the set of actions.
         * </summary>
         */
        public virtual int rateActions(Dictionary<string, int> actions)
        {
            int score = 0;
            foreach (KeyValuePair<string, int> action in actions)
            {
                score += rateAction(action.Key) * action.Value;
            }
            return score;
        }

        /**
         * <summary>
         * Returns a score for the given action based on the resources use by it.
         * </summary>
         */
        public virtual int rateAction(string action)
        {
            Task t = Task.getByAbbr(action);
            if (t == null)
                return 0;
            return rateAction(t);
        }

        /**
         * <summary>
         * Returns a score for the given Task based on the resouces used by it.
         * </summary>
         */
        public virtual int rateAction(Task t)
        {
            int s = 0;
            foreach (ResourceQty rqty in t.PrereqResources)
                s += rqty.Quantity * scoreLookup[rqty.Resource].Score;
            return s;
        }

        /**
         * <summary>
         * Used to define a score for a given resource.
         * </summary>
         */
        public class ResourceScore
        {
            public Resource R { get; private set; }
            public int Score { get; private set; }

            public ResourceScore(Resource r, int score)
            {
                R = r;
                Score = score;
            }
        }
    }
}
