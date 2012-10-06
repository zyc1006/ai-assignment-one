using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AdjustmentCaculator : Form
    {

        private int excessESp;
        private int excessEB;
        private int excessEP;
        private int excessTW;
        private int excessTB;

        private IAdjustmentCalculator calc = new GraphCalculator();

        public AdjustmentCaculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MessageBox.Text = "";
            if (!tryGetExcessVals())
                return;

            calc.calculate(excessESp, excessEB, excessEP, excessTW, excessTB);

            tbESpAdjustment.Text = calc.AdjESp.ToString();
            tbEBAdjustment.Text = calc.AdjEB.ToString();
            tbEPAdjustment.Text = calc.AdjEP.ToString();
            tbTWAdjustment.Text = calc.AdjTW.ToString();
            tbTBAdjustment.Text = calc.AdjTB.ToString();
        }

        private bool tryGetExcessVals()
        {
            bool r = true;

            try{
                excessESp = Convert.ToInt32(tbESpExcess.Text);
            }
            catch (Exception){
                MessageBox.Text += "\n\rInvalid input for excess ESp.";
                tbESpExcess.Select();
                r = false;
            }
            try{
                excessEB = Convert.ToInt32(tbEBExcess.Text);
            }
            catch (Exception){
                MessageBox.Text += "\n\rInvalid input for excess ESp.";
                tbEBExcess.Select();
                r = false;
            }
            try{
                excessEP = Convert.ToInt32(tbEPExcess.Text);
            }
            catch (Exception){
                MessageBox.Text += "\nInvalid input for excess ESp.";
                tbEPExcess.Select();
                r = false;
            }
            try{
                excessTW = Convert.ToInt32(tbTWExcess.Text);
            }
            catch (Exception){
                MessageBox.Text += "\nInvalid input for excess ESp.";
                tbTWExcess.Select();
                r = false;
            }
            try
            {
                excessTB = Convert.ToInt32(tbTBExcess.Text);
            }
            catch (Exception)
            {
                MessageBox.Text += "\nInvalid input for excess ESp.";
                tbTBExcess.Select();
                r = false;
            }

            return r;
        }

        private class GraphCalculator : IAdjustmentCalculator
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
