using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace AIAssignment1
{
    class HFunction
    {

        public Int32 HFunction(CStateInfo cStateInfo)
        {

            //Calculate number of actions
            //Servicing Plonks
            int NSP = (1000 - cStateInfo.IServicedPlonks) / 5;
            //Finding Plonks
            int NFP = (1000 - cStateInfo.IServicedPlonks - cStateInfo.IUnservicedPlonks) / 10;
            //Servicing Bligs
            int Bh = 8 * (Int32)cStateInfo.ListBligStatus[0] + 7 * (Int32)cStateInfo.ListBligStatus[1] + 6 * (Int32)cStateInfo.ListBligStatus[2] + 5 * (Int32)cStateInfo.ListBligStatus[3] + 4 * (Int32)cStateInfo.ListBligStatus[4] + 3 * (Int32)cStateInfo.ListBligStatus[5] + 2 * (Int32)cStateInfo.ListBligStatus[6] + (Int32)cStateInfo.ListBligStatus[7];
            int NSB = (NSP - Bh) / 8;
            //Making Spunks
            int NMS = (20 * NSP + 10 * NFP + 20 * NSB - cStateInfo.ISpunks) / 50;

            //Calculate TW-hours
            int TWh = (NMS + 2 * NSB + NSP) / cStateInfo.IWorkbenchesAvailable;
            //and Plink-hours
            int EPh = (NSP + NFP) / cStateInfo.IPlinksAvailable;
            if (EPh > TWh) { return EPh; }
            return TWh;
        }

    }
}