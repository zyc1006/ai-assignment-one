using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1.Adjustments
{
    
        public class GraphCalculator : IAdjustmentCalculator
        {

            public int AdjESp { get; private set; }
            public int AdjEB { get; private set; }
            public int AdjEP { get; private set; }
            public int AdjTW { get; private set; }
            public int AdjTB { get; private set; }

            public void calculate(int excessESp, int excessEB, int excessEP, int excessTW, int excessTB)
            {
                ExcessNode ESp = new ExcessNode(excessESp);
                ExcessNode EB = new ExcessNode(excessEB);
                ExcessNode EP = new ExcessNode(excessEP);
                ExcessNode TW = new ExcessNode(excessTW);
                ExcessNode TB = new ExcessNode(excessTB);

                ESp.addLink(TW, 1, 1);

                TW.addLink(ESp, 1, 1);
                TW.addLink(EB, 1, 1);
                TW.addLink(EP, 1, 1);
                TW.addLink(TB, 1, 1);

                TB.addLink(TW, 1, 1);
                TB.addLink(EB, 1, 1);
                TB.addLink(EP, 1, 1);

                EB.addLink(TB, 1, 1);
                EB.addLink(TW, 1, 1);

                EP.addLink(TW, 1, 1);
                EP.addLink(TB, 1, 1);

                Queue<ExcessNode> nodes = new Queue<ExcessNode>();
                nodes.Enqueue(ESp);
                nodes.Enqueue(EB);
                nodes.Enqueue(EP);
                nodes.Enqueue(TW);
                nodes.Enqueue(TB);

                while (nodes.Count > 0){
                    ExcessNode n = nodes.Dequeue();
                    if (n.tryPushExcess())
                        nodes.Enqueue(n);
                }

                AdjESp = ESp.Adjustment;
                AdjEB = EB.Adjustment;
                AdjEP = EP.Adjustment;
                AdjTW = TW.Adjustment;
                AdjTB = TB.Adjustment;
            }

            
        private class ExcessNode
        {
            private int excess = 0;
            private int adjustment = 0;
            private int fromWeightsTot = 0;
            private Dictionary<ExcessNode, ExchangeRate> transitions = new Dictionary<ExcessNode, ExchangeRate>();

            public int Excess { get { return excess; }}
            public int Adjustment { get { return adjustment; }}

            public ExcessNode(int excess)
            {
                this.excess = excess;
            }

            public bool tryPushExcess()
            {
                if (excess < fromWeightsTot)
                    return false;

                foreach(KeyValuePair<ExcessNode, ExchangeRate> t in transitions ){
                    adjustment -= t.Value.From;
                    t.Key.adjust(t.Value.To);
                }
                
                return true;
            }

            public void adjust(int adjustment)
            {
                this.adjustment += adjustment;

                foreach(KeyValuePair<ExcessNode, ExchangeRate> t in transitions){
                    t.Key.decrease(adjustment);
                }
            }

            public void decrease(int amount)
            {
                excess -= amount;
            }

            public void addLink(ExcessNode n, int from, int to)
            {
                ExchangeRate er = new ExchangeRate();
                er.From = from;
                er.To = to;
                transitions.Add(n, er);
                fromWeightsTot += from;
            }

            private class ExchangeRate
            {
                public int From = 1;
                public int To = 1;
            }
        }
    }
}
