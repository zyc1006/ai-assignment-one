using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using AIAssignment1.Adjustments;

namespace AIAssignment1
{
    public partial class Form1 : Form
    {

        private Dictionary<Int32, CStateInfo> oldStates = new Dictionary<Int32, CStateInfo>();

        private IAdjustmentCalculator adjCalc = new GraphCalculator();

        private CStateInfo cStateInfo = null;
        private IWalker cActions = null;
        private Int32 iTimeLine = 0;
        private Hashtable htStatuInfo;


        public Form1()
        {
            InitializeComponent();

            dgvInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBlInfo.Enabled = false;
            dgvAction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Notsortable
            foreach (DataGridViewColumn column in dgvInfo.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            foreach (DataGridViewColumn column in dgvBlInfo.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            foreach (DataGridViewColumn column in dgvAction.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        /**
         * <summary>
         * Performed when the "Start" button is clicked.
         * Disables all input fields, clears the message-box,
         * empties all lists and ernables the "Step" and "Run"
         * buttons.
         * </summary>
         */
        private void btStart_Click(object sender, EventArgs e)
        {
            if (!initializeState())
            {
                return;
            }
            dgvInfo.Rows.Clear();
            dgvBlInfo.Rows.Clear();
            dgvAction.Rows.Clear();

            oldStates.Clear();

            txTotalBlig.Enabled = false;
            txTotalBlige.Enabled = false;
            txTotalPl.Enabled = false;
            txTotalSp.Enabled = false;
            txTotalWb.Enabled = false;
            btStart.Enabled = false;
            btStep.Enabled = true;
            btRun.Enabled = true;

    //        displayStatusInfo(cStateInfo, iTimeLine);
    //        displayBlStatusInfoTest(cStateInfo, iTimeLine);
        }

        /**
         * <summary>
         *  Checks the contents of the input fields for validity.
         *  Input is valid if all fields are nonempty and contain
         *  only non-negative integers adding up to no more than 50.
         * </summary>
         * <returns>
         *  False if any of the conditions for valid input have been
         *  violated, returns true otherwise.
         * </returns>
         */
        private Boolean validateInput()
        {
            return true;
        }

        /**
         * <summary>
         *  Attempts to initialize a state object with the values provided in
         *  the input fields, and uses it to produce a new CActions object
         *  for this form.
         * </summary>
         * <returns>
         *  True if the initialization was successful, false otherwise.
         * </returns>
         */
        private Boolean initializeState()
        {
            cStateInfo = new CStateInfo();
            htStatuInfo = new Hashtable();
            tbMessageBox.Text = "";
            

            iTimeLine = 0;
            
            try
            {

                cStateInfo.ISpunkeesAvailable = Convert.ToInt32(txTotalSp.Text);
                cStateInfo.IBligeesAvailable = Convert.ToInt32(txTotalBlige.Text);
                cStateInfo.IPlinksAvailable = Convert.ToInt32(txTotalPl.Text);
                cStateInfo.IWorkbenchesAvailable = Convert.ToInt32(txTotalWb.Text);
                cStateInfo.IBligsAvailable = Convert.ToInt32(txTotalBlig.Text);
                //cStateInfo.IBligsUnavailable = Convert.ToInt32(txTotalBlig.Text);
                cStateInfo.IBligTotal = Convert.ToInt32(txTotalBlig.Text);
                cStateInfo.ListBligStatus[0] = cStateInfo.IBligsAvailable;
                //cStateInfo.ListBligStatus[8] = cStateInfo.IBligsUnavailable;
                if (cStateInfo.ISpunkeesAvailable < 1 || cStateInfo.IBligTotal < 1 ||
                    cStateInfo.IPlinksAvailable < 1 || cStateInfo.IWorkbenchesAvailable < 1 )
                {
                    tbMessageBox.Text = "Invalid input!";
                    return false;
                }
                else if (cStateInfo.ISpunkeesAvailable >= 1 && cStateInfo.IBligeesAvailable == 0 &&
                    cStateInfo.IPlinksAvailable >= 1 && cStateInfo.IWorkbenchesAvailable >= 1 &&
                    cStateInfo.IBligTotal < 25)
                {
                    tbMessageBox.Text = "Invalid input!";
                    return false;
                }
                cActions = new CActions(cStateInfo);
                return true;
            }
            catch (System.Exception e)
            {
                tbMessageBox.Text = "Invalid input!";
                Console.WriteLine(e.Message);
                return false;
            }

        }

        /**
         * <summary>
         *  Prompts the CAction object to identify and perform
         *  the set of actions for the next hour and displays
         *  the result in the lists.
         * </summary>
         */
        private void doAll()
        {
            cActions.nextAction();
            iTimeLine++;
            oldStates.Add(iTimeLine, cStateInfo.copy());
            displayActionInfo(cStateInfo, iTimeLine);
            displayStatusInfo(cStateInfo, iTimeLine);
            displayBlStatusInfo(cStateInfo, iTimeLine - 1);

        }

        /**
         * <summary>
         *  Displays status information about the given state, indexed by the provided time-stamp.
         * </summary>
         * <param name="cStateInfo">State to print information about.</param>
         * <param name="iTimeLine">Timestamp equivalent to the hour of production when we would be in the given state.</param>
         */
        private void displayStatusInfo(CStateInfo cStateInfo, Int32 iTimeLine)
        {

            dgvInfo.Rows.Add(new Object[]{
                                iTimeLine,
                                cStateInfo.ISpunkeesAvailable,
                                cStateInfo.IBligeesAvailable,
                                cStateInfo.IPlinksAvailable,
                                cStateInfo.IWorkbenchesAvailable,
                                cStateInfo.IBligTotal - cStateInfo.IBligsUnavailable - cStateInfo.IBligsUnderServing - cStateInfo.ITimesServePlonks,
                                cStateInfo.ISpunks,
                                cStateInfo.IUnservicedPlonks,
                                cStateInfo.IServicedPlonks
                              });
            if (iTimeLine - 4 > 0)
            {
                dgvInfo.FirstDisplayedScrollingRowIndex = iTimeLine - 4;
            }

            printExcess();
        }

        /// <summary>
        /// Prints the average unused (excess) resources over
        /// all timesteps.
        /// </summary>
        private void printExcess()
        {
            float avgESp = 0;
            float avgEB = 0;
            float avgEP = 0;
            float avgTW = 0;
            float avgTB = 0;

            foreach (KeyValuePair<Int32, CStateInfo> kvp in oldStates)
            {
                avgESp += kvp.Value.ISpunkeesAvailable;
                avgEB += kvp.Value.IBligeesAvailable;
                avgEP += kvp.Value.IPlinksAvailable;
                avgTW += kvp.Value.IWorkbenchesAvailable;
                avgTB += kvp.Value.IBligTotal - kvp.Value.ITimesServePlonks - kvp.Value.IBligsUnderServing - kvp.Value.IBligsUnavailable;
            }
            avgESp = (float)Math.Floor(avgESp / iTimeLine);
            avgEB = (float)Math.Floor(avgEB / iTimeLine);
            avgEP = (float)Math.Floor(avgEP / iTimeLine);
            avgTW = (float)Math.Floor(avgTW / iTimeLine);
            avgTB = (float)Math.Floor(avgTB / iTimeLine);


            tbAverageExcessBox.Text =
                "Spunkees: " + avgESp +
                Environment.NewLine + "Bligees: " + avgEB +
                Environment.NewLine + "Plinks: " + avgEP +
                Environment.NewLine + "Workbenches: " + avgTW +
                Environment.NewLine + "Bligs: " + avgTB;

            adjCalc.calculate((int)avgESp, (int)avgEB, (int)avgEP, (int)avgTW, (int)avgTB);

            if (adjCalc.AdjESp == 0 &&
                adjCalc.AdjEB == 0 &&
                adjCalc.AdjEP == 0 &&
                adjCalc.AdjTW == 0 &&
                adjCalc.AdjTB == 0)
            {
                tbMessageBox.Text = "I can't provide any more suggestions, this is as good as I can get it.";
            }
            else
                tbMessageBox.Text =
                    "I suggest you make the following adjustments to the inputs" +
                    Environment.NewLine + "Spunkees: " + adjCalc.AdjESp +
                    Environment.NewLine + "Bligees: " + adjCalc.AdjEB +
                    Environment.NewLine + "Plinks: " + adjCalc.AdjEP +
                    Environment.NewLine + "Workbenches: " + adjCalc.AdjTW +
                    Environment.NewLine + "Bligs: " + adjCalc.AdjTB;

        }

        /**
         * <summary>
         *  Displays status information about the bligs and bligees of the given state,
         *  indexed by the provided time-stamp.
         * </summary>
         * <param name="cStateInfo">State to print information about.</param>
         * <param name="iTimeLine">Timestamp equivalent to the hour of production when we would be in the given state.</param>
         * 
         */
        private void displayBlStatusInfo(CStateInfo cStateInfo, Int32 iTimeLine)
        {
         
            dgvBlInfo.Rows.Clear();
         
//            CStateInfo cStateInfo = (CStateInfo)listStatusInfo[iTimeLine];
            for (Int32 i = 0; i < 5; i++)
            {
                dgvBlInfo.Rows.Add(new Object[] { Convert.ToString(8-i)+" h.",
                                                  cStateInfo.ListBligStatus[i], "", "" });
            }
            for (Int32 i = 0; i < 2; i++)
            {
                dgvBlInfo.Rows.Add(new Object[] { Convert.ToString(3-i)+" h.",
                                                  cStateInfo.ListBligStatus[i+5], 
                                                  cStateInfo.ListNormalBligeeStatus[i], "" });
            }
            for (Int32 i = 0; i < 2; i++)
            {
                dgvBlInfo.Rows.Add(new Object[] { Convert.ToString(1-i)+" h.",
                                                  cStateInfo.ListBligStatus[i+7], 
                                                  cStateInfo.ListNormalBligeeStatus[i+2], 
                                                  cStateInfo.ListFastBligeeStatus[i]});
            }

             ArrayList listHistoryStatus = new ArrayList();
            foreach (DataGridViewRow row in dgvBlInfo.Rows)
            {
                CBlStatusDGV blStatusDGV = new CBlStatusDGV(
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString());
                listHistoryStatus.Add(blStatusDGV);
            }
            htStatuInfo.Add(iTimeLine, listHistoryStatus);

            dgvBlInfo.ClearSelection();
        }

        /**
         * <summary>
         * Performed when the "Step" button is clicked.
         * Prompts the search to advance by 1 hour if the
         * number of serviced plonks is less than 1000,
         * otherwise does nothing.
         * </summary>
         */
        private void btStep_Click(object sender, EventArgs e)
        {
            if (cStateInfo.IServicedPlonks < 1000)
            {

                doAll();
                
            }
            

        }

       /**
        * <summary>
        *   Displays the blig-information for the given time.
        * </summary>
        * <param name="rowIndex">
        *   Time for which we should display blig information. This value coincides with the row index.
        * </param>
        */
        private void redisplayBlStatusInfo(Int32 rowIndex)
        {
            dgvBlInfo.Rows.Clear();
            ArrayList temp = (ArrayList)htStatuInfo[rowIndex];
            if(temp != null)
            {
                for (Int32 i = 0; i < temp.Count; i++)
                {
                    dgvBlInfo.Rows.Add(new Object[]{
                    ((CBlStatusDGV)temp[i]).Hours,
                    ((CBlStatusDGV)temp[i]).Bligs,
                    ((CBlStatusDGV)temp[i]).BligeesNormmal,
                    ((CBlStatusDGV)temp[i]).BligeesFast
                });
                }
            }
            dgvBlInfo.ClearSelection();
           
        }

        /**
         * <summary>
         *  Fires when the "Run" button is clicked.
         *  Advances the search until the goal is reached.
         * </summary>
         */
        private void btRun_Click(object sender, EventArgs e)
        {
            while (cStateInfo.IServicedPlonks < 1000)
            {
                doAll();
            }
            btRun.Enabled = false;
            btStep.Enabled = false;
            btStart.Enabled = true;
            txTotalBlig.Enabled = true;
            txTotalBlige.Enabled = true;
            txTotalPl.Enabled = true;
            txTotalSp.Enabled = true;
            txTotalWb.Enabled = true;
            
        }

        /**
         * <summary>
         *  Adds the actions performed to reach the given state to the
         *  list of actions performed with the given timestamp as index.
         * </summary>
         * <param name="cStateInfo">State to display actions for.</param>
         * <param name="iTimeline">Timestamp equivalent to the hour of production when we would be in the given state.</param>
         */
        private void displayActionInfo(CStateInfo cStateInfo, Int32 iTimeline)
        {
            dgvAction.Rows.Add(new Object[]{iTimeLine,
                                            cStateInfo.ITimesMakeSpunks,
                                            cStateInfo.SBNormalTimes,
                                            cStateInfo.SBFastTimes,
                                            cStateInfo.ITimesFindPlonks,
                                            cStateInfo.ITimesServePlonks});
            if (iTimeLine - 4 > 0)
            {
                dgvAction.FirstDisplayedScrollingRowIndex = iTimeLine - 4;
            }
        }

        /// <summary>
        /// Fires when a row in the status display is selected.
        /// Updates the blig status display with information
        /// for the time of that row and displays the that time
        /// in the actions display.
        /// </summary>
        private void dgvInfo_SelectionChanged(object sender, EventArgs e)
        {
            display_selectionChanged(sender as DataGridView);
        }

        /// <summary>
        /// Fires when a row in the actions display is selected.
        /// Updates the blig status display with information
        /// for the time of that row and displays the that time
        /// in the status display.
        /// </summary>
        private void dgvAction_SelectionChanged(object sender, EventArgs e)
        {
            display_selectionChanged(sender as DataGridView);
        }

        /// <summary>
        /// Used to prevent infinite recursion when
        /// changing selection in either the status
        /// display or action display
        /// </summary>
        private bool selectionHandlerActive = true;

        /// <summary>
        /// Tries to identify the given DataGridView as either
        /// the status display or the actions display. If the
        /// view can be identifed: updates the selection of the
        /// other view to match and updates the blig display with
        /// information for the hour of the selected row.
        /// </summary>
        /// <param name="dgv"></param>
        private void display_selectionChanged(DataGridView dgv){
            if (dgv == null || dgv.CurrentRow == null || !selectionHandlerActive)
                return;

            selectionHandlerActive = false;

            DataGridView dgv2;

            if (dgv == dgvInfo)
                dgv2 = dgvAction;
            else if (dgv == dgvAction)
                dgv2 = dgvInfo;
            else
            {
                selectionHandlerActive = true;
                return;
            }

            Int32 rowIndex = dgv.CurrentRow.Index;
            redisplayBlStatusInfo(rowIndex);

            try
            {
                //dgv2.FirstDisplayedScrollingRowIndex = rowIndex;
                dgv2.FirstDisplayedScrollingRowIndex = dgv.FirstDisplayedScrollingRowIndex;
                dgv2.ClearSelection();
                dgv2.Rows[rowIndex].Selected = true;
            }
            catch (Exception)
            {
                // We failed to select the row in the status display. Oh well...
            }

            selectionHandlerActive = true;
        }
        /// <summary>
        /// Start a new thread to use brute force finding the best 
        /// distribution of the resources. Results will be displaed
        /// in the text messsagebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSearch_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(useBruteForce));
            t.Start();
        }
        /// <summary>
        /// Brute Force. Hahaha..............
        /// </summary>
        private void useBruteForce()
        {
            int lim;
            try
            {
                lim = Convert.ToInt32(tbBruteForceLim.Text);
            }
            catch (Exception)
            {
                return;
            }

            CStateInfo csi = new CStateInfo();
            int itime = 0;
            int minTime = 1000;
            for (int a = 1; a <= lim; a++)
            {

                csi.ISpunkeesAvailable = a;
                itime = 0;

                for (int b = 1; b <= lim; b++)
                {
                    csi.IBligeesAvailable = b;
                    for (int c = 1; c <= lim; c++)
                    {
                        csi.IBligTotal = c;
                        csi.IBligsAvailable = c;
                        csi.ListBligStatus[0] = c;
                        for (int d = 1; d <= lim; d++)
                        {
                            csi.IWorkbenchesAvailable = d;
                            for (int f = 1; f <= lim; f++)
                            {
                                csi.IPlinksAvailable = f;
                                if (a + b + c + d + f == lim)
                                {
                                    while (csi.IServicedPlonks < 1000)
                                    {
                                        CActions cActions = new CActions(csi);
                                        cActions.nextAction();
                                        itime++;
                                    }
                                    if (itime < minTime)
                                    {


                                        setTextBoxText(tbMessageBox,
                                            "",
                                            false);
                                        minTime = itime;
                                        setTextBoxText(tbMessageBox,
                                            "SP:" + a + "  " + "BE:" + b + "  " + "PL:" + f + "  " + "BL:" + c + "  " + "WB:" + d + "  MIN:"+ minTime +"h\r\n",
                                            false);
                                        //tbMessageBox.Text = "SP:" + a + " " + "BE:" + b + "  " + "PL:" + f + "  " + "BL:" + c + "  " + "WB:" + d + " ";

                                    }
                                    else if (itime == minTime)
                                    {
                                        setTextBoxText(tbMessageBox,
                                            "SP:" + a + "  " + "BE:" + b + "  " + "PL:" + f + "  " + "BL:" + c + "  " + "WB:" + d + "  MIN:" + minTime + "h\r\n",
                                            true);
                                        //tbMessageBox.Text += "\nSP:" + a + "  " + "BE:" + b + "  " + "PL:" + f + "  " + "BL:" + c + "  " + "WB:" + d + "  ";
                                        // Console.WriteLine("Spunkees:" + a + "Bligee" + b + "Blig" + c + "WB:" + d + "Plink:" + f + "_" + minTime);
                                    }


                                    csi = new CStateInfo();
                                    csi.ISpunkeesAvailable = a;
                                    csi.IBligeesAvailable = b;
                                    csi.IBligTotal = c;
                                    csi.IBligsUnavailable = c;
                                    csi.ListBligStatus[8] = c;
                                    csi.IWorkbenchesAvailable = d;
                                    itime = 0;

                                }
                            }
                        }
                    }
                }
            }

        }

        /// <summary>
        /// Declare of a delegate method
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="str"></param>
        /// <param name="add"></param>
        private delegate void deleSetTextBoxText(System.Windows.Forms.TextBox tb, String str, Boolean add);


        /// <summary>
        /// A delegated method to set textbox text in a different thread.
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="str"></param>
        /// <param name="add"></param>
        private void SetTextBoxText(System.Windows.Forms.TextBox tb, String str, Boolean add)
        {
            if (add)
            {
                tb.Text += str;
            }
            else
            {
                tb.Text = str;
            }
            
        }


        /// <summary>
        /// Method be invoked by the thread.
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="str"></param>
        /// <param name="add"></param>
        private void setTextBoxText(System.Windows.Forms.TextBox tb, String str, Boolean add)
        {
            this.BeginInvoke(new deleSetTextBoxText(SetTextBoxText),new Object[]{tb,str,add});
        }
    }
}
