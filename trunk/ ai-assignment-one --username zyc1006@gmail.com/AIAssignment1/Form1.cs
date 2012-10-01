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
     
        private CStateInfo cStateInfo = null;
        private CActions cActions = null;
        private Int32 iTimeLine = 0;
        private Hashtable htStatuInfo = new Hashtable();
        public Form1()
        {
            InitializeComponent();
            cStateInfo = new CStateInfo();
            dgvInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void btStart_Click(object sender, EventArgs e)
        {
            lbMessage.Text = "";
            dgvInfo.Rows.Clear();
            dgvBlInfo.Rows.Clear();
            dgvAction.Rows.Clear();
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
    //        displayStatusInfo(cStateInfo, iTimeLine);
    //        displayBlStatusInfoTest(cStateInfo, iTimeLine);
        }

        private Boolean validateInput()
        {
            return true;
        }

        private Boolean initializeState()
        {
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

        private void doAll()
        {
            cActions.nextAction();
            iTimeLine++;
            displayActionInfo(cStateInfo, iTimeLine);
            displayStatusInfo(cStateInfo, iTimeLine);
            displayBlStatusInfo(cStateInfo, iTimeLine - 1);
        }

        private void displayStatusInfo(CStateInfo cStateInfo, Int32 iTimeLine)
        {

            dgvInfo.Rows.Add(new Object[]
                              {iTimeLine,cStateInfo.ISpunkeesAvailable, cStateInfo.IPlinksAvailable, 
                               cStateInfo.IWorkbenchesAvailable, cStateInfo.ISpunks,
                               cStateInfo.IUnservicedPlonks, cStateInfo.IServicedPlonks});
            if (iTimeLine - 4 > 0)
            {
                dgvInfo.FirstDisplayedScrollingRowIndex = iTimeLine - 4;
            }
            
        }

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
        }


        private void btStep_Click(object sender, EventArgs e)
        {
            if (cStateInfo.IServicedPlonks < 1000)
            {

                doAll();
                
            }
            

        }

        private void dgvInfo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 rowIndex = dgvInfo.CurrentRow.Index;
            redisplayBlStatusInfo(rowIndex);
            
//            displayBlStatusInfo(cStateInfo, rowIndex);
        }

       
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
           
        }

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

       
        
    }
}
