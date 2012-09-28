using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1.TransitionRating
{
    public class FixedValueTR : TransitionRater
    {
        private Dictionary<string, TaskScore> scores;

        public FixedValueTR(TaskScore[] taskscores)
        {
            scores = new Dictionary<string, TaskScore>();

            for (int i = 0; i < taskscores.Length; i++)
                scores.Add(taskscores[i].T.Abbr, taskscores[i]);
        }

        public virtual int rateActions(Dictionary<string, int> actions)
        {
            int score = 0;
            foreach (KeyValuePair<string, int> action in actions)
            {
                try
                {
                    score += rateAction(action.Key) * action.Value;
                }catch(Exception){}
            }

            return score;
        }

        public virtual int rateAction(string action)
        {
            try
            {
                return scores[action].Score;
            }
            catch (Exception) {
                return 0;
            }
        }

        public class TaskScore 
        {
            public Task T { get; private set; }
            public virtual int Score { get; private set; }

            public TaskScore(Task t, int score)
            {
                T = t;
                Score = score;
            }
        }
    }
}
