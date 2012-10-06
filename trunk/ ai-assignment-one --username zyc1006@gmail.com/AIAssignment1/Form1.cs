using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace AIAssignment1
{
    public partial class Form1 : Form
    {

        private Dictionary<Int32, CStateInfo> oldStates = new Dictionary<Int32, CStateInfo>();

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
            txTotalBlig.Enabled = false;
            txTotalBlige.Enabled = false;
            txTotalPl.Enabled = false;
            txTotalSp.Enabled = false;
            txTotalWb.Enabled = false;
            btStart.Enabled = false;
            btStep.Enabled = true;
            btRun.Enabled = true;

            oldStates.Clear();

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
            lbMessage.Text = "";
            dgvInfo.Rows.Clear();
            dgvBlInfo.Rows.Clear();
            dgvAction.Rows.Clear();
            

            iTimeLine = 0;
            
            try
            {

                cStateInfo.ISpunkeesAvailable = Convert.ToInt32(txTotalSp.Text);
                cStateInfo.IBligeesAvailable = Convert.ToInt32(txTotalBlige.Text);
                cStateInfo.IPlinksAvailable = Convert.ToInt32(txTotalPl.Text);
                cStateInfo.IWorkbenchesAvailable = Convert.ToInt32(txTotalWb.Text);
                //cStateInfo.IBligsAvailable = Convert.ToInt32(txTotalBlig.Text);
                cStateInfo.IBligsUnavailable = Convert.ToInt32(txTotalBlig.Text);
                cStateInfo.IBligTotal = Convert.ToInt32(txTotalBlig.Text);
                //cStateInfo.ListBligStatus[0] = cStateInfo.IBligsAvailable;
                cStateInfo.ListBligStatus[8] = cStateInfo.IBligsUnavailable;
                if (cStateInfo.ISpunkeesAvailable < 1 || cStateInfo.IBligeesAvailable < 1 ||
                    cStateInfo.IPlinksAvailable < 1 || cStateInfo.IWorkbenchesAvailable < 1 ||
                    cStateInfo.IBligTotal < 1)
                {
                    lbMessage.Text = "Invalid input!";
                    return false;
                }
                cActions = new CActions(cStateInfo);
                return true;
            }
            catch (System.Exception e)
            {
                lbMessage.Text = "Invalid input!";
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
                                cStateInfo.IBligsAvailable,
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
                avgTB += kvp.Value.IBligsAvailable;
            }

            tbAverageExcessBox.Text =
                "Spunkees: " + Math.Floor(avgESp / iTimeLine) +
                Environment.NewLine + "Bligees: " + Math.Floor(avgEB / iTimeLine) +
                Environment.NewLine + "Plinks: " + Math.Floor(avgEP / iTimeLine) +
                Environment.NewLine + "Workbenches: " + Math.Floor(avgTW / iTimeLine) +
                Environment.NewLine + "Bligs: " + Math.Floor(avgTB / iTimeLine);

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
                dgv2.FirstDisplayedScrollingRowIndex = rowIndex;
                dgv2.ClearSelection();
                dgv2.Rows[rowIndex].Selected = true;
            }
            catch (Exception)
            {
                // We failed to select the row in the status display. Oh well...
            }

            selectionHandlerActive = true;
        }
        
    }
}
