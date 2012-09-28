using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1.TransitionRating
{
    public class ResourceBasedTR : TransitionRater
    {
        private Dictionary<Resource, ResourceScore> scoreLookup;

        public ResourceBasedTR(ResourceScore[] rs)
        {
            scoreLookup = new Dictionary<Resource, ResourceScore>();
            for (int i = 0; i < rs.Length; i++ )
            {
                scoreLookup.Add(rs[i].R, rs[i]);
            }
        }

        public virtual int rateActions(Dictionary<string, int> actions)
        {
            int score = 0;
            foreach (KeyValuePair<string, int> action in actions)
            {
                score += rateAction(action.Key) * action.Value;
            }
            return score;
        }

        public virtual int rateAction(string action)
        {
            Task t = Task.getByAbbr(action);
            if (t == null)
                return 0;
            return rateAction(t);
        }

        public virtual int rateAction(Task t)
        {
            int s = 0;
            foreach (Task.ResourceQty rqty in t.PrereqResources)
                s += rqty.Quantity * scoreLookup[rqty.Resource].Score;
            return s;
        }

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
